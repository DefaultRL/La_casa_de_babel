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

namespace MiniProjetA21
{
    public partial class frmPhraseDesordre : Form
    {
        DataSet ds = new DataSet();
        string numCours;
        int numLecon;
        int numExo;
        List<string> listMot = new List<string>();

        public frmPhraseDesordre(DataSet dataset, string cours, int lecon, int exo)
        {
            InitializeComponent();
            ds = dataset;
            numCours = cours;
            numLecon = lecon;
            numExo = exo;
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
            int top = 140;
            int j = 0;
            int motRand = 0;
            
            for (int i = 0; i < tabMots.Length; i++)
            {
                //Création et paramètrages des textbox pour chaque mots
                TextBox tb = new TextBox();
                tb.Tag = i;
                tb.ReadOnly = true;
                tb.TextAlign = HorizontalAlignment.Center;
                tb.BackColor = Color.Yellow;
                tb.Left = gauche;
                tb.Top = top;
                gauche += 120;

                //Ajout aléatoire de chaque mot pour chaque textbox
                motRand = rd.Next(listMot.Count - 1);
                tb.Text = listMot[motRand];
                listMot.RemoveAt(motRand);
 
                gbDesordre.Controls.Add(tb);

                //Modification de position en bout de ligne
                j++;
                if (j > 8)
                {
                    top += 50;
                    gauche = 30;
                    j = 0;
                }
            }
            for (int i = 0; i < tabMots.Length; i++)
            {
                listMot.Add(tabMots[i]);
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
            foreach(Control txtbox in gbDesordre.Controls.OfType<TextBox>())
            {
                txtbox.Text = listMot[(int)txtbox.Tag];
                txtbox.BackColor = Color.LightGreen;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
       
}
