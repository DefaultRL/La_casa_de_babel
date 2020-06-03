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
        string numCours;
        int numLecon;
        int numExo;
        List<string> liste_motsManquants = new List<string>();
        bool exerciceRate = false;



        // constructeur
        public frmPhrases_a_trous(DataSet ds, string cours, int lecon, int exo)
        {
            tables = ds;
            numCours = cours;
            numLecon = lecon;
            numExo = exo;

            InitializeComponent();
        }




        private void Form2_Load(object sender, EventArgs e)
        {
            int codePhrase = -1;
            string numMots = string.Empty;
            string textePhrase = string.Empty;
            string traducPhrase = string.Empty;
            List<int> liste_numMots = new List<int>();
            

            // parcours de la table <Cours> afin de trouver son titre et de l'afficher en en-tete de fenetre
            foreach (DataRow dr in tables.Tables["Cours"].Rows)
            {
                if (dr[0].ToString() == numCours)
                    this.Text = dr[1].ToString();
            }


            // parcours de la table <Exercices> afin de trouver les informations necessaires
            foreach(DataRow dr in tables.Tables["Exercices"].Rows)
            {
                bool a = int.Parse(dr["numExo"].ToString()) == numExo;
                bool b = dr["numCours"].ToString() == numCours;
                bool c = int.Parse(dr["numLecon"].ToString()) == numLecon;

                if (a && b && c)
                {
                    // on recupere ici l'enonce, le code de la phrase et les mots a completer
                    lblEnonce.Text = dr["enonceExo"].ToString();
                    codePhrase = int.Parse(dr["codePhrase"].ToString());
                    numMots = dr["listeMots"].ToString();
                }
            } // fin foreach <Exercices>


            // parcours de la table <Phrases> afin de trouver les informations necessaires
            foreach(DataRow dr in tables.Tables["Phrases"].Rows)
            {
                if (int.Parse(dr[0].ToString()) == codePhrase)
                {
                    textePhrase = dr["textePhrase"].ToString();
                    traducPhrase = dr["traducPhrase"].ToString();
                }
            } // fin foreach <Phrases>


            // on recupere la liste de mots a completer
            liste_numMots = numMots.Split('/').Select(int.Parse).ToList();
            foreach(int i in liste_numMots)
            {
                liste_motsManquants.Add( textePhrase.Split(' ')[i-1] ); // i-1 car on commence l'indexation a 1 et non 0
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
                    temp += ' ';
                    location_txb += 10;

                    // on cree dynamiquement le textbox
                    TextBox txbMot = new TextBox();

                    txbMot.BackColor = System.Drawing.Color.White;
                    txbMot.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txbMot.Location = new System.Drawing.Point(location_txb, 162);
                    txbMot.Name = "txbMot_" + str;
                    txbMot.Width = str.Length * 12;
                    txbMot.Tag = liste_motsManquants.IndexOf(str);

                    gpbPhrases_Trous.Controls.Add(txbMot);
                    location_txb = txbMot.Width;

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
                    temp += str;
                    location_txb += str.Length*10;
                }

                temp += ' ';
                location_txb += 10;

            } // fin foreach textePhrase

            lblTrad.Text = traducPhrase;
            lblPhrase.Text = temp;
            lblPhrase.SendToBack();
            MessageBox.Show(temp + "\n" + textePhrase);
        } // fin Form2_Loas




        private void btnVerif_Click(object sender, EventArgs e)
        {
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
                }
            } // fin foreach ctrl in gpb

            if (toutJuste)
            {
                // ajout exercice reussi ============================================================================================
            }   // une table Locale a add et passer au contructeur, cacher le formStart pendant l'exercice
            else
            {
                // ajout exercice rate ==============================================================================================
            }
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter ?\n(l'exercice actuel ne sera pas compte comme acquis)", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
        }




        private void btnAffichSolut_Click(object sender, EventArgs e)
        {
            exerciceRate = true;
            foreach (Control ctrl in gpbPhrases_Trous.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = liste_motsManquants[(int)ctrl.Tag];
            }
        }



    }
}
