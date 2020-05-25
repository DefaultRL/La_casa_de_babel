using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public DataSet tables;
        public string numCours;
        public int numLecon;
        public int numExo;

        /* Phrases_a_trous  :   constructeur du formulaire
         *      ds              :   DataSet :   dataset local de l'ensemble des tables
         *      numeroExercice  :   int     :   indique le numero de l'exercice courant
         */
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
            List<string> listeMots = new List<string>();

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
                listeMots.Add( textePhrase.Split(' ')[i] );
            }

            // generation de la phrase a afficher dans le label, sans les mots a completer
            string temp = string.Empty;
            foreach(string str in textePhrase.Split(' '))
            {
                if ( listeMots.Contains(str))
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        temp += ' ';
                    }
                }
                else
                {
                    temp += str;
                }
            } // fin foreach textePhrase
            lblPhrase.Text = temp;


        }
    }
}
