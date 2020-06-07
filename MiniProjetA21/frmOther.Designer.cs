namespace MiniProjetA21
{
    partial class frmOther
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblDispo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(429, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(319, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "La Casa de Babbel";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(12, 553);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(135, 53);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1037, 553);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(134, 53);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblDispo
            // 
            this.lblDispo.AutoSize = true;
            this.lblDispo.Location = new System.Drawing.Point(226, 173);
            this.lblDispo.Name = "lblDispo";
            this.lblDispo.Size = new System.Drawing.Size(723, 38);
            this.lblDispo.TabIndex = 4;
            this.lblDispo.Text = "Cette exercice n\'est pas encore disponible !";
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(436, 253);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(312, 297);
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // frmOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1183, 618);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblDispo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmOther";
            this.Text = "frmOther";
            this.Load += new System.EventHandler(this.frmOther_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblDispo;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}