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

        DataSet ds = new DataSet();
        string numCours;
        int numLecon;
        int numExo;

        string phrase = "";

        public frmPhraseDesordre(DataSet dataset, string cours, int lecon, int exo)
        {
            ds = dataset;
            numCours = cours;
            numLecon = lecon;
            numExo = exo;
            MessageBox.Show("User : " + numCours + " " + numLecon + " " + numExo);
        }

        private void frmPhraseDesordre_Load(object sender, EventArgs e)
        {
            //List<string> mots = new List<string>();

            string filtre = @"[codeExo] =" + numExo;
            MessageBox.Show(filtre);
            /*DataRow[] tabLigne = ds.Tables["Exercices"].Select(filtre);
           

            foreach(DataRow dr in ds.Tables["Phrases"].Rows)
            {
                if(dr[0] == tabLigne[5])
                {
                    phrase = dr[1].ToString();
                }
            }
            MessageBox.Show(phrase);*/
        }
    }
       
}
