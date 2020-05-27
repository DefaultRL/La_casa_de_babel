using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjetA21
{
    public partial class frmPhrases_a_trous : Form
    {
        public DataSet tables = new DataSet();
        public string numCours;
        public int numLecon;
        public int numExo;
        public string chaine_connexion;
        List<string> liste_motsManquants = new List<string>();


        public frmPhrases_a_trous(DataSet ds, string cours, int lecon, int exo)
        {
            tables = ds;
            numCours = cours;
            numLecon = lecon;
            numExo = exo;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int codePhrase = -1;
            string numMots = string.Empty;
            string textePhrase = string.Empty;
            string traducPhrase = string.Empty;
            List<int> liste_numMots = new List<int>();
            



            // parcours de la table <Cours> afin de trouver son titre et de l'afficher en en-tete de fenetre
            foreach (DataRow dr in tables.Tables["Cours"].Rows)
            {
                if (dr[0].ToString() == numCours)
                    this.Text = dr[1].ToString();
            }

            // parcours de la table <Exercices> afin de trouver les informations necessaires
            foreach(DataRow dr in tables.Tables["Exercices"].Rows)
            {
                bool a = int.Parse(dr["numExo"].ToString()) == numExo;
                bool b = dr["numCours"].ToString() == numCours;
                bool c = int.Parse(dr["numLecon"].ToString()) == numLecon;

                if (a && b && c)
                {
                    // on recupere ici l'enonce, le code de la phrase et les mots a completer
                    lblEnonce.Text = dr["enonceExo"].ToString();
                    codePhrase = int.Parse(dr["codePhrase"].ToString());
                    numMots = dr["listeMots"].ToString();
                }
            } // fin foreach <Exercices>

            // parcours de la table <Phrases> afin de trouver les informations necessaires
            foreach(DataRow dr in tables.Tables["Phrases"].Rows)
            {
                if (int.Parse(dr[0].ToString()) == codePhrase)
                {
                    textePhrase = dr["textePhrase"].ToString();
                    traducPhrase = dr["traducPhrase"].ToString();
                }
            } // fin foreach <Phrases>



            // on recupere la liste de mots a completer
            liste_numMots = numMots.Split('/').Select(int.Parse).ToList();
            
            foreach(int i in liste_numMots)
            {
                liste_motsManquants.Add( textePhrase.Split(' ')[i] );
            }



            // generation de la phrase a afficher dans le label, sans les mots a completer
            // generation dynamique des textBox
            // 110 165 location label
            // dimensions label : 10 pxl par charactere + 4 pxl
            string temp = string.Empty;
            int location_txb = 114;
            foreach(string str in textePhrase.Split(' '))
            {
                if ( liste_motsManquants.Contains(str))
                {
                    temp += ' ';
                    location_txb += 10;

                    TextBox txbMot = new TextBox();

                    txbMot.BackColor = System.Drawing.Color.White;
                    txbMot.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txbMot.Location = new System.Drawing.Point(location_txb, 162);
                    txbMot.Name = "txbMot_" + str;
                    txbMot.AutoSize = true;
                    txbMot.TabIndex = 6;

                    gpbPhrases_Trous.Controls.Add(txbMot);

                    // on remplace les mots manquants par des espaces
                    for (int i = 0; i < str.Length; i++)
                    {
                        temp += ' ';
                        location_txb += 10;
                    }
                    
                    temp += ' ';
                    location_txb += 10;
                }
                else
                {
                    temp += str;
                    // 1 charactere = 10 pxl
                    location_txb += str.Length*10;
                }
                temp += ' ';
            } // fin foreach textePhrase
            lblPhrase.Text = temp;
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(Control ctrl in gpbPhrases_Trous.Controls)
            {
                if(ctrl is TextBox)
                {
                    if(ctrl.Text == liste_motsManquants[i])
                    {
                        ctrl.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        ctrl.BackColor = System.Drawing.Color.Red;
                    }
                    i++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control ctrl in gpbPhrases_Trous.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = liste_motsManquants[i];
                    i++;
                }
            }
        }
    }
}
