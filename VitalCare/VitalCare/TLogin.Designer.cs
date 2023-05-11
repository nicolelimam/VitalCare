namespace VitalCare
{
    partial class TLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.textoLogin = new System.Windows.Forms.Label();
            this.textoEmail = new System.Windows.Forms.Label();
            this.textoSenha = new System.Windows.Forms.Label();
            this.botaoEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // campoEmail
            // 
            this.campoEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.Location = new System.Drawing.Point(599, 244);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(226, 27);
            this.campoEmail.TabIndex = 1;
            this.campoEmail.TextChanged += new System.EventHandler(this.CampoEmail_TextChanged);
            // 
            // campoSenha
            // 
            this.campoSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoSenha.Location = new System.Drawing.Point(599, 337);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(226, 27);
            this.campoSenha.TabIndex = 2;
            this.campoSenha.UseSystemPasswordChar = true;
            this.campoSenha.TextChanged += new System.EventHandler(this.CampoSenha_TextChanged);
            // 
            // textoLogin
            // 
            this.textoLogin.AutoSize = true;
            this.textoLogin.BackColor = System.Drawing.Color.Transparent;
            this.textoLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.textoLogin.Location = new System.Drawing.Point(595, 131);
            this.textoLogin.Name = "textoLogin";
            this.textoLogin.Size = new System.Drawing.Size(235, 25);
            this.textoLogin.TabIndex = 3;
            this.textoLogin.Text = "ENTRE EM SUA CONTA";
            this.textoLogin.Click += new System.EventHandler(this.TextoLogin_Click);
            // 
            // textoEmail
            // 
            this.textoEmail.AutoSize = true;
            this.textoEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.textoEmail.Location = new System.Drawing.Point(648, 208);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(131, 21);
            this.textoEmail.TabIndex = 4;
            this.textoEmail.Text = "Insira seu e-mail";
            this.textoEmail.Click += new System.EventHandler(this.TextoEmail_Click);
            // 
            // textoSenha
            // 
            this.textoSenha.AutoSize = true;
            this.textoSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.textoSenha.Location = new System.Drawing.Point(648, 299);
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.Size = new System.Drawing.Size(132, 21);
            this.textoSenha.TabIndex = 6;
            this.textoSenha.Text = "Insira sua senha";
            this.textoSenha.Click += new System.EventHandler(this.Label2_Click);
            // 
            // botaoEntrar
            // 
            this.botaoEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.botaoEntrar.FlatAppearance.BorderSize = 0;
            this.botaoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEntrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEntrar.Location = new System.Drawing.Point(623, 390);
            this.botaoEntrar.Name = "botaoEntrar";
            this.botaoEntrar.Size = new System.Drawing.Size(179, 48);
            this.botaoEntrar.TabIndex = 7;
            this.botaoEntrar.Text = "ENTRAR";
            this.botaoEntrar.UseVisualStyleBackColor = false;
            this.botaoEntrar.Click += new System.EventHandler(this.BotaoEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VitalCare.Properties.Resources.resource_tela_login_v1_1__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-87, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.botaoEntrar);
            this.Controls.Add(this.textoSenha);
            this.Controls.Add(this.textoEmail);
            this.Controls.Add(this.textoLogin);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "TLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.TLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Label textoLogin;
        private System.Windows.Forms.Label textoEmail;
        private System.Windows.Forms.Label textoSenha;
        private System.Windows.Forms.Button botaoEntrar;
    }
}

