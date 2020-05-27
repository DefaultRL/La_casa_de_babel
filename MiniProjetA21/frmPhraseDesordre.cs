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
        public frmPhraseDesordre()
        {
            InitializeComponent();
        }

        DataSet tables = new DataSet();
        string numCours;
        int numLecon;
        int numExo;

        public frmPhraseDesordre(DataSet ds, string cours, int lecon, int exo)
        {
            MessageBox.Show("User : " + numCours + numLecon + numExo);
            tables = ds;
            numCours = cours;
            numLecon = lecon;
            numExo = exo;
        }

        private void frmPhraseDesordre_Load(object sender, EventArgs e)
        {
            List<string> mots = new List<string>();

            string requete = @"select [codePhrase] from Exercices where [codeExo] =" + numExo;

            foreach(DataRow dr in tables.Tables["Phrases"].Rows)
            {

            }
        }
    }
}
