
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
            this.LblCargo = new System.Windows.Forms.Label();
            this.TxtBoxRg = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.campoNasc = new System.Windows.Forms.TextBox();
            this.LblNomeUsuario = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.SenhaInicial = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulopanel
            // 
            this.titulopanel.AutoSize = true;
            this.titulopanel.BackColor = System.Drawing.Color.Transparent;
            this.titulopanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulopanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.titulopanel.Location = new System.Drawing.Point(286, 74);
            this.titulopanel.Name = "titulopanel";
            this.titulopanel.Size = new System.Drawing.Size(349, 30);
            this.titulopanel.TabIndex = 21;
            this.titulopanel.Text = "CADASTRAR NOVO USUÁRIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SenhaInicial);
            this.panel1.Controls.Add(this.LblSenha);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.LblCargo);
            this.panel1.Controls.Add(this.TxtBoxRg);
            this.panel1.Controls.Add(this.LblEmail);
            this.panel1.Controls.Add(this.campoNome);
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Controls.Add(this.campoNasc);
            this.panel1.Controls.Add(this.LblNomeUsuario);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(128, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 293);
            this.panel1.TabIndex = 20;
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblCargo.Location = new System.Drawing.Point(28, 122);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(64, 21);
            this.LblCargo.TabIndex = 23;
            this.LblCargo.Text = "Cargo:";
            // 
            // TxtBoxRg
            // 
            this.TxtBoxRg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxRg.Location = new System.Drawing.Point(93, 90);
            this.TxtBoxRg.Multiline = true;
            this.TxtBoxRg.Name = "TxtBoxRg";
            this.TxtBoxRg.Size = new System.Drawing.Size(338, 21);
            this.TxtBoxRg.TabIndex = 22;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblEmail.Location = new System.Drawing.Point(28, 89);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(60, 21);
            this.LblEmail.TabIndex = 21;
            this.LblEmail.Text = "E-mail:";
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(95, 56);
            this.campoNome.Multiline = true;
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(266, 21);
            this.campoNome.TabIndex = 20;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(544, 236);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(99, 27);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            // 
            // campoNasc
            // 
            this.campoNasc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNasc.Location = new System.Drawing.Point(180, 160);
            this.campoNasc.Multiline = true;
            this.campoNasc.Name = "campoNasc";
            this.campoNasc.Size = new System.Drawing.Size(161, 21);
            this.campoNasc.TabIndex = 6;
            // 
            // LblNomeUsuario
            // 
            this.LblNomeUsuario.AutoSize = true;
            this.LblNomeUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblNomeUsuario.Location = new System.Drawing.Point(28, 159);
            this.LblNomeUsuario.Name = "LblNomeUsuario";
            this.LblNomeUsuario.Size = new System.Drawing.Size(146, 21);
            this.LblNomeUsuario.TabIndex = 1;
            this.LblNomeUsuario.Text = "Nome de Usuário:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblNome.Location = new System.Drawing.Point(28, 55);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(61, 21);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Cuidador"});
            this.comboBox1.Location = new System.Drawing.Point(93, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 25);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblSenha.Location = new System.Drawing.Point(28, 194);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(110, 21);
            this.LblSenha.TabIndex = 25;
            this.LblSenha.Text = "Senha inicial:";
            // 
            // SenhaInicial
            // 
            this.SenhaInicial.AutoSize = true;
            this.SenhaInicial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaInicial.Location = new System.Drawing.Point(144, 194);
            this.SenhaInicial.Name = "SenhaInicial";
            this.SenhaInicial.Size = new System.Drawing.Size(106, 21);
            this.SenhaInicial.TabIndex = 26;
            this.SenhaInicial.Text = "Senha inicial";
            // 
            // TCadastroUsuarioADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(940, 512);
            this.Controls.Add(this.titulopanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.TextBox TxtBoxRg;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox campoNasc;
        private System.Windows.Forms.Label LblNomeUsuario;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label SenhaInicial;
        private System.Windows.Forms.Label LblSenha;
    }
}