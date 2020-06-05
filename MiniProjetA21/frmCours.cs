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
    public partial class frmCours : Form
    {
        DataSet ds = new DataSet();
        string numCours;
        int numLecon;
        int numExo;

        public frmCours(DataSet dataset, string cours, int lecon, int exo)
        {
            InitializeComponent();
            ds = dataset;
            numCours = cours;
            numLecon = lecon;
            numExo = exo;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter ?\n", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
        }

        private void frmCours_Load(object sender, EventArgs e)
        {
            //Affichage de la lecon
            string filtreLecon = @"[numLecon]=" + numLecon;
            DataRow[] titreLecon = ds.Tables["Lecons"].Select(filtreLecon);
            lblLecon.Text = lblLecon.Text + titreLecon[0][2].ToString();

            //Affichage de l'énoncé
            string filtreExercice = @"[numCours]='" + numCours + "' and [numLecon]=" + numLecon;
            DataRow[] enonce = ds.Tables["Exercices"].Select(filtreExercice);
            gbCours.Text = gbCours.Text + enonce[0][3];

            //Parametrage et affichage de la bar de progression
            DataRow[] exoCours = ds.Tables["Exercices"].Select(filtreExercice);
            progBar.Value = Int32.Parse(exoCours[0][0].ToString());

            DataRow[] total = ds.Tables["Exercices"].Select(filtreExercice);
            progBar.Maximum = total.Length;

            lblProg.Text = exoCours[0][0].ToString() + "/" + total.Length.ToString();

            string filtreConcerneMot = @"[numCours]='" + numCours + "' and [numLecon]=" + numLecon +
                                " and [numExo]= " + numExo;
            DataRow[] numMot = ds.Tables["ConcerneMots"].Select(filtreConcerneMot);

            string filtreMots = @"[numMot]=" + numMot[0][3].ToString();
            DataRow[] mots = ds.Tables["Mots"].Select(filtreMots);
            MessageBox.Show(mots[0][0].ToString());

            int gauche = 125;
            int haut = 350;

            for(int i = 0; i < mots.Length; i++)
            {
                Label lbl = new Label();
                lbl.Left = gauche;
                lbl.Top = haut;
                lbl.Text = mots[i][2].ToString();

                gauche += 120;
            }
        }
    }
}
