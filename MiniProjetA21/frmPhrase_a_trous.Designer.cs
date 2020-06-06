namespace MiniProjetA21
{
    partial class frmPhrases_a_trous
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
            this.gpbPhrases_Trous = new System.Windows.Forms.GroupBox();
            this.lblTrad = new System.Windows.Forms.Label();
            this.btnAffichSolut = new System.Windows.Forms.Button();
            this.btnVerif = new System.Windows.Forms.Button();
            this.lblEnonce = new System.Windows.Forms.Label();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.gpbPhrases_Trous.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitlePhrases_Trous
            // 
            this.lblTitlePhrases_Trous.AutoSize = true;
            this.lblTitlePhrases_Trous.Location = new System.Drawing.Point(420, 35);
            this.lblTitlePhrases_Trous.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitlePhrases_Trous.Name = "lblTitlePhrases_Trous";
            this.lblTitlePhrases_Trous.Size = new System.Drawing.Size(363, 38);
            this.lblTitlePhrases_Trous.TabIndex = 1;
            this.lblTitlePhrases_Trous.Text = "LA CASA DE BABBEL";
            // 
            // gpbPhrases_Trous
            // 
            this.gpbPhrases_Trous.Controls.Add(this.lblTrad);
            this.gpbPhrases_Trous.Controls.Add(this.btnAffichSolut);
            this.gpbPhrases_Trous.Controls.Add(this.btnVerif);
            this.gpbPhrases_Trous.Controls.Add(this.lblEnonce);
            this.gpbPhrases_Trous.Controls.Add(this.lblPhrase);
            this.gpbPhrases_Trous.Controls.Add(this.btnExit);
            this.gpbPhrases_Trous.Controls.Add(this.btnNext);
            this.gpbPhrases_Trous.Font = new System.Drawing.Font("Arial", 14.25F);
            this.gpbPhrases_Trous.Location = new System.Drawing.Point(12, 100);
            this.gpbPhrases_Trous.Name = "gpbPhrases_Trous";
            this.gpbPhrases_Trous.Size = new System.Drawing.Size(1157, 494);
            this.gpbPhrases_Trous.TabIndex = 2;
            this.gpbPhrases_Trous.TabStop = false;
            this.gpbPhrases_Trous.Text = "Phrase à trous";
            // 
            // lblTrad
            // 
            this.lblTrad.AutoSize = true;
            this.lblTrad.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrad.Location = new System.Drawing.Point(131, 211);
            this.lblTrad.Name = "lblTrad";
            this.lblTrad.Size = new System.Drawing.Size(48, 17);
            this.lblTrad.TabIndex = 9;
            this.lblTrad.Text = "trad";
            // 
            // btnAffichSolut
            // 
            this.btnAffichSolut.Location = new System.Drawing.Point(6, 454);
            this.btnAffichSolut.Name = "btnAffichSolut";
            this.btnAffichSolut.Size = new System.Drawing.Size(173, 34);
            this.btnAffichSolut.TabIndex = 8;
            this.btnAffichSolut.Text = "Afficher Solution";
            this.btnAffichSolut.UseVisualStyleBackColor = true;
            this.btnAffichSolut.Click += new System.EventHandler(this.btnAffichSolut_Click);
            // 
            // btnVerif
            // 
            this.btnVerif.Location = new System.Drawing.Point(799, 454);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(173, 34);
            this.btnVerif.TabIndex = 7;
            this.btnVerif.Text = "Vérifier";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // lblEnonce
            // 
            this.lblEnonce.AutoSize = true;
            this.lblEnonce.Font = new System.Drawing.Font("Arial", 18F);
            this.lblEnonce.Location = new System.Drawing.Point(52, 70);
            this.lblEnonce.Name = "lblEnonce";
            this.lblEnonce.Size = new System.Drawing.Size(448, 35);
            this.lblEnonce.TabIndex = 5;
            this.lblEnonce.Text = "Complétez les mots manquants :";
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhrase.Location = new System.Drawing.Point(110, 165);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(81, 20);
            this.lblPhrase.TabIndex = 6;
            this.lblPhrase.Text = "phrase";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(185, 454);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(978, 454);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(173, 34);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Exercice Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmPhrases_a_trous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1188, 611);
            this.Controls.Add(this.gpbPhrases_Trous);
            this.Controls.Add(this.lblTitlePhrases_Trous);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmPhrases_a_trous";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gpbPhrases_Trous.ResumeLayout(false);
            this.gpbPhrases_Trous.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePhrases_Trous;
        private System.Windows.Forms.GroupBox gpbPhrases_Trous;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblEnonce;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.Button btnAffichSolut;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.Label lblTrad;
    }
}