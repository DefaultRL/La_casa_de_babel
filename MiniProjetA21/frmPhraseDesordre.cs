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
            MessageBox.Show("User : " + numCours + " " + numLecon + " " + numExo);
        }

        private void frmPhraseDesordre_Load(object sender, EventArgs e)
        {
            List<string> mots = new List<string>();

            string filtreExo = @"[numCours] = '" + numCours + "' and [numLecon] = " + numLecon + 
                             " and [numExo] = " + numExo;
            DataRow[] tabRes = ds.Tables["Exercices"].Select(filtreExo);

            string filtrePhrase = @"[codePhrase] = " + tabRes[0][0];
            DataRow[] tabTraduc = ds.Tables["Phrases"].Select(filtrePhrase);

            MessageBox.Show(tabTraduc[0][2].ToString());
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
       
}
