
namespace VitalCare
{
    partial class TCadastroUsuarioADM
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
            this.titulopanel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CampoSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.BoxCargo = new System.Windows.Forms.ComboBox();
            this.LblCargo = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.campoNomeUsu = new System.Windows.Forms.TextBox();
            this.LblNomeUsuario = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulopanel
            // 
            this.titulopanel.AutoSize = true;
            this.titulopanel.BackColor = System.Drawing.Color.Transparent;
            this.titulopanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulopanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.titulopanel.Location = new System.Drawing.Point(381, 91);
            this.titulopanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulopanel.Name = "titulopanel";
            this.titulopanel.Size = new System.Drawing.Size(429, 37);
            this.titulopanel.TabIndex = 21;
            this.titulopanel.Text = "CADASTRAR NOVO USUÁRIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.campoEmail);
            this.panel1.Controls.Add(this.CampoSenha);
            this.panel1.Controls.Add(this.LblSenha);
            this.panel1.Controls.Add(this.BoxCargo);
            this.panel1.Controls.Add(this.LblCargo);
            this.panel1.Controls.Add(this.LblEmail);
            this.panel1.Controls.Add(this.campoNome);
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Controls.Add(this.campoNomeUsu);
            this.panel1.Controls.Add(this.LblNomeUsuario);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(171, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 360);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CampoSenha
            // 
            this.CampoSenha.Location = new System.Drawing.Point(179, 242);
            this.CampoSenha.Name = "CampoSenha";
            this.CampoSenha.Size = new System.Drawing.Size(274, 22);
            this.CampoSenha.TabIndex = 26;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblSenha.Location = new System.Drawing.Point(37, 239);
            this.LblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(135, 23);
            this.LblSenha.TabIndex = 25;
            this.LblSenha.Text = "Senha inicial:";
            // 
            // BoxCargo
            // 
            this.BoxCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxCargo.FormattingEnabled = true;
            this.BoxCargo.Items.AddRange(new object[] {
            "Administrador",
            "Cuidador"});
            this.BoxCargo.Location = new System.Drawing.Point(124, 149);
            this.BoxCargo.Margin = new System.Windows.Forms.Padding(4);
            this.BoxCargo.Name = "BoxCargo";
            this.BoxCargo.Size = new System.Drawing.Size(241, 29);
            this.BoxCargo.TabIndex = 24;
            this.BoxCargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblCargo.Location = new System.Drawing.Point(37, 150);
            this.LblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(77, 23);
            this.LblCargo.TabIndex = 23;
            this.LblCargo.Text = "Cargo:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblEmail.Location = new System.Drawing.Point(37, 110);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(74, 23);
            this.LblEmail.TabIndex = 21;
            this.LblEmail.Text = "E-mail:";
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(127, 69);
            this.campoNome.Margin = new System.Windows.Forms.Padding(4);
            this.campoNome.Multiline = true;
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(353, 25);
            this.campoNome.TabIndex = 20;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(725, 290);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(132, 33);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // campoNomeUsu
            // 
            this.campoNomeUsu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNomeUsu.Location = new System.Drawing.Point(240, 197);
            this.campoNomeUsu.Margin = new System.Windows.Forms.Padding(4);
            this.campoNomeUsu.Multiline = true;
            this.campoNomeUsu.Name = "campoNomeUsu";
            this.campoNomeUsu.Size = new System.Drawing.Size(213, 25);
            this.campoNomeUsu.TabIndex = 6;
            // 
            // LblNomeUsuario
            // 
            this.LblNomeUsuario.AutoSize = true;
            this.LblNomeUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblNomeUsuario.Location = new System.Drawing.Point(37, 196);
            this.LblNomeUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNomeUsuario.Name = "LblNomeUsuario";
            this.LblNomeUsuario.Size = new System.Drawing.Size(183, 23);
            this.LblNomeUsuario.TabIndex = 1;
            this.LblNomeUsuario.Text = "Nome de Usuário:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblNome.Location = new System.Drawing.Point(37, 68);
            this.LblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(75, 23);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome:";
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(124, 113);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(356, 22);
            this.campoEmail.TabIndex = 27;
            // 
            // TCadastroUsuarioADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(1253, 630);
            this.Controls.Add(this.titulopanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TCadastroUsuarioADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCadastroUsuarioADM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulopanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox BoxCargo;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox campoNomeUsu;
        private System.Windows.Forms.Label LblNomeUsuario;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox CampoSenha;
        private System.Windows.Forms.TextBox campoEmail;
    }
}