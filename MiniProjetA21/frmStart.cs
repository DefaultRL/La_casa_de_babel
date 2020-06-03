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
        // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Documents\DEV\GitHub\MiniProjet_HugoKellian\MiniProjetA21\baseLangue.mdb
        // Provider=Microsoft.Jet.OLEDB.4.0;Data Source = F:\Documents\Visual Studio 2019\MiniProjet_HugoKellian\MiniProjetA21\baseLangue.mdb
        string chaine = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Documents\DEV\GitHub\MiniProjet_HugoKellian\MiniProjetA21\baseLangue.mdb";
        
        //Initialisation de la connection
        OleDbConnection connec = new OleDbConnection();
        DataSet ds = new DataSet();
        string prenomNomUtil;

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
            lblUserComment.Visible = false;
            lblFleche.Visible = false;
            lblUserProg.Visible = false;
            lblUserExo.Visible = false;
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
                //Récup 
                prenomNomUtil = cbUser.SelectedItem.ToString();

                lblCoursActuel.Visible = true;
                lblLeconActuelle.Visible = true;

                connec.Open();

                string recupInfos = @"select [codeCours], [codeLeçon] from Utilisateurs 
                            where [codeUtil]= " + cbUser.SelectedIndex;

                //Paramètrage de l'objet commande
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = recupInfos;

                //Execution de la requète
                OleDbDataReader dr = cmd.ExecuteReader();

                //Tant que le DataReader n'est pas null
                while (dr.Read())
                {
                    //On recupere le titreCours correspond au numCours
                    string cours = @"select [titreCours] from Cours where ucase([numCours])='"
                                    + dr.GetString(0) + "'";
                    OleDbCommand cmdCours = new OleDbCommand();
                    cmdCours.Connection = connec;
                    cmdCours.CommandType = CommandType.Text;
                    cmdCours.CommandText = cours;
                    
                    //On l'ajoute au GroupBox
                    string coursUser = cmdCours.ExecuteScalar().ToString();
                    lblUserCours.Text = coursUser;

                    //On recupere le titreLecon correspondant au nomLecon
                    string lecon = @"select [titreLecon] from Lecons where [numLecon] = "
                                    + dr.GetInt32(1);
                    OleDbCommand cmdLecon = new OleDbCommand();
                    cmdLecon.Connection = connec;
                    cmdLecon.CommandType = CommandType.Text;
                    cmdLecon.CommandText = lecon;

                    //On l'ajoute au GroupBox
                    string leconUser = cmdLecon.ExecuteScalar().ToString();
                    lblUserLecon.Text = leconUser;

                    //On recupere le commentLecon correspondant au numLecon
                    string comment = @"select [commentLecon] from Lecons where [numLecon] = "
                                    + dr.GetInt32(1);
                    OleDbCommand cmdComment = new OleDbCommand();
                    cmdComment.Connection = connec;
                    cmdComment.CommandType = CommandType.Text;
                    cmdComment.CommandText = comment;

                    //On l'ajoute au GroupBox
                    string commentUser = cmdComment.ExecuteScalar().ToString();
                    lblUserComment.Text = commentUser;

                    string progression = @"select [numExo] from Exercices where [numLecon] = "
                                        + dr.GetInt32(1);
                    OleDbCommand cmdExo = new OleDbCommand();
                    cmdExo.Connection = connec;
                    cmdExo.CommandType = CommandType.Text;
                    cmdExo.CommandText = progression;

                    string exoUser = cmdExo.ExecuteScalar().ToString();
                    lblUserExo.Text = exoUser;
                }

                //On met à jour l'interface
                lblUserCours.Visible = true;
                lblUserLecon.Visible = true;
                lblUserComment.Visible = true;
                lblFleche.Visible = true;
                lblUserProg.Visible = true;
                lblUserExo.Visible = true;
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

        
        // bouton Exercice Suivant
        private void btnNext_Click(object sender, EventArgs e)
        {
            // on récupère en local toutes les tables de la base et on les stocke dans le DataSet tables
            DataSet tables = new DataSet();
            OleDbConnection connec = new OleDbConnection();
            connec.ConnectionString = chaine;
            DataTable schemaTable = new DataTable();

            // try-catch pour recuperer le schema des tables de la base de donnee
            try
            {
                connec.Open();
                schemaTable = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                connec.Close();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("ERREUR : Connexion à la base");
            }
            catch (OleDbException)
            {
                MessageBox.Show("ERREUR : Requete");
            }
            catch (Exception erreur)
            {
                MessageBox.Show("ERREUR : " + erreur.GetType().ToString());
            }
            finally
            {
                if (connec.State == ConnectionState.Open)
                    connec.Close();
            }


            // try-catch pour remplir le DataSet tables a partir du schema obtenu ci-dessus
            try
            {
                foreach (DataRow row in schemaTable.Rows)
                {
                    string temp = row[2].ToString();

                    string requete = "SELECT * FROM " + temp;
                    connec.ConnectionString = chaine;

                    OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                    da.Fill(tables, temp);
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("ERREUR : Connexion à la base");
            }
            catch (OleDbException)
            {
                MessageBox.Show("ERREUR : Requete");
            }
            catch (Exception erreur)
            {
                MessageBox.Show("ERREUR : " + erreur.GetType().ToString());
            }
            finally
            {
                if (connec.State == ConnectionState.Open)
                    connec.Close();
            }


            // on recupere les informations courantes sur l'utilisateur
            int codeLecon = -1;
            int codeExo = -1;
            string codeCours = "";
            string nomUtil = prenomNomUtil.Split(' ')[1];

            foreach (DataRow ligne in tables.Tables["Utilisateurs"].Rows)
            {
                if(ligne[1].ToString() == nomUtil)
                {
                    codeLecon = (int)ligne[5];
                    codeExo = (int)ligne[4];
                    codeCours = ligne[6].ToString();
                }
            }


            // on cherche les informations concernant l'exercice courant de l'utilisateur
            foreach (DataRow ligne in tables.Tables["Exercices"].Rows)
            {
                if((int)ligne[0] == codeExo && ligne[1].ToString() == codeCours && (int)ligne[2] == codeLecon)
                {
                    bool completeON = (bool)ligne[6];
                    object listeMot = ligne[7];

                    // on regarde si listeMot est de type null
                    if(listeMot.GetType() == typeof(System.DBNull) && completeON == true)
                    {
                        frmPhraseDesordre form3 = new frmPhraseDesordre(tables, codeCours, codeLecon, codeExo);
                        form3.ShowDialog();
                    }
                    else
                    {
                        if (!completeON) // si listeMot n'est pas nul et completeON false alors c'est une phrase a trous
                        {
                            frmPhrases_a_trous form2 = new frmPhrases_a_trous(tables, codeCours, codeLecon, codeExo);
                            form2.ShowDialog();
                        }
                    }
                }
            }

        }// fin btnNext_Click
    }
}
