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
            this.logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.botaoLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelprincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::VitalCare.Properties.Resources.Rectangle_11;
            this.logo.Location = new System.Drawing.Point(19, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(169, 42);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(232, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "PRONTUÁRIOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(374, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "CALENDÁRIO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(516, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "PACIENTES";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(658, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "ANOTAÇÕES";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.logo);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MaximumSize = new System.Drawing.Size(1920, 45);
            this.panel4.MinimumSize = new System.Drawing.Size(948, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(948, 45);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panelprincipal
            // 
            this.panelprincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelprincipal.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.panelprincipal.Controls.Add(this.botaoLogout);
            this.panelprincipal.Location = new System.Drawing.Point(0, 42);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(948, 527);
            this.panelprincipal.TabIndex = 3;
            // 
            // botaoLogout
            // 
            this.botaoLogout.Location = new System.Drawing.Point(811, 475);
            this.botaoLogout.Name = "botaoLogout";
            this.botaoLogout.Size = new System.Drawing.Size(117, 28);
            this.botaoLogout.TabIndex = 0;
            this.botaoLogout.Text = "Logout";
            this.botaoLogout.UseVisualStyleBackColor = true;
            this.botaoLogout.Click += new System.EventHandler(this.botaoLogout_Click);
            // 
            // TMenuCuidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(940, 557);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 600);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "TMenuCuidador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMenuCuidador";
            this.Load += new System.EventHandler(this.TMenuCuidador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panelprincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.Button botaoLogout;
    }
}