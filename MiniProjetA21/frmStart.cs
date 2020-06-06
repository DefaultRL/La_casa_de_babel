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
using System.Collections;

namespace MiniProjetA21
{ 
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        //Definition chaine de connection à la base
        string chaine = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = .\baseLangue.mdb";
        
        //Initialisation des variables globales
        OleDbConnection connec = new OleDbConnection();
        DataSet ds = new DataSet();
        DataSet tables = new DataSet();
        DataTable tableRecap = new DataTable();
        string prenomNomUtil;
        string[] administrateurs = { "Véronique Richard", "Murielle Torregrossa" };

        private void frmStart_Load(object sender, EventArgs e)
        {
            btnAdmin.Hide();

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
            progBar.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Fermeture du formulaire
            Application.Exit();
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableRecap.Clear();
            tableRecap.Columns.Add("Reussite", typeof(bool));
            tableRecap.Columns.Add("numCours", typeof(string));
            tableRecap.Columns.Add("numLecon", typeof(int));
            tableRecap.Columns.Add("numExo", typeof(int));
            tableRecap.Columns.Add("Reponse", typeof(string));
            tableRecap.Columns.Add("Corrige", typeof(string));
            tableRecap.Columns.Add("AffichSolution", typeof(bool));

            OleDbConnection connexion = new OleDbConnection();
            connexion.ConnectionString = chaine;

            try
            {
                //Récup 
                prenomNomUtil = cbUser.SelectedItem.ToString();

                lblCoursActuel.Visible = true;
                lblLeconActuelle.Visible = true;

                connexion.Open();

                string recupInfos = @"select [codeCours], [codeLeçon] from Utilisateurs 
                            where [codeUtil]= " + cbUser.SelectedIndex;

                //Paramètrage de l'objet commande
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connexion;
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
                    cmdCours.Connection = connexion;
                    cmdCours.CommandType = CommandType.Text;
                    cmdCours.CommandText = cours;
                    
                    //On l'ajoute au GroupBox
                    string coursUser = cmdCours.ExecuteScalar().ToString();
                    lblUserCours.Text = coursUser;

                    //On recupere le titreLecon correspondant au nomLecon
                    string lecon = @"select [titreLecon] from Lecons where [numLecon] = "
                                    + dr.GetInt32(1);
                    OleDbCommand cmdLecon = new OleDbCommand();
                    cmdLecon.Connection = connexion;
                    cmdLecon.CommandType = CommandType.Text;
                    cmdLecon.CommandText = lecon;

                    //On l'ajoute au GroupBox
                    string leconUser = cmdLecon.ExecuteScalar().ToString();
                    lblUserLecon.Text = leconUser;

                    //On recupere le commentLecon correspondant au numLecon
                    string comment = @"select [commentLecon] from Lecons where [numLecon] = "
                                    + dr.GetInt32(1);
                    OleDbCommand cmdComment = new OleDbCommand();
                    cmdComment.Connection = connexion;
                    cmdComment.CommandType = CommandType.Text;
                    cmdComment.CommandText = comment;

                    //On l'ajoute au GroupBox
                    string commentUser = cmdComment.ExecuteScalar().ToString();
                    lblUserComment.Text = commentUser;

                    string progression = @"select [codeExo] from Utilisateurs where [codeLeçon] = "
                                        + dr.GetInt32(1);
                    OleDbCommand cmdExo = new OleDbCommand();
                    cmdExo.Connection = connexion;
                    cmdExo.CommandType = CommandType.Text;
                    cmdExo.CommandText = progression;

                    //On affiche la progression de l'utilisateur
                    string exoUser = cmdExo.ExecuteScalar().ToString();
                    lblUserExo.Text = exoUser;

                    string total = @"select count(*) from Exercices where [numCours] = '"
                                        + dr.GetString(0) + "' and [numLecon] = " + dr.GetInt32(1) ;
                    OleDbCommand cmdTotal = new OleDbCommand();
                    cmdTotal.Connection = connexion;
                    cmdTotal.CommandType = CommandType.Text;
                    cmdTotal.CommandText = total;

                    string exoTotal = cmdTotal.ExecuteScalar().ToString();
                    lblUserExo.Text = lblUserExo.Text + "/" + exoTotal;
                    progBar.Value = Int32.Parse(exoUser);
                    progBar.Maximum = Int32.Parse(exoTotal);
                }

                //On met à jour l'interface
                lblUserCours.Visible = true;
                lblUserLecon.Visible = true;
                lblUserComment.Visible = true;
                lblFleche.Visible = true;
                lblUserProg.Visible = true;
                lblUserExo.Visible = true;
                progBar.Visible = true;           
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
                if (connexion.State == ConnectionState.Open)
                {
                    //Si tout s'est bien passé on ferme la connection
                    connexion.Close();
                }
            }

