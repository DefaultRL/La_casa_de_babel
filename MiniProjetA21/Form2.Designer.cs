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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbPhrases_Trous.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitlePhrases_Trous
            // 
            this.lblTitlePhrases_Trous.AutoSize = true;
            this.lblTitlePhrases_Trous.Location = new System.Drawing.Point(420, 35);
            this.lblTitlePhrases_Trous.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitlePhrases_Trous.Name = "lblTitlePhrases_Trous";
            this.lblTitlePhrases_Trous.Size = new System.Drawing.Size(295, 32);
            this.lblTitlePhrases_Trous.TabIndex = 1;
            this.lblTitlePhrases_Trous.Text = "LA CASA DE BABBEL";
            // 
            // gpbPhrases_Trous
            // 
            this.gpbPhrases_Trous.Controls.Add(this.label1);
            this.gpbPhrases_Trous.Controls.Add(this.lblPhrase);
            this.gpbPhrases_Trous.Controls.Add(this.btnExit);
            this.gpbPhrases_Trous.Controls.Add(this.btnNext);
            this.gpbPhrases_Trous.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPhrases_Trous.Location = new System.Drawing.Point(12, 100);
            this.gpbPhrases_Trous.Name = "gpbPhrases_Trous";
            this.gpbPhrases_Trous.Size = new System.Drawing.Size(1157, 494);
            this.gpbPhrases_Trous.TabIndex = 2;
            this.gpbPhrases_Trous.TabStop = false;
            this.gpbPhrases_Trous.Text = "Phrase à trous";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(734, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 52);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(966, 435);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(185, 52);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Exercice Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Location = new System.Drawing.Point(120, 165);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(65, 18);
            this.lblPhrase.TabIndex = 4;
            this.lblPhrase.Text = "_phrase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Complétez les mots manquants :";
            // 
            // frmPhrases_a_trous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1182, 606);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhrase;
    }
}