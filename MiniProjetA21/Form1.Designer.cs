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
            this.lblConnec = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbConnec.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(420, 66);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(373, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LA CASA DE BABBEL";
            // 
            // gpbConnec
            // 
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
            // lblConnec
            // 
            this.lblConnec.AutoSize = true;
            this.lblConnec.Location = new System.Drawing.Point(111, 75);
            this.lblConnec.Name = "lblConnec";
            this.lblConnec.Size = new System.Drawing.Size(161, 23);
            this.lblConnec.TabIndex = 0;
            this.lblConnec.Text = "Connectez-vous :";
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(314, 72);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(313, 31);
            this.cbUser.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(966, 350);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(185, 52);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Exercice Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
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
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1181, 615);
            this.Controls.Add(this.gpbConnec);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmStart";
            this.Text = "LA CASA DE BABBEL";
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
    }
}

