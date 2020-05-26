namespace MiniProjetA21
{
    partial class frmStart
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gpbConnec = new System.Windows.Forms.GroupBox();
            this.lblUserExo = new System.Windows.Forms.Label();
            this.lblUserProg = new System.Windows.Forms.Label();
            this.lblUserComment = new System.Windows.Forms.Label();
            this.lblFleche = new System.Windows.Forms.Label();
            this.lblUserLecon = new System.Windows.Forms.Label();
            this.lblLeconActuelle = new System.Windows.Forms.Label();
            this.lblUserCours = new System.Windows.Forms.Label();
            this.lblCoursActuel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.lblConnec = new System.Windows.Forms.Label();
            this.gpbConnec.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(420, 66);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LA CASA DE BABBEL";
            // 
            // gpbConnec
            // 
            this.gpbConnec.Controls.Add(this.lblUserExo);
            this.gpbConnec.Controls.Add(this.lblUserProg);
            this.gpbConnec.Controls.Add(this.lblUserComment);
            this.gpbConnec.Controls.Add(this.lblFleche);
            this.gpbConnec.Controls.Add(this.lblUserLecon);
            this.gpbConnec.Controls.Add(this.lblLeconActuelle);
            this.gpbConnec.Controls.Add(this.lblUserCours);
            this.gpbConnec.Controls.Add(this.lblCoursActuel);
            this.gpbConnec.Controls.Add(this.btnExit);
            this.gpbConnec.Controls.Add(this.btnNext);
            this.gpbConnec.Controls.Add(this.cbUser);
            this.gpbConnec.Controls.Add(this.lblConnec);
            this.gpbConnec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConnec.Location = new System.Drawing.Point(12, 195);
            this.gpbConnec.Name = "gpbConnec";
            this.gpbConnec.Size = new System.Drawing.Size(1157, 408);
            this.gpbConnec.TabIndex = 1;
            this.gpbConnec.TabStop = false;
            this.gpbConnec.Text = "Bienvenue";
            // 
            // lblUserExo
            // 
            this.lblUserExo.AutoSize = true;
            this.lblUserExo.Location = new System.Drawing.Point(962, 80);
            this.lblUserExo.Name = "lblUserExo";
            this.lblUserExo.Size = new System.Drawing.Size(42, 23);
            this.lblUserExo.TabIndex = 11;
            this.lblUserExo.Text = "N/A";
            // 
            // lblUserProg
            // 
            this.lblUserProg.AutoSize = true;
            this.lblUserProg.Location = new System.Drawing.Point(730, 80);
            this.lblUserProg.Name = "lblUserProg";
            this.lblUserProg.Size = new System.Drawing.Size(200, 23);
            this.lblUserProg.TabIndex = 10;
            this.lblUserProg.Text = "Progression actuelle :";
            // 
            // lblUserComment
            // 
            this.lblUserComment.AutoSize = true;
            this.lblUserComment.Location = new System.Drawing.Point(310, 289);
            this.lblUserComment.Name = "lblUserComment";
            this.lblUserComment.Size = new System.Drawing.Size(42, 23);
            this.lblUserComment.TabIndex = 9;
            this.lblUserComment.Text = "N/A";
            // 
            // lblFleche
            // 
            this.lblFleche.AutoSize = true;
            this.lblFleche.Location = new System.Drawing.Point(197, 289);
            this.lblFleche.Name = "lblFleche";
            this.lblFleche.Size = new System.Drawing.Size(46, 23);
            this.lblFleche.TabIndex = 8;
            this.lblFleche.Text = ">>>";
            // 
            // lblUserLecon
            // 
            this.lblUserLecon.AutoSize = true;
            this.lblUserLecon.Location = new System.Drawing.Point(310, 232);
            this.lblUserLecon.Name = "lblUserLecon";
            this.lblUserLecon.Size = new System.Drawing.Size(42, 23);
            this.lblUserLecon.TabIndex = 7;
            this.lblUserLecon.Text = "N/A";
            // 
            // lblLeconActuelle
            // 
            this.lblLeconActuelle.AutoSize = true;
            this.lblLeconActuelle.Location = new System.Drawing.Point(111, 232);
            this.lblLeconActuelle.Name = "lblLeconActuelle";
            this.lblLeconActuelle.Size = new System.Drawing.Size(148, 23);
            this.lblLeconActuelle.TabIndex = 6;
            this.lblLeconActuelle.Text = "Leçon actuelle :";
            // 
            // lblUserCours
            // 
            this.lblUserCours.AutoSize = true;
            this.lblUserCours.Location = new System.Drawing.Point(310, 177);
            this.lblUserCours.Name = "lblUserCours";
            this.lblUserCours.Size = new System.Drawing.Size(42, 23);
            this.lblUserCours.TabIndex = 5;
            this.lblUserCours.Text = "N/A";
            // 
            // lblCoursActuel
            // 
            this.lblCoursActuel.AutoSize = true;
            this.lblCoursActuel.Location = new System.Drawing.Point(111, 177);
            this.lblCoursActuel.Name = "lblCoursActuel";
            this.lblCoursActuel.Size = new System.Drawing.Size(132, 23);
            this.lblCoursActuel.TabIndex = 4;
            this.lblCoursActuel.Text = "Cours actuel :";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(734, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 52);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(966, 350);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(185, 52);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Exercice Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(314, 72);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(313, 31);
            this.cbUser.TabIndex = 1;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // lblConnec
            // 
            this.lblConnec.AutoSize = true;
            this.lblConnec.Location = new System.Drawing.Point(111, 75);
            this.lblConnec.Name = "lblConnec";
            this.lblConnec.Size = new System.Drawing.Size(161, 23);
            this.lblConnec.TabIndex = 0;
            this.lblConnec.Text = "Connectez-vous :";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1182, 606);
            this.Controls.Add(this.gpbConnec);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmStart";
            this.Text = "Démarrage : LA CASA DE BABBEL";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.gpbConnec.ResumeLayout(false);
            this.gpbConnec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gpbConnec;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label lblConnec;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCoursActuel;
        private System.Windows.Forms.Label lblUserCours;
        private System.Windows.Forms.Label lblLeconActuelle;
        private System.Windows.Forms.Label lblUserLecon;
        private System.Windows.Forms.Label lblUserComment;
        private System.Windows.Forms.Label lblFleche;
        private System.Windows.Forms.Label lblUserProg;
        private System.Windows.Forms.Label lblUserExo;
    }
}

