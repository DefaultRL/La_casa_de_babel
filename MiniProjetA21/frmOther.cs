using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjetA21
{
    public partial class frmOther : Form
    {
        DataSet ds = new DataSet();
        string numCours;
        int numLecon;
        int numExo;

        DataTable recap = new DataTable();
        bool affichSolution = false;
        string baseReponse = string.Empty;
        string reponse = string.Empty;
        string corrige = string.Empty;
        string nomUtil = "";
        frmStart formSTART;

        public frmOther(frmStart frm, ref DataSet dataset, ref DataTable dt, string cours, int lecon, int exo, string util)
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

        private void frmOther_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter ?\n", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
        }
    }
}
