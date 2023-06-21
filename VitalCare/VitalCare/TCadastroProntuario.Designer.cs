
namespace VitalCare
{
    partial class TCadastroProntuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoxEmail = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CampoMedico = new System.Windows.Forms.TextBox();
            this.LblMedico = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.campoMedicamentos = new System.Windows.Forms.ComboBox();
            this.campoComorbidades = new System.Windows.Forms.ComboBox();
            this.campoObservacao = new System.Windows.Forms.TextBox();
            this.campoIdade = new System.Windows.Forms.TextBox();
            this.campoNome = new System.Windows.Forms.ComboBox();
            this.LblObservacoes = new System.Windows.Forms.Label();
            this.LblMedicamentos = new System.Windows.Forms.Label();
            this.LblComorbidades = new System.Windows.Forms.Label();
            this.LblIdade = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.titulopanel = new System.Windows.Forms.Label();
            this.TextQuarto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextQuarto);
            this.panel1.Controls.Add(this.BoxEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CampoMedico);
            this.panel1.Controls.Add(this.LblMedico);
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Controls.Add(this.campoMedicamentos);
            this.panel1.Controls.Add(this.campoComorbidades);
            this.panel1.Controls.Add(this.campoObservacao);
            this.panel1.Controls.Add(this.campoIdade);
            this.panel1.Controls.Add(this.campoNome);
            this.panel1.Controls.Add(this.LblObservacoes);
            this.panel1.Controls.Add(this.LblMedicamentos);
            this.panel1.Controls.Add(this.LblComorbidades);
            this.panel1.Controls.Add(this.LblIdade);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(241, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 502);
            this.panel1.TabIndex = 0;
            // 
            // BoxEmail
            // 
            this.BoxEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmail.FormattingEnabled = true;
            this.BoxEmail.Location = new System.Drawing.Point(231, 274);
            this.BoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(429, 29);
            this.BoxEmail.TabIndex = 22;
            this.BoxEmail.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(49, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email Cuidador:";
            // 
            // CampoMedico
            // 
            this.CampoMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CampoMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoMedico.Location = new System.Drawing.Point(155, 110);
            this.CampoMedico.Margin = new System.Windows.Forms.Padding(4);
            this.CampoMedico.Multiline = true;
            this.CampoMedico.Name = "CampoMedico";
            this.CampoMedico.Size = new System.Drawing.Size(251, 25);
            this.CampoMedico.TabIndex = 18;
            // 
            // LblMedico
            // 
            this.LblMedico.AutoSize = true;
            this.LblMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblMedico.Location = new System.Drawing.Point(51, 108);
            this.LblMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMedico.Name = "LblMedico";
            this.LblMedico.Size = new System.Drawing.Size(88, 23);
            this.LblMedico.TabIndex = 17;
            this.LblMedico.Text = "Médico:";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(587, 457);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(132, 33);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // campoMedicamentos
            // 
            this.campoMedicamentos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoMedicamentos.FormattingEnabled = true;
            this.campoMedicamentos.Location = new System.Drawing.Point(231, 224);
            this.campoMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.campoMedicamentos.Name = "campoMedicamentos";
            this.campoMedicamentos.Size = new System.Drawing.Size(429, 29);
            this.campoMedicamentos.TabIndex = 15;
            // 
            // campoComorbidades
            // 
            this.campoComorbidades.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoComorbidades.FormattingEnabled = true;
            this.campoComorbidades.Items.AddRange(new object[] {
            "Diabete",
            "Hipertensão"});
            this.campoComorbidades.Location = new System.Drawing.Point(231, 167);
            this.campoComorbidades.Margin = new System.Windows.Forms.Padding(4);
            this.campoComorbidades.Name = "campoComorbidades";
            this.campoComorbidades.Size = new System.Drawing.Size(429, 29);
            this.campoComorbidades.TabIndex = 14;
            this.campoComorbidades.SelectedIndexChanged += new System.EventHandler(this.campoComorbidades_SelectedIndexChanged);
            // 
            // campoObservacao
            // 
            this.campoObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoObservacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoObservacao.Location = new System.Drawing.Point(231, 331);
            this.campoObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.campoObservacao.Multiline = true;
            this.campoObservacao.Name = "campoObservacao";
            this.campoObservacao.Size = new System.Drawing.Size(430, 109);
            this.campoObservacao.TabIndex = 13;
            // 
            // campoIdade
            // 
            this.campoIdade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoIdade.Location = new System.Drawing.Point(532, 58);
            this.campoIdade.Margin = new System.Windows.Forms.Padding(4);
            this.campoIdade.Multiline = true;
            this.campoIdade.Name = "campoIdade";
            this.campoIdade.Size = new System.Drawing.Size(128, 25);
            this.campoIdade.TabIndex = 6;
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.FormattingEnabled = true;
            this.campoNome.Location = new System.Drawing.Point(139, 53);
            this.campoNome.Margin = new System.Windows.Forms.Padding(4);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(267, 29);
            this.campoNome.TabIndex = 5;
            this.campoNome.SelectedIndexChanged += new System.EventHandler(this.campoNome_SelectedIndexChanged);
            // 
            // LblObservacoes
            // 
            this.LblObservacoes.AutoSize = true;
            this.LblObservacoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblObservacoes.Location = new System.Drawing.Point(51, 329);
            this.LblObservacoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblObservacoes.Name = "LblObservacoes";
            this.LblObservacoes.Size = new System.Drawing.Size(147, 23);
            this.LblObservacoes.TabIndex = 4;
            this.LblObservacoes.Text = "Observações:";
            // 
            // LblMedicamentos
            // 
            this.LblMedicamentos.AutoSize = true;
            this.LblMedicamentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedicamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblMedicamentos.Location = new System.Drawing.Point(48, 224);
            this.LblMedicamentos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMedicamentos.Name = "LblMedicamentos";
            this.LblMedicamentos.Size = new System.Drawing.Size(161, 23);
            this.LblMedicamentos.TabIndex = 3;
            this.LblMedicamentos.Text = "Medicamentos:";
            // 
            // LblComorbidades
            // 
            this.LblComorbidades.AutoSize = true;
            this.LblComorbidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComorbidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblComorbidades.Location = new System.Drawing.Point(47, 167);
            this.LblComorbidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblComorbidades.Name = "LblComorbidades";
            this.LblComorbidades.Size = new System.Drawing.Size(162, 23);
            this.LblComorbidades.TabIndex = 2;
            this.LblComorbidades.Text = "Comorbidades:";
            // 
            // LblIdade
            // 
            this.LblIdade.AutoSize = true;
            this.LblIdade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblIdade.Location = new System.Drawing.Point(441, 58);
            this.LblIdade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdade.Name = "LblIdade";
            this.LblIdade.Size = new System.Drawing.Size(75, 23);
            this.LblIdade.TabIndex = 1;
            this.LblIdade.Text = "Idade:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblNome.Location = new System.Drawing.Point(49, 58);
            this.LblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(75, 23);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome:";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.Location = new System.Drawing.Point(1097, 569);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(117, 33);
            this.BtnVoltar.TabIndex = 17;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            // 
            // titulopanel
            // 
            this.titulopanel.AutoSize = true;
            this.titulopanel.BackColor = System.Drawing.Color.Transparent;
            this.titulopanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulopanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.titulopanel.Location = new System.Drawing.Point(360, 28);
            this.titulopanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulopanel.Name = "titulopanel";
            this.titulopanel.Size = new System.Drawing.Size(491, 37);
            this.titulopanel.TabIndex = 20;
            this.titulopanel.Text = "CADASTRAR NOVO PRONTUÁRIO";
            // 
            // TextQuarto
            // 
            this.TextQuarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextQuarto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextQuarto.Location = new System.Drawing.Point(532, 104);
            this.TextQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.TextQuarto.Multiline = true;
            this.TextQuarto.Name = "TextQuarto";
            this.TextQuarto.Size = new System.Drawing.Size(116, 27);
            this.TextQuarto.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(441, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quarto";
            // 
            // TCadastroProntuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(1253, 630);
            this.Controls.Add(this.titulopanel);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TCadastroProntuario";
            this.Text = "TCadastroProntuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.ComboBox campoMedicamentos;
        private System.Windows.Forms.ComboBox campoComorbidades;
        private System.Windows.Forms.TextBox campoObservacao;
        private System.Windows.Forms.TextBox campoIdade;
        private System.Windows.Forms.ComboBox campoNome;
        private System.Windows.Forms.Label LblObservacoes;
        private System.Windows.Forms.Label LblMedicamentos;
        private System.Windows.Forms.Label LblComorbidades;
        private System.Windows.Forms.Label LblIdade;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label titulopanel;
        private System.Windows.Forms.TextBox CampoMedico;
        private System.Windows.Forms.Label LblMedico;
        private System.Windows.Forms.ComboBox BoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextQuarto;
    }
}