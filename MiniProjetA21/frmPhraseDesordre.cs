using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.CodeDom.Compiler;

namespace MiniProjetA21
{
    public partial class frmPhraseDesordre : Form
    {
        DataSet ds = new DataSet();
        string numCours;
        int numLecon;
        int numExo;
        List<string> listMot = new List<string>();
        
        DataTable recap = new DataTable();
        bool affichSolution = false;
        string baseReponse = string.Empty;
        string reponse = string.Empty;
        string corrige = string.Empty;
        string nomUtil = "";
        frmStart formSTART;

        public frmPhraseDesordre(frmStart frm, ref DataSet dataset, ref DataTable dt, string cours, int lecon, int exo, string util)
        {
            InitializeComponent();
            ds = dataset;
            numCours = cours;
            numLecon = lecon;
            numExo = exo;
            nomUtil = util;
            recap = dt;
            formSTART = frm;
        }

        private void frmPhraseDesordre_Load(object sender, EventArgs e)
        {
            //Récupération du codePhrase dans la table Exercices
            string filtreExo = @"[numCours] = '" + numCours + "' and [numLecon] = " + numLecon + 
                             " and [numExo] = " + numExo;
            DataRow[] tabRes = ds.Tables["Exercices"].Select(filtreExo);

            string filtrePhrase = @"[codePhrase] = " + tabRes[0][0];
            DataRow[] tabTraduc = ds.Tables["Phrases"].Select(filtrePhrase);
            
            //Récupération de traducPhrase dans la table Phrase
            lblTraducPhrase.Text = tabTraduc[0][2].ToString();
            //Récupération de la phrase en espagnol
            string textPhrase = tabTraduc[0][1].ToString();

            //Récupération des mots da la phrase dans une list
            char separator = ' ';
            string[] tabMots = textPhrase.Split(separator);
            //Ajout des mots dans la listMot initialisée en globale
            for(int i = 0; i < tabMots.Length; i++)
            {
                listMot.Add(tabMots[i]);
            }

            Random rd = new Random();
            int gauche = 30;
            int haut = 140;
            int j = 0;
            int motRand = 0;

            int leftL = 30;
            int topL = 160;
            int leftR = 80;
            int topR = 160;

            for (int i = 0; i < tabMots.Length; i++)
            {
                //Création et paramètrages des textbox pour chaque mots
                TextBox tb = new TextBox();
                tb.Tag = i;
                tb.ReadOnly = true;
                tb.TextAlign = HorizontalAlignment.Center;
                tb.BackColor = Color.Yellow;
                tb.Left = gauche;
                tb.Top = haut;
                gauche += 120;

                //Ajout aléatoire de chaque mot pour chaque textbox
                motRand = rd.Next(listMot.Count - 1);
                tb.Text = listMot[motRand];
                listMot.RemoveAt(motRand);
 
                gbDesordre.Controls.Add(tb);

                //Création et paramètrage des boutons de déplacements
                
                Button btnL = new Button();
                btnL.Tag = i;
                btnL.Left = leftL;
                btnL.Top = topL;
                btnL.Size = new System.Drawing.Size(50, 25);
                btnL.Text = "<";
                btnL.UseVisualStyleBackColor = true;
                leftL += 120;
                btnL.Click += new EventHandler(clickGauche);             

                Button btnR = new Button();
                btnR.Tag = i;
                btnR.Left = leftR;
                btnR.Top = topR;
                btnR.Size = new System.Drawing.Size(50, 25);
                btnR.Text = ">";
                btnR.UseVisualStyleBackColor = true;
                leftR += 120;
                btnR.Click += new EventHandler(clickDroit);
                
                gbDesordre.Controls.Add(btnL);
                gbDesordre.Controls.Add(btnR);

                //Modification de position en bout de ligne
                j++;
                if (j > 8)
                {
                    haut += 50;
                    gauche = 30;
                    leftL = 30;
                    topL += 50;
                    leftR = 80;
                    topR += 50;
                    j = 0;
                }     
            }

            //On replace les mots supprimés dans la list global pour la validation
            for (int i = 0; i < tabMots.Length; i++)
            {
                listMot.Add(tabMots[i]);
            }

            btnNext.Visible = false;
        }

        //Evenements des boutons de déplacements gauche puis droite
        private void clickGauche(object sender, EventArgs e)
        {
            erpValide.Clear();
            foreach (Control tb in gbDesordre.Controls.OfType<TextBox>())
            {
                tb.BackColor = Color.Yellow;
            }

            Button btn = (Button)sender;
            int here = (int)btn.Tag;

            string textTemp = "";
            TextBox courant = new TextBox();

            foreach (Control whereiam in gbDesordre.Controls.OfType<TextBox>())
            {
                if((int)whereiam.Tag == here)
                {
                    courant = (TextBox)whereiam;
                }    
            }

            foreach(Control gauche in gbDesordre.Controls.OfType<TextBox>())
            {
                if ((int)gauche.Tag == here - 1 && (int)gauche.Tag > -1)
                {
                    textTemp = courant.Text;
                    courant.Text = gauche.Text;
                    gauche.Text = textTemp;
                }
            }
        }

        private void clickDroit(object sender, EventArgs e)
        {
            erpValide.Clear();
            foreach (Control tb in gbDesordre.Controls.OfType<TextBox>())
            {
                tb.BackColor = Color.Yellow;
            }

            Button btn = (Button)sender;
            int here = (int)btn.Tag;

            string textTemp = "";
            TextBox courant = new TextBox();

            foreach (Control whereiam in gbDesordre.Controls.OfType<TextBox>())
            {
                if ((int)whereiam.Tag == here)
                {
                    courant = (TextBox)whereiam;
                }
            }

            foreach (Control droite in gbDesordre.Controls.OfType<TextBox>())
            {
                if ((int)droite.Tag == here + 1 && (int)droite.Tag < listMot.Count)
                {
                    textTemp = courant.Text;
                    courant.Text = droite.Text;
                    droite.Text = textTemp;
                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter ?\n(l'exercice actuel ne sera pas compte comme acquis)", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
        }

        private void btnSoluc_Click(object sender, EventArgs e)
        {
            erpValide.Clear();

            foreach (Control txtbox in gbDesordre.Controls.OfType<TextBox>())
            {
                txtbox.Text = listMot[(int)txtbox.Tag];
                txtbox.BackColor = Color.LightGreen;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            erpValide.Clear();
            foreach(Control tb in gbDesordre.Controls.OfType<TextBox>())
            {
                tb.BackColor = Color.Yellow;
            }
            melange();
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            erpValide.Clear();
            btnNext.Visible = true;

            //On récupère ce que l'utilisateur à choisis
            List<string> listCheck = new List<string>();
            foreach(Control tb in gbDesordre.Controls.OfType<TextBox>())
            {
                listCheck.Add(tb.Text);
            }

            bool res = true;
            int i = 0;
            while (i < listMot.Count && res != false) 
            {
                if(listMot[i] != listCheck[i])
                {
                    res = false;
                    erpValide.SetError(lblTraducPhrase, "Traduction incorrect");
                    foreach (Control tb in gbDesordre.Controls.OfType<TextBox>())
                    {
                        tb.BackColor = Color.Red;
                    }
                }
                i++;
            }

            if (res == true)
            {
                foreach (Control tb in gbDesordre.Controls.OfType<TextBox>())
                {
                    tb.BackColor = Color.LightGreen;
                }
                res = false;
            }     
        }

        private void melange()
        {
            Random rd = new Random();
            List<string> temp = new List<string>(listMot);
            int motRand = -1;
            foreach(Control tb in gbDesordre.Controls.OfType<TextBox>())
            {
                motRand = rd.Next(temp.Count);
                tb.Text = temp[motRand];
                temp.RemoveAt(motRand);
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
            DataRow ligneUtil = ds.Tables["Utilisateurs"].Select("[nomUtil] = '" + nomUtil + "'").FirstOrDefault();

            // on cherche si il existe un exercice apres celui ci dans ce cours et cette lecon
            DataRow[] tabRow = ds.Tables["Exercices"].Select("[numLecon] = '" + numLecon.ToString() + "' and [numCours] = '" + numCours + "' and [numExo] = '" + (numExo + 1).ToString() + "'");
            if (tabRow.Length == 0) // si l'exercice suivant n'existe pas
            {
                tabRow = ds.Tables["Exercices"].Select("[numLecon] = '" + (numLecon + 1).ToString() + "' and [numCours] = '" + numCours + "' and [numExo] = '1'");
                if (tabRow.Length == 0) // si la lecon suivante n'existe pas
                {
                    MessageBox.Show("Le cours est fini");
                }
                else // si la lecon suivante existe
                {
                    ligneUtil["codeLeçon"] = numLecon + 1;
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

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            
        }
    }  
}
