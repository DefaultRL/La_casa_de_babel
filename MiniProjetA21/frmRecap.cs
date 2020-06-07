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
    public partial class frmRecap : Form
    {
        DataTable tableRecap;
        public frmRecap(DataTable dt)
        {
            tableRecap = dt;
            InitializeComponent();
        }

        private void frmRecap_Load(object sender, EventArgs e)
        {
            dgvTableRecap.DataSource = tableRecap;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous retourner au menu ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
                Close();
        }

    }
}
