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
            List<string> mots = new List<string>();

            //Récupération du codePhrase dans la table Exercices
            string filtreExo = @"[numCours] = '" + numCours + "' and [numLecon] = " + numLecon + 
                             " and [numExo] = " + numExo;
            DataRow[] tabRes = ds.Tables["Exercices"].Select(filtreExo);

            //Récupération de traducPhrase dans la table Phrase
            string filtrePhrase = @"[codePhrase] = " + tabRes[0][0];
            DataRow[] tabTraduc = ds.Tables["Phrases"].Select(filtrePhrase);

            lblTraducPhrase.Text = tabTraduc[0][2].ToString();

            string textPhrase = tabTraduc[0][1].ToString();

            char separator = ' ';
            string[] tabMots = textPhrase.Split(separator);

            Random rd = new Random();
            int gauche = 30;
            int top = 140;
            int j = 0;

            for (int i = 0; i < tabMots.Length; i++)
            {
                TextBox tb = new TextBox();
                tb.Tag = i;
                tb.ReadOnly = true;
                tb.TextAlign = HorizontalAlignment.Center;
                tb.Left = gauche;
                tb.Top = top;
                gauche += 120;
                
                tb.Text = tabMots[rd.Next(tabMots.Length - 1)];

                gbDesordre.Controls.Add(tb);

                j++;
                if (j > 8)
                {
                    top += 50;
                    gauche = 30;
                    j = 0;
                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter ?\n(l'exercice actuel ne sera pas compte comme acquis)", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
        }
    }
       
}
