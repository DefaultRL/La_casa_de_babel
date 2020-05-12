using System;
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
    public partial class Phrases_a_trous : Form
    {
        public DataSet tables;
        public int numCours;
        public int numLecon;
        public int numExo;

        /* Phrases_a_trous  :   constructeur du formulaire
         *      ds              :   DataSet :   dataset local de l'ensemble des tables
         *      numeroExercice  :   int     :   indique le numéro de l'exercice courant
         */
        public Phrases_a_trous(DataSet ds, int cours, int lecon, int exo)
        {
            tables = ds;
            numCours = cours;
            numLecon = lecon;
            numExo = exo;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "";
        }
    }
}
