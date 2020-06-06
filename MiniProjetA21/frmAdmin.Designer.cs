namespace MiniProjetA21
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitlePhrases_Trous = new System.Windows.Forms.Label();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.cboCours = new System.Windows.Forms.ComboBox();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblLecon = new System.Windows.Forms.Label();
            this.cboLecons = new System.Windows.Forms.ComboBox();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbExercice = new System.Windows.Forms.GroupBox();
            this.lblPhraseSuiv = new System.Windows.Forms.Label();
            this.lblEnonSuiv = new System.Windows.Forms.Label();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.lblEnon = new System.Windows.Forms.Label();
            this.lblPhrasePrec = new System.Windows.Forms.Label();
            this.lblEnonPrec = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grbExercice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitlePhrases_Trous
            // 
            this.lblTitlePhrases_Trous.AutoSize = true;
            this.lblTitlePhrases_Trous.Location = new System.Drawing.Point(420, 35);
            this.lblTitlePhrases_Trous.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitlePhrases_Trous.Name = "lblTitlePhrases_Trous";
            this.lblTitlePhrases_Trous.Size = new System.Drawing.Size(363, 38);
            this.lblTitlePhrases_Trous.TabIndex = 2;
            this.lblTitlePhrases_Trous.Text = "LA CASA DE BABBEL";
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblUtilisateur.Location = new System.Drawing.Point(12, 130);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(44, 27);
            this.lblUtilisateur.TabIndex = 3;
            this.lblUtilisateur.Text = "util";
            // 
            // cboCours
            // 
            this.cboCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCours.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCours.FormattingEnabled = true;
            this.cboCours.Location = new System.Drawing.Point(272, 159);
            this.cboCours.Name = "cboCours";
            this.cboCours.Size = new System.Drawing.Size(226, 32);
            this.cboCours.TabIndex = 4;
            this.cboCours.SelectionChangeCommitted += new System.EventHandler(this.cboCours_SelectionChangeCommitted);
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblCours.Location = new System.Drawing.Point(276, 128);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(88, 32);
            this.lblCours.TabIndex = 5;
            this.lblCours.Text = "Cours";
            // 
            // lblLecon
            // 
            this.lblLecon.AutoSize = true;
            this.lblLecon.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblLecon.Location = new System.Drawing.Point(650, 128);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(103, 32);
            this.lblLecon.TabIndex = 7;
            this.lblLecon.Text = "Leçons";
            // 
            // cboLecons
            // 
            this.cboLecons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLecons.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLecons.FormattingEnabled = true;
            this.cboLecons.Location = new System.Drawing.Point(642, 159);
            this.cboLecons.Name = "cboLecons";
            this.cboLecons.Size = new System.Drawing.Size(226, 32);
            this.cboLecons.TabIndex = 6;
            this.cboLecons.SelectionChangeCommitted += new System.EventHandler(this.cboLecons_SelectionChangeCommitted);
            // 
            // btnPremier
            // 
            this.btnPremier.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremier.Location = new System.Drawing.Point(1083, 214);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(45, 45);
            this.btnPremier.TabIndex = 8;
            this.btnPremier.Tag = "1";
            this.btnPremier.Text = "🡅";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.clickButton_ChgtExo);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.Location = new System.Drawing.Point(1083, 288);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(45, 45);
            this.btnPrecedent.TabIndex = 9;
            this.btnPrecedent.Tag = "2";
            this.btnPrecedent.Text = " 🠹";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.clickButton_ChgtExo);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1083, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 11;
            this.button1.Tag = "4";
            this.button1.Text = "🡇";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clickButton_ChgtExo);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1083, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 10;
            this.button2.Tag = "3";
            this.button2.Text = " 🠻";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clickButton_ChgtExo);
            // 
            // grbExercice
            // 
            this.grbExercice.Controls.Add(this.lblPhraseSuiv);
            this.grbExercice.Controls.Add(this.lblEnonSuiv);
            this.grbExercice.Controls.Add(this.lblPhrase);
            this.grbExercice.Controls.Add(this.lblEnon);
            this.grbExercice.Controls.Add(this.lblPhrasePrec);
            this.grbExercice.Controls.Add(this.lblEnonPrec);
            this.grbExercice.Font = new System.Drawing.Font("Arial", 12F);
            this.grbExercice.Location = new System.Drawing.Point(68, 195);
            this.grbExercice.Name = "grbExercice";
            this.grbExercice.Size = new System.Drawing.Size(965, 334);
            this.grbExercice.TabIndex = 12;
            this.grbExercice.TabStop = false;
            this.grbExercice.Text = "Exercice";
            // 
            // lblPhraseSuiv
            // 
            this.lblPhraseSuiv.AutoSize = true;
            this.lblPhraseSuiv.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblPhraseSuiv.Location = new System.Drawing.Point(475, 256);
            this.lblPhraseSuiv.Name = "lblPhraseSuiv";
            this.lblPhraseSuiv.Size = new System.Drawing.Size(131, 28);
            this.lblPhraseSuiv.TabIndex = 5;
            this.lblPhraseSuiv.Text = "phraseSuiv";
            // 
            // lblEnonSuiv
            // 
            this.lblEnonSuiv.AutoSize = true;
            this.lblEnonSuiv.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblEnonSuiv.Location = new System.Drawing.Point(48, 256);
            this.lblEnonSuiv.Name = "lblEnonSuiv";
            this.lblEnonSuiv.Size = new System.Drawing.Size(137, 27);
            this.lblEnonSuiv.TabIndex = 4;
            this.lblEnonSuiv.Text = "enonceSuiv";
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPhrase.Location = new System.Drawing.Point(475, 154);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(90, 28);
            this.lblPhrase.TabIndex = 3;
            this.lblPhrase.Text = "phrase";
            // 
            // lblEnon
            // 
            this.lblEnon.AutoSize = true;
            this.lblEnon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEnon.Location = new System.Drawing.Point(48, 154);
            this.lblEnon.Name = "lblEnon";
            this.lblEnon.Size = new System.Drawing.Size(97, 29);
            this.lblEnon.TabIndex = 2;
            this.lblEnon.Text = "enonce";
            // 
            // lblPhrasePrec
            // 
            this.lblPhrasePrec.AutoSize = true;
            this.lblPhrasePrec.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic);
            this.lblPhrasePrec.Location = new System.Drawing.Point(475, 52);
            this.lblPhrasePrec.Name = "lblPhrasePrec";
            this.lblPhrasePrec.Size = new System.Drawing.Size(133, 28);
            this.lblPhrasePrec.TabIndex = 1;
            this.lblPhrasePrec.Text = "phrasePrec";
            // 
            // lblEnonPrec
            // 
            this.lblEnonPrec.AutoSize = true;
            this.lblEnonPrec.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblEnonPrec.Location = new System.Drawing.Point(48, 52);
            this.lblEnonPrec.Name = "lblEnonPrec";
            this.lblEnonPrec.Size = new System.Drawing.Size(140, 27);
            this.lblEnonPrec.TabIndex = 0;
            this.lblEnonPrec.Text = "enoncePrec";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnQuitter.Location = new System.Drawing.Point(17, 561);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(106, 33);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1182, 606);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.grbExercice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.lblLecon);
            this.Controls.Add(this.cboLecons);
            this.Controls.Add(this.lblCours);
            this.Controls.Add(this.cboCours);
            this.Controls.Add(this.lblUtilisateur);
            this.Controls.Add(this.lblTitlePhrases_Trous);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.grbExercice.ResumeLayout(false);
            this.grbExercice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePhrases_Trous;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.ComboBox cboCours;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.ComboBox cboLecons;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grbExercice;
        private System.Windows.Forms.Label lblPhrasePrec;
        private System.Windows.Forms.Label lblEnonPrec;
        private System.Windows.Forms.Label lblPhraseSuiv;
        private System.Windows.Forms.Label lblEnonSuiv;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.Label lblEnon;
        private System.Windows.Forms.Button btnQuitter;
    }
}