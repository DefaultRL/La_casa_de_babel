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
        DataSet ds = new DataSet();

        private void frmStart_Load(object sender, EventArgs e)
        {
            try
            {
                //Connection avec la chaine
                connec.ConnectionString = chaine;

                //Mise à jour du codeUtil de Toregrossa pour simplification
                connec.Open();
                string update = "update Utilisateurs set codeUtil = 0 where codeUtil = 6";
                OleDbCommand cmdUp = new OleDbCommand(update,connec);
                cmdUp.ExecuteNonQuery();
                
                //Récupération de la table en local avec le DataSet
                string requete = @"select * from Utilisateurs";
                OleDbCommand cmd = new OleDbCommand(requete,connec);
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "Users");

                //Remplissage de la combobox
                string name;
                foreach(DataRow ligne in ds.Tables["Users"].Rows)
                {
                    name = ligne["pnUtil"].ToString() + " " + ligne["nomUtil"].ToString();
                    cbUser.Items.Add(name);
                }

            }

            catch (InvalidOperationException)
            {
                //Erreur de connection à la base
                MessageBox.Show("Erreur de connection à la base de données (ComboBox)");
            }

            catch (OleDbException)
            {
                //Erreur requète SQL
                MessageBox.Show("Erreur dans la requète SQL (ComboBox)");
            }

            catch (Exception erreur)
            {
                //Exception inconnue
                MessageBox.Show("Autre erreur : " + erreur.GetType().ToString() + "(ComboBox)");
            }

            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    //Si tout s'est bien passé on ferme la connection
                    connec.Close(); 
                }
            }

            //Setup d'affichage de l'interface du Form1
            lblCoursActuel.Visible = false;
            lblLeconActuelle.Visible = false;
            lblUserCours.Visible = false;
            lblUserLecon.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Fermeture du formulaire
            Application.Exit();
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                lblCoursActuel.Visible = true;
                lblLeconActuelle.Visible = true;

                connec.Open();

                string recupInfos = @"select [codeCours], [codeLeçon] from Utilisateurs 
                            where [codeUtil]=" + cbUser.SelectedIndex;

                //Paramètrage de l'objet commande
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = recupInfos;

                //Execution de la requète
                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string cours = @"select [titreCours] from Cours where ucase([numCours])='"
                                    + dr.GetString(0) + "'";
                    OleDbCommand cmdCours = new OleDbCommand();
                    cmdCours.Connection = connec;
                    cmdCours.CommandType = CommandType.Text;
                    cmdCours.CommandText = cours;

                    string coursUser = cmdCours.ExecuteScalar().ToString();
                    lblUserCours.Text = coursUser;

                    string lecon = @"select [titreLecon] from Lecons where [numLecon] = "
                                    + dr.GetInt32(1);
                    OleDbCommand cmdLecon = new OleDbCommand();
                    cmdLecon.Connection = connec;
                    cmdLecon.CommandType = CommandType.Text;
                    cmdLecon.CommandText = lecon;

                    string leconUser = cmdLecon.ExecuteScalar().ToString();
                    lblUserLecon.Text = leconUser;
                }

                lblUserCours.Visible = true;
                lblUserLecon.Visible = true;
            }

            catch (InvalidOperationException)
            {
                //Erreur de connection à la base
                MessageBox.Show("Erreur de connection à la base de données (Lecon/Cours)");
            }

            catch (OleDbException)
            {
                //Erreur requète SQL
                MessageBox.Show("Erreur dans la requète SQL (Lecon/Cours)");
            }

            catch (Exception erreur)
            {
                //Exception inconnue
                MessageBox.Show("Autre erreur : " + erreur.GetType().ToString() + "(Lecon/Cours)");
            }

            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    //Si tout s'est bien passé on ferme la connection
                    connec.Close();
                }
            }
        }
    }
}
