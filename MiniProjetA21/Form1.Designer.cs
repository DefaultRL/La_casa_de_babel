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
            this.gpbConnec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConnec.Location = new System.Drawing.Point(12, 195);
            this.gpbConnec.Name = "gpbConnec";
            this.gpbConnec.Size = new System.Drawing.Size(1199, 405);
            this.gpbConnec.TabIndex = 1;
            this.gpbConnec.TabStop = false;
            this.gpbConnec.Text = "Bienvenue";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1223, 612);
            this.Controls.Add(this.gpbConnec);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmStart";
            this.Text = "LA CASA DE BABBEL";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gpbConnec;
    }
}

