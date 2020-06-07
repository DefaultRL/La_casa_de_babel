namespace MiniProjetA21
{
    partial class frmCours
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
            this.gbCours = new System.Windows.Forms.GroupBox();
            this.lblVoc = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.lblLecon = new System.Windows.Forms.Label();
            this.lblProg = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(415, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "LA CASA DE BABBEL";
            // 
            // gbCours
            // 
            this.gbCours.BackColor = System.Drawing.Color.LightGray;
            this.gbCours.Controls.Add(this.lblVoc);
            this.gbCours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCours.Location = new System.Drawing.Point(18, 147);
            this.gbCours.Name = "gbCours";
            this.gbCours.Size = new System.Drawing.Size(1149, 422);
            this.gbCours.TabIndex = 2;
            this.gbCours.TabStop = false;
            this.gbCours.Text = "Enoncé : ";
            // 
            // lblVoc
            // 
            this.lblVoc.AutoSize = true;
            this.lblVoc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoc.Location = new System.Drawing.Point(473, 19);
            this.lblVoc.Name = "lblVoc";
            this.lblVoc.Size = new System.Drawing.Size(182, 32);
            this.lblVoc.TabIndex = 1;
            this.lblVoc.Text = "Vocabulaire";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(12, 575);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(131, 39);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1025, 575);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(142, 39);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(183, 80);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(813, 40);
            this.progBar.TabIndex = 3;
            // 
            // lblLecon
            // 
            this.lblLecon.AutoSize = true;
            this.lblLecon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecon.Location = new System.Drawing.Point(14, 36);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(81, 23);
            this.lblLecon.TabIndex = 4;
            this.lblLecon.Text = "Leçon : ";
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProg.Location = new System.Drawing.Point(1015, 36);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(42, 23);
            this.lblProg.TabIndex = 5;
            this.lblProg.Text = "N/A";
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // frmCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1179, 626);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.lblLecon);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.gbCours);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Name = "frmCours";
            this.Text = "Cours";
            this.Load += new System.EventHandler(this.frmCours_Load);
            this.gbCours.ResumeLayout(false);
            this.gbCours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbCours;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblVoc;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.ErrorProvider erp;
    }
}