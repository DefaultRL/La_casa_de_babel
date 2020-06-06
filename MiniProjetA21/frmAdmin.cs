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
    public partial class frmAdmin : Form
    {
        DataSet tables;
        string UtilNP;
        string numCours;
        string numLecon;
        int numExo;
        int nbExos;

        public frmAdmin(DataSet ds, string PrenomNom)
        {
            tables = ds;
            UtilNP = PrenomNom;
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lblEnonPrec.Hide();
            lblEnon.Hide();
            lblEnonSuiv.Hide();
            lblPhrasePrec.Hide();
            lblPhrase.Hide();
            lblPhraseSuiv.Hide();

            lblUtilisateur.Text = UtilNP;

            cboCours.DataSource = tables.Tables["Cours"];
            cboCours.DisplayMember = "titreCours";
            cboCours.ValueMember = "numCours";
            cboCours.SelectedIndex = -1;
        }
        
        private void cboCours_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            numCours = cbo.SelectedValue.ToString();

            DataRow[] resLecons = tables.Tables["Lecons"].Select("numCours = '" + numCours + "'");

            DataTable dtDataSource = tables.Tables["Lecons"].Clone();
            foreach(DataRow dr in resLecons)
            {
                dtDataSource.ImportRow(dr);
            }

            cboLecons.DataSource = dtDataSource;
            cboLecons.DisplayMember = "titreLecon";
            cboLecons.ValueMember = "numLecon";  // Provoque l'erreur : System.ArgumentException : 'Liaison au nouveau membre Display impossible. Nom du paramètre: newDisplayMember'
            cboLecons.SelectedIndex = -1;
        }

        private void cboLecons_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            numLecon = cbo.SelectedValue.ToString();
            numExo = 1;
            affichageExercices(numExo);
        }

        /* procedure permettant d'afficher dans les labels du form
         * l'enonce et la phrase correspondante de l'exercice courant.
         * appelle la fonctionrecupInfoExo
         */
        private void affichageExercices(int numExo)
        {
            nbExos = tables.Tables["Exercices"].Select("numCours = '" + numCours + "' and numLecon = '" + numLecon + "'").Length;

            // reinitialisation des affichages des labels
            lblEnonPrec.Show();
            lblEnon.Show();
            lblEnonSuiv.Show();
            lblPhrasePrec.Show();
            lblPhrase.Show();
            lblPhraseSuiv.Show();

            string[] infoExo = new string[2];

            // affichage des exercices souhaites
            if(numExo == 1)
            {
                lblEnonPrec.Hide();
                lblPhrasePrec.Hide();

                // on affiche l'exercice courant
                infoExo = recupInfoExo(numExo.ToString());
                lblEnon.Text = infoExo[0];
                lblPhrase.Text = infoExo[1];

                //on affiche l'exercice suivant
                infoExo = recupInfoExo((numExo + 1).ToString());
                lblEnonSuiv.Text = infoExo[0];
                lblPhraseSuiv.Text = infoExo[1];
            }
            else if(numExo == nbExos)
            {
                lblEnonSuiv.Hide();
                lblPhraseSuiv.Hide();

                // on affiche l'exercice courant
                infoExo = recupInfoExo(numExo.ToString());
                lblEnon.Text = infoExo[0];
                lblPhrase.Text = infoExo[1];

                // on affiche l'exercice precedent
                infoExo = recupInfoExo((numExo - 1).ToString());
                lblEnonPrec.Text = infoExo[0];
                lblPhrasePrec.Text = infoExo[1];
            }
            else
            {
                // on affiche l'exercice precedent
                infoExo = recupInfoExo((numExo - 1).ToString());
                lblEnonPrec.Text = infoExo[0];
                lblPhrasePrec.Text = infoExo[1];

                // on affiche l'exercice courant
                infoExo = recupInfoExo(numExo.ToString());
                lblEnon.Text = infoExo[0];
                lblPhrase.Text = infoExo[1];

                //on affiche l'exercice suivant
                infoExo = recupInfoExo((numExo + 1).ToString());
                lblEnonSuiv.Text = infoExo[0];
                lblPhraseSuiv.Text = infoExo[1];
            }
        }

        /* fonction permettant a partir d'un numero d'exercice et des numeros de lecon et de cours
         * de renvoyer l'enonce d'un exercice et la phrase correspondante si il y en a une
         */
        private string[] recupInfoExo(string numExo)
        {
            // res [0] : enonce - res[1] : phrase concernee (si il y en a une)
            string[] res = new string[2];

            // on récupere la ligne correspondant a l'exercice courant
            DataRow dr = tables.Tables["Exercices"].Select("numCours = '" + numCours + "' and numLecon = '" + numLecon + "' and numExo = '" + numExo.ToString() + "'").FirstOrDefault();

            object o = dr["codePhrase"];
            if (o.GetType() == typeof(System.DBNull)) // on verifie que le codePhrase n'est pas Null dans la base de donnee
            {
                res[1] = string.Empty;
            }
            else
            {
                res[0] = dr["enonceExo"].ToString();

                string codePhrase = dr["codePhrase"].ToString();

                if (int.Parse(codePhrase) != 0) // on verifie que codePhrase n'est pas egal à 0
                {
                    DataRow dr2 = tables.Tables["Phrases"].Select("codePhrase = '" + codePhrase + "'").FirstOrDefault();

                    res[1] = dr2["textePhrase"].ToString();
                }
                else // alors codePhrase est egal a 0
                {
                    res[1] = string.Empty;
                }
            }

            return res;
        }

        private void clickButton_ChgtExo(object sender, EventArgs e)
        {
            /* TAGs :
             * 1 = premier exo
             * 2 = exo precedent
             * 3 = exo suivant
             * 4 = dernier exo
             */

            Button btn = (Button)sender;
            int tag = int.Parse(btn.Tag.ToString());

            switch (tag)
            {
                case 1: // premier exercice
                    if (numExo != 1) // on verifie que l'on est pas deja au premier exercice
                    {
                        numExo = 1;
                        affichageExercices(numExo);
                    }
                    break;

                case 2: // exercice precedent
                    if (numExo != 1) // on verifie que l'on est pas deja au premier exercice
                    {
                        numExo--;
                        affichageExercices(numExo);
                    }
                    break;

                case 3: // exercice suivant
                    if (numExo != nbExos) // on verifie que l'on est pas deja au dernier exercice
                    {
                        numExo++;
                        affichageExercices(numExo);
                    }
                    break;

                case 4: // dernier exercice
                    if (numExo != nbExos) // on verifie que l'on est pas deja au dernier exercice
                    {
                        numExo = nbExos;
                        affichageExercices(numExo);
                    }
                    break;

                default:
                    break;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous retourner au menu ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
        }
    }
}
