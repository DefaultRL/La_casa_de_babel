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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        //Definition chaine de connection à la base
        string chaine = @"Provider=Microsoft.Jet.OLEDB.4.0;
        Data Source=F:\Documents\Visual Studio 2019\MiniProjet_HugoKellian\MiniProjetA21\baseLangue.mdb";

        //Initialisation de la connection
        OleDbConnection connec = new OleDbConnection();

        private void frmStart_Load(object sender, EventArgs e)
        {
            try
            {

                //Connection avec la chaine
                connec.ConnectionString = chaine;
                //Ouverture de la connection
                connec.Open();

                string requete = @"select [pnUtil],[nomUtil] from Utilisateurs";

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = requete;

                OleDbDataReader dr = new OleDbDataReader();
                while (dr.Read())
                {
                    
                }
            }

            catch (InvalidOperationException)
            {
                //Erreur de connection à la base
                MessageBox.Show("Erreur de connection à la base de données");
            }

            catch (OleDbException)
            {
                //Erreur requète SQL
                MessageBox.Show("Erreur dans la requète SQL");
            }

            catch (Exception erreur)
            {
                //Exception inconnue
                MessageBox.Show("Autre erreur : " + erreur.GetType().ToString());
            }
        }
    }
}
