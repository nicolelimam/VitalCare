namespace VitalCare
{
    partial class TMenuCuidador
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
            this.fundoMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.botaoVoitar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fundoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // fundoMenu
            // 
            this.fundoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.fundoMenu.Controls.Add(this.panel1);
            this.fundoMenu.Controls.Add(this.logo);
            this.fundoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.fundoMenu.Location = new System.Drawing.Point(0, 0);
            this.fundoMenu.Name = "fundoMenu";
            this.fundoMenu.Size = new System.Drawing.Size(944, 45);
            this.fundoMenu.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Image = global::VitalCare.Properties.Resources.Rectangle_11;
            this.logo.Location = new System.Drawing.Point(19, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(169, 42);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // botaoVoitar
            // 
            this.botaoVoitar.Location = new System.Drawing.Point(827, 519);
            this.botaoVoitar.Name = "botaoVoitar";
            this.botaoVoitar.Size = new System.Drawing.Size(105, 30);
            this.botaoVoitar.TabIndex = 1;
            this.botaoVoitar.Text = "Voltar";
            this.botaoVoitar.UseVisualStyleBackColor = true;
            this.botaoVoitar.Click += new System.EventHandler(this.BotaoVoitar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 42);
            this.panel1.TabIndex = 2;
            // 
            // TMenuCuidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.botaoVoitar);
            this.Controls.Add(this.fundoMenu);
            this.Name = "TMenuCuidador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMenuCuidador";
            this.Load += new System.EventHandler(this.TMenuCuidador_Load);
            this.fundoMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fundoMenu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button botaoVoitar;
        private System.Windows.Forms.Panel panel1;
    }
}