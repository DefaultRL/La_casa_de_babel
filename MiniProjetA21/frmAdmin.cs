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

        public frmAdmin(DataSet ds, string PrenomNom)
        {
            tables = ds;
            UtilNP = PrenomNom;
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lblUtilisateur.Text = UtilNP;

            cboCours.DataSource = tables.Tables["Cours"];
            cboCours.DisplayMember = "titreCours";
            cboCours.ValueMember = "numCours";
            cboCours.SelectedIndex = -1;
        }
        
        private void cboCours_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            MessageBox.Show(cbo.SelectedItem.ToString());
        }
    }
}
