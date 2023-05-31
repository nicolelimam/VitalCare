
namespace VitalCare
{
    partial class TMenuAdministrador
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
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.BtnCalendario = new System.Windows.Forms.Button();
            this.BtnPacientes = new System.Windows.Forms.Button();
            this.BtnProntuario = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelprincipal
            // 
            this.panelprincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelprincipal.AutoScroll = true;
            this.panelprincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelprincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelprincipal.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.panelprincipal.Location = new System.Drawing.Point(1, 46);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(940, 512);
            this.panelprincipal.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.panel4.Controls.Add(this.BtnUsuarios);
            this.panel4.Controls.Add(this.BtnSair);
            this.panel4.Controls.Add(this.logo);
            this.panel4.Controls.Add(this.BtnCalendario);
            this.panel4.Controls.Add(this.BtnPacientes);
            this.panel4.Controls.Add(this.BtnProntuario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MaximumSize = new System.Drawing.Size(1920, 45);
            this.panel4.MinimumSize = new System.Drawing.Size(948, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(948, 45);
            this.panel4.TabIndex = 5;
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.Color.White;
            this.BtnUsuarios.Location = new System.Drawing.Point(249, 1);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(136, 42);
            this.BtnUsuarios.TabIndex = 6;
            this.BtnUsuarios.Text = "USUÁRIOS";
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(809, 1);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(136, 42);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.botaoSair_Click);
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
            // 
            // BtnCalendario
            // 
            this.BtnCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnCalendario.FlatAppearance.BorderSize = 0;
            this.BtnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalendario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalendario.ForeColor = System.Drawing.Color.White;
            this.BtnCalendario.Location = new System.Drawing.Point(675, 1);
            this.BtnCalendario.Name = "BtnCalendario";
            this.BtnCalendario.Size = new System.Drawing.Size(136, 42);
            this.BtnCalendario.TabIndex = 4;
            this.BtnCalendario.Text = "CALENDÁRIO";
            this.BtnCalendario.UseVisualStyleBackColor = false;
            this.BtnCalendario.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnPacientes
            // 
            this.BtnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnPacientes.FlatAppearance.BorderSize = 0;
            this.BtnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPacientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPacientes.ForeColor = System.Drawing.Color.White;
            this.BtnPacientes.Location = new System.Drawing.Point(391, 1);
            this.BtnPacientes.Name = "BtnPacientes";
            this.BtnPacientes.Size = new System.Drawing.Size(136, 42);
            this.BtnPacientes.TabIndex = 2;
            this.BtnPacientes.Text = "PACIENTES";
            this.BtnPacientes.UseVisualStyleBackColor = false;
            // 
            // BtnProntuario
            // 
            this.BtnProntuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnProntuario.FlatAppearance.BorderSize = 0;
            this.BtnProntuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProntuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProntuario.ForeColor = System.Drawing.Color.White;
            this.BtnProntuario.Location = new System.Drawing.Point(533, 1);
            this.BtnProntuario.Name = "BtnProntuario";
            this.BtnProntuario.Size = new System.Drawing.Size(136, 42);
            this.BtnProntuario.TabIndex = 3;
            this.BtnProntuario.Text = "PRONTUÁRIO";
            this.BtnProntuario.UseVisualStyleBackColor = false;
            this.BtnProntuario.Click += new System.EventHandler(this.BtnProntuario_Click);
            // 
            // TMenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelprincipal);
            this.MaximizeBox = false;
            this.Name = "TMenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMenuAdministrador";
            this.Load += new System.EventHandler(this.TMenuAdministrador_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button BtnCalendario;
        private System.Windows.Forms.Button BtnPacientes;
        private System.Windows.Forms.Button BtnProntuario;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnUsuarios;
    }
}