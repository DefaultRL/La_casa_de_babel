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
            pbLogo.Image = Image.FromFile("./Images/logo.jpg");
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter ?\n", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
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
    }
}
