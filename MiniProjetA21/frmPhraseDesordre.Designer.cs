namespace MiniProjetA21
{
    partial class frmPhraseDesordre
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbDesordre = new System.Windows.Forms.GroupBox();
            this.btnSoluc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTradcPhrase = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbDesordre.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LA CASA DE BABEL";
            // 
            // gbDesordre
            // 
            this.gbDesordre.Controls.Add(this.textBox1);
            this.gbDesordre.Controls.Add(this.btnSoluc);
            this.gbDesordre.Controls.Add(this.btnReset);
            this.gbDesordre.Controls.Add(this.lblTradcPhrase);
            this.gbDesordre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDesordre.Location = new System.Drawing.Point(12, 220);
            this.gbDesordre.Name = "gbDesordre";
            this.gbDesordre.Size = new System.Drawing.Size(1159, 377);
            this.gbDesordre.TabIndex = 1;
            this.gbDesordre.TabStop = false;
            this.gbDesordre.Text = "Remettez les éléments dans l\'ordre";
            // 
            // btnSoluc
            // 
            this.btnSoluc.Location = new System.Drawing.Point(6, 322);
            this.btnSoluc.Name = "btnSoluc";
            this.btnSoluc.Size = new System.Drawing.Size(161, 47);
            this.btnSoluc.TabIndex = 2;
            this.btnSoluc.Text = "Solution";
            this.btnSoluc.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1008, 322);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 49);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Rétablir";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblTradcPhrase
            // 
            this.lblTradcPhrase.AutoSize = true;
            this.lblTradcPhrase.Location = new System.Drawing.Point(74, 69);
            this.lblTradcPhrase.Name = "lblTradcPhrase";
            this.lblTradcPhrase.Size = new System.Drawing.Size(42, 23);
            this.lblTradcPhrase.TabIndex = 0;
            this.lblTradcPhrase.Text = "N/A";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 30);
            this.textBox1.TabIndex = 3;
            // 
            // frmPhraseDesordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1183, 609);
            this.Controls.Add(this.gbDesordre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmPhraseDesordre";
            this.Text = "Exercice : Phrases dans le désordre";
            this.Load += new System.EventHandler(this.frmPhraseDesordre_Load);
            this.gbDesordre.ResumeLayout(false);
            this.gbDesordre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTradcPhrase;
        private System.Windows.Forms.GroupBox gbDesordre;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSoluc;
        private System.Windows.Forms.TextBox textBox1;
    }
}