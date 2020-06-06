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

            //On récupère le numMot en fonction des données utilisateurs
            string filtreConcerneMot = @"[numCours]='" + numCours + "' and [numLecon]=" + numLecon +
                                " and [numExo]= " + numExo;
            DataRow[] numMot = ds.Tables["ConcerneMots"].Select(filtreConcerneMot);

            //On ajoute chaque mot correspondant au numMot de ConcerneMots
            string filtreOrigine = "";
            DataRow[] mots = new DataRow[numMot.Length];
            for (int i = 0; i < numMot.Length; i++)
            {
                filtreOrigine = @"[numMot] =" + numMot[i][3];
                mots[i] = ds.Tables["Mots"].Select(filtreOrigine).FirstOrDefault();
            }

            int gauche = 75;

            for(int i = 0; i < mots.Length; i++)
            {
                //Labels origine
                Label origine = new Label();
                origine.Tag = i;
                origine.Left = gauche;
                origine.Top = 350;
                origine.Text = mots[i][4].ToString();

                gbCours.Controls.Add(origine);

                //Label mot 
                Label mot = new Label();
                mot.Tag = i;
                mot.Left = gauche;
                mot.Top = 300;
                mot.Text = mots[i][1].ToString();
                mot.ForeColor = Color.Red;

                gbCours.Controls.Add(mot);

                //Images correspondantes 
                PictureBox pb = new PictureBox();
                pb.Tag = i;
                pb.Left = gauche;
                pb.Top = 100;
                pb.Image = Image.FromFile("./Images/"+mots[i][3].ToString());
                pb.Size = new System.Drawing.Size(200, 200);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.BackColor = Color.White;

                gbCours.Controls.Add(pb);

                gauche += 275;
            }
        }
    }
}