            // on récupère en local toutes les tables de la base et on les stocke dans le DataSet tables
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
                tables.Clear();
                foreach (DataRow rw in schemaTable.Rows)
                {
                    string temp = rw[2].ToString();

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

            if (administrateurs.Contains(prenomNomUtil))
            {
                btnAdmin.Show();
            }
            else
            {
                btnAdmin.Hide();
            }
        }

        
        // bouton Exercice Suivant
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbUser.Text))
            {
                erpErrors.SetError(cbUser, "Aucun utilisateur séléctionné");
            }

            else
            {
                // on recupere les informations courantes sur l'utilisateur
                int codeLecon = -1;
                int codeExo = -1;
                string codeCours = "";
                string nomUtil = prenomNomUtil.Split(' ')[1];

                DataRow row = tables.Tables["Utilisateurs"].Select("nomUtil = '" + nomUtil + "'").FirstOrDefault();
                codeLecon = (int)row["codeLeçon"];
                codeExo = (int)row["codeExo"];
                codeCours = row["codeCours"].ToString();

                // on cherche les informations concernant l'exercice courant de l'utilisateur
                row = tables.Tables["Exercices"].Select("numExo = '" + codeExo + "' and numCours = '" + codeCours + "' and numLecon = '" + codeLecon + "'").FirstOrDefault();

                bool completeON = (bool)row["completeON"];
                object listeMot = row["listeMots"];

                // on vérifie que codeCours est présent dans la table ConcerneMot
                string filtreCours = @"[numCours] ='" + codeCours + "'";
                DataRow[] res = tables.Tables["ConcerneMots"].Select(filtreCours);
                bool estPresent = false;
                if(res.Length == 0)
                {
                    estPresent = false;
                }
                else
                {
                    estPresent = true;
                }


                //---CONDITIONS DE LANCEMENTS DES FORMULAIRES EXERCICES---

                // si listeMot est null et completeON est true, alors c'est une phrase desordre
                if (listeMot.GetType() == typeof(System.DBNull) && completeON == true)
                {
                    frmPhraseDesordre form3 = new frmPhraseDesordre(tables, codeCours, codeLecon, codeExo);
                    form3.ShowDialog();
                }

                // si listeMot n'est pas null et completeON false, alors c'est une phrase a trous
                else if (listeMot.GetType() != typeof(System.DBNull) && !completeON)
                {
                    frmPhrases_a_trous form2 = new frmPhrases_a_trous(ref tables, ref tableRecap, codeCours, codeLecon, codeExo, nomUtil);
                    form2.ShowDialog();        
                }

                // si listMot est null, completON est false et estPresent est vrai, alors c'est du vocabulaire
                else if(listeMot.GetType() == typeof(System.DBNull) && !completeON && estPresent)
                {     
                    frmCours form3 = new frmCours(tables, codeCours, codeLecon, codeExo);
                    form3.ShowDialog();
                }

            }

        }// fin btnNext_Click

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin form = new frmAdmin(tables, prenomNomUtil);
            form.ShowDialog();
        }
    }
}
