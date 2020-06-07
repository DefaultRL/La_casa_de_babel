using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjetA21
{
    public partial class frmPhrases_a_trous : Form
    {
        DataSet tables = new DataSet();
        DataTable recap = new DataTable();
        string numCours;
        int numLecon;
        int numExo;
        string nomUtil;

        List<string> liste_motsManquants = new List<string>();
        bool affichSolution = false;
        string baseReponse = string.Empty;
        string reponse;
        string corrige = string.Empty;

        frmStart formSTART;



        // constructeur
        public frmPhrases_a_trous(frmStart frm, ref DataSet ds, ref DataTable dt, string cours, int lecon, int exo, string util)
        {
            formSTART = frm;
            tables = ds;
            recap = dt;
            numCours = cours;
            numLecon = lecon;
            numExo = exo;
            nomUtil = util;

            InitializeComponent();
        }




        private void Form2_Load(object sender, EventArgs e)
        {
            int codePhrase = -1;
            string numMots = string.Empty;
            string textePhrase = string.Empty;
            string traducPhrase = string.Empty;
            List<int> liste_numMots = new List<int>();
            btnNext.Hide();


            // parcours de la table <Cours> afin de trouver son titre et de l'afficher en en-tete de fenetre
            this.Text = tables.Tables["Cours"].Select("numCours = '" + numCours + "'").FirstOrDefault()[1].ToString();


            // parcours de la table <Exercices> afin de trouver les informations necessaires
            DataRow row = tables.Tables["Exercices"].Select("numExo = '" + numExo + "' and numCours = '" + numCours + "' and numLecon = '" + numLecon + "'").FirstOrDefault();
            lblEnonce.Text = row["enonceExo"].ToString();
            codePhrase = int.Parse(row["codePhrase"].ToString());
            numMots = row["listeMots"].ToString();


            // parcours de la table <Phrases> afin de trouver les informations necessaires
            row = tables.Tables["Phrases"].Select("codePhrase = '" + codePhrase + "'").FirstOrDefault();
            textePhrase = row["textePhrase"].ToString();
            corrige = textePhrase;
            traducPhrase = row["traducPhrase"].ToString();


            // on recupere la liste de mots a completer
            liste_numMots = numMots.Split('/').Select(int.Parse).ToList();
            foreach(int i in liste_numMots)
            {
                liste_motsManquants.Add( textePhrase.Split(' ')[i-1] ); // i-1 car on commence l'indexation a 1 et non 0 dans la phrase
            }


            // generation de la phrase a afficher dans le label, sans les mots a completer
            // generation dynamique des textBox
            // 110 165 location label
            // dimensions label : 12 pxl par charactere + 4 pxl de margin
            // dimensions textbox : 10 pxl par charactere
            string temp = string.Empty;
            int location_txb = 110;
            foreach(string str in textePhrase.Split(' '))
            {

                if (liste_motsManquants.Contains(str)) // si le mot courant str de la phrase est contenu dans la liste de mots manquants
                {
                    baseReponse += "* ";

                    temp += ' ';
                    location_txb += 10;

                    // on cree dynamiquement le textbox
                    TextBox txbMot = new TextBox();

                    txbMot.BackColor = System.Drawing.Color.White;
                    txbMot.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txbMot.Location = new System.Drawing.Point(location_txb, 162);
                    txbMot.Name = "txbMot_" + str;
                    txbMot.Width = str.Length * 10;
                    txbMot.Tag = liste_motsManquants.IndexOf(str);

                    gpbPhrases_Trous.Controls.Add(txbMot);
                    location_txb += txbMot.Width;

                    // on remplace le mot manquant par des espaces dans le label
                    for (int i = 0; i < str.Length; i++)
                    {
                        temp += ' ';
                    }
                    
                    temp += ' ';
                    location_txb += 10;
                }

                else // si le mot courant str n'est pas dans la liste des mots manquants
                {
                    baseReponse += str + ' ';

                    temp += str;
                    location_txb += str.Length*10;
                }

                temp += ' ';
                location_txb += 10;

            } // fin foreach textePhrase

            lblTrad.Text = traducPhrase;
            lblPhrase.Text = temp;
            lblPhrase.SendToBack();
        } // fin Form2_Loas




        private void btnVerif_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] tab = baseReponse.Split('*');
            reponse = tab[i];

            bool toutJuste = true;
            foreach(Control ctrl in gpbPhrases_Trous.Controls)
            {
                if(ctrl is TextBox)
                {
                    byte[] tempBytes;

                    tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(ctrl.Text);
                    string txbNonAccentuee = System.Text.Encoding.UTF8.GetString(tempBytes);

                    tempBytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(liste_motsManquants[(int)ctrl.Tag]);
                    string reponseNonAccentuee = System.Text.Encoding.UTF8.GetString(tempBytes);

                    if (txbNonAccentuee == reponseNonAccentuee)
                        ctrl.BackColor = System.Drawing.Color.Green;

                    else
                    {
                        toutJuste = false;
                        ctrl.BackColor = System.Drawing.Color.Red;
                    }

                    i++;
                    reponse += " " + ctrl.Text + " " + tab[i];
                }
            } // fin foreach ctrl in gpb

            if (toutJuste)
            {
                // ajout exercice reussi
                DataRow row = recap.NewRow();
                row["Reussite"] = true & !affichSolution; // false si l'utilisateur a affiche la solution
                row["numCours"] = numCours;
                row["numLecon"] = numLecon;
                row["numExo"] = numExo;
                row["Reponse"] = null;
                row["Corrige"] = null;
                row["AffichSolution"] = affichSolution;
                recap.Rows.Add(row);
            }
            btnNext.Show();
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter ?\n(l'exercice actuel ne sera pas compte comme acquis)", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
        }




        private void btnAffichSolut_Click(object sender, EventArgs e)
        {
            affichSolution = true;
            foreach (Control ctrl in gpbPhrases_Trous.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = liste_motsManquants[(int)ctrl.Tag];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (recap.Select("numCours = '" + numCours + "' and numLecon = '" + numLecon + "' and numExo = '" + numExo + "'").Length == 0) // si les données n'ont pas encore ete saisi dans la table Recap
            {
                DataRow row = recap.NewRow();
                row["Reussite"] = false;
                row["numCours"] = numCours;
                row["numLecon"] = numLecon;
                row["numExo"] = numExo;
                row["Reponse"] = reponse;
                row["Corrige"] = corrige;
                row["AffichSolution"] = affichSolution;
                recap.Rows.Add(row);
            }

            // on récupère la ligne concernant l'utilisateur courant
            DataRow ligneUtil = tables.Tables["Utilisateurs"].Select("[nomUtil] = '" + nomUtil + "'").FirstOrDefault();

            // on cherche si il existe un exercice apres celui ci dans ce cours et cette lecon
            DataRow[] tabRow = tables.Tables["Exercices"].Select("[numLecon] = '" + numLecon.ToString() + "' and [numCours] = '" + numCours + "' and [numExo] = '" + (numExo + 1).ToString() + "'");
            if(tabRow.Length == 0) // si l'exercice suivant n'existe pas
            {
                tabRow = tables.Tables["Exercices"].Select("[numLecon] = '" + (numLecon + 1).ToString() + "' and [numCours] = '" + numCours + "' and [numExo] = '1'");
                if (tabRow.Length == 0) // si la lecon suivante n'existe pas
                {
                    MessageBox.Show("Le cours est fini");
                }
                else // si la lecon suivante existe
                {
                    ligneUtil["codeLecon"] = numLecon + 1;
                    ligneUtil["codeExo"] = 1;
                }
            }
            else // si l'exercice suivant existe
            {
                ligneUtil["codeExo"] = numExo + 1;
            }

            this.Hide();

            formSTART.Next_Exercice(nomUtil); // lancement du nouvel exercice
        }
    }
}
