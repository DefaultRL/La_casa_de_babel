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

        string infos;

        public frmPhraseDesordre(string infos)
        {
            MessageBox.Show("Récupérations des infos frmStart :" + infos);
        }

        private void frmPhraseDesordre_Load(object sender, EventArgs e)
        {
            
        }

        public string message
        {
            get { return infos; }
            set { }
        }
      
    }
}
