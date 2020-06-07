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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbDesordre = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnValide = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSoluc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTraducPhrase = new System.Windows.Forms.Label();
            this.erpValide = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDesordre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpValide)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(395, 82);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LA CASA DE BABEL";
            // 
            // gbDesordre
            // 
            this.gbDesordre.Controls.Add(this.btnNext);
            this.gbDesordre.Controls.Add(this.btnValide);
            this.gbDesordre.Controls.Add(this.btnQuitter);
            this.gbDesordre.Controls.Add(this.btnSoluc);
            this.gbDesordre.Controls.Add(this.btnReset);
            this.gbDesordre.Controls.Add(this.lblTraducPhrase);
            this.gbDesordre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDesordre.Location = new System.Drawing.Point(12, 220);
            this.gbDesordre.Name = "gbDesordre";
            this.gbDesordre.Size = new System.Drawing.Size(1159, 377);
            this.gbDesordre.TabIndex = 1;
            this.gbDesordre.TabStop = false;
            this.gbDesordre.Text = "Remettez les éléments dans l\'ordre";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1022, 249);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 55);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Exercice Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // btnValide
            // 
            this.btnValide.Location = new System.Drawing.Point(1022, 322);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(131, 49);
            this.btnValide.TabIndex = 5;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(199, 322);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(148, 49);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSoluc
            // 
            this.btnSoluc.Location = new System.Drawing.Point(6, 322);
            this.btnSoluc.Name = "btnSoluc";
            this.btnSoluc.Size = new System.Drawing.Size(161, 47);
            this.btnSoluc.TabIndex = 2;
            this.btnSoluc.Text = "Solution";
            this.btnSoluc.UseVisualStyleBackColor = true;
            this.btnSoluc.Click += new System.EventHandler(this.btnSoluc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(849, 322);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 49);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Recommencer";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTraducPhrase
            // 
            this.lblTraducPhrase.AutoSize = true;
            this.lblTraducPhrase.Location = new System.Drawing.Point(74, 69);
            this.lblTraducPhrase.Name = "lblTraducPhrase";
            this.lblTraducPhrase.Size = new System.Drawing.Size(42, 23);
            this.lblTraducPhrase.TabIndex = 0;
            this.lblTraducPhrase.Text = "N/A";
            // 
            // erpValide
            // 
            this.erpValide.ContainerControl = this;
            // 
            // frmPhraseDesordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1183, 609);
            this.Controls.Add(this.gbDesordre);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmPhraseDesordre";
            this.Text = "Exercice : Phrases dans le désordre";
            this.Load += new System.EventHandler(this.frmPhraseDesordre_Load);
            this.gbDesordre.ResumeLayout(false);
            this.gbDesordre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpValide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTraducPhrase;
        private System.Windows.Forms.GroupBox gbDesordre;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSoluc;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.ErrorProvider erpValide;
        private System.Windows.Forms.Button btnNext;
    }
}