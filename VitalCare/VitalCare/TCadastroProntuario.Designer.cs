
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.ComboBoxMedicamento = new System.Windows.Forms.ComboBox();
            this.ComboBoxComorbidades = new System.Windows.Forms.ComboBox();
            this.TxtBoxObservacoes = new System.Windows.Forms.TextBox();
            this.TxtBoxIdade = new System.Windows.Forms.TextBox();
            this.ComboBoxNome = new System.Windows.Forms.ComboBox();
            this.LblObservacoes = new System.Windows.Forms.Label();
            this.LblMedicamentos = new System.Windows.Forms.Label();
            this.LblComorbidades = new System.Windows.Forms.Label();
            this.LblIdade = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Controls.Add(this.ComboBoxMedicamento);
            this.panel1.Controls.Add(this.ComboBoxComorbidades);
            this.panel1.Controls.Add(this.TxtBoxObservacoes);
            this.panel1.Controls.Add(this.TxtBoxIdade);
            this.panel1.Controls.Add(this.ComboBoxNome);
            this.panel1.Controls.Add(this.LblObservacoes);
            this.panel1.Controls.Add(this.LblMedicamentos);
            this.panel1.Controls.Add(this.LblComorbidades);
            this.panel1.Controls.Add(this.LblIdade);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(85, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 384);
            this.panel1.TabIndex = 0;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(610, 342);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(119, 27);
            this.BtnSalvar.TabIndex = 16;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // ComboBoxMedicamento
            // 
            this.ComboBoxMedicamento.FormattingEnabled = true;
            this.ComboBoxMedicamento.Location = new System.Drawing.Point(281, 161);
            this.ComboBoxMedicamento.Name = "ComboBoxMedicamento";
            this.ComboBoxMedicamento.Size = new System.Drawing.Size(323, 21);
            this.ComboBoxMedicamento.TabIndex = 15;
            // 
            // ComboBoxComorbidades
            // 
            this.ComboBoxComorbidades.FormattingEnabled = true;
            this.ComboBoxComorbidades.Items.AddRange(new object[] {
            "Diabete",
            "Hipertensão"});
            this.ComboBoxComorbidades.Location = new System.Drawing.Point(281, 115);
            this.ComboBoxComorbidades.Name = "ComboBoxComorbidades";
            this.ComboBoxComorbidades.Size = new System.Drawing.Size(323, 21);
            this.ComboBoxComorbidades.TabIndex = 14;
            // 
            // TxtBoxObservacoes
            // 
            this.TxtBoxObservacoes.Location = new System.Drawing.Point(281, 213);
            this.TxtBoxObservacoes.Multiline = true;
            this.TxtBoxObservacoes.Name = "TxtBoxObservacoes";
            this.TxtBoxObservacoes.Size = new System.Drawing.Size(323, 113);
            this.TxtBoxObservacoes.TabIndex = 13;
            // 
            // TxtBoxIdade
            // 
            this.TxtBoxIdade.Location = new System.Drawing.Point(507, 63);
            this.TxtBoxIdade.Multiline = true;
            this.TxtBoxIdade.Name = "TxtBoxIdade";
            this.TxtBoxIdade.Size = new System.Drawing.Size(97, 21);
            this.TxtBoxIdade.TabIndex = 6;
            // 
            // ComboBoxNome
            // 
            this.ComboBoxNome.FormattingEnabled = true;
            this.ComboBoxNome.Location = new System.Drawing.Point(212, 63);
            this.ComboBoxNome.Name = "ComboBoxNome";
            this.ComboBoxNome.Size = new System.Drawing.Size(201, 21);
            this.ComboBoxNome.TabIndex = 5;
            // 
            // LblObservacoes
            // 
            this.LblObservacoes.AutoSize = true;
            this.LblObservacoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservacoes.Location = new System.Drawing.Point(147, 213);
            this.LblObservacoes.Name = "LblObservacoes";
            this.LblObservacoes.Size = new System.Drawing.Size(117, 21);
            this.LblObservacoes.TabIndex = 4;
            this.LblObservacoes.Text = "Observações:";
            // 
            // LblMedicamentos
            // 
            this.LblMedicamentos.AutoSize = true;
            this.LblMedicamentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedicamentos.Location = new System.Drawing.Point(145, 161);
            this.LblMedicamentos.Name = "LblMedicamentos";
            this.LblMedicamentos.Size = new System.Drawing.Size(132, 21);
            this.LblMedicamentos.TabIndex = 3;
            this.LblMedicamentos.Text = "Medicamentos:";
            // 
            // LblComorbidades
            // 
            this.LblComorbidades.AutoSize = true;
            this.LblComorbidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComorbidades.Location = new System.Drawing.Point(147, 115);
            this.LblComorbidades.Name = "LblComorbidades";
            this.LblComorbidades.Size = new System.Drawing.Size(130, 21);
            this.LblComorbidades.TabIndex = 2;
            this.LblComorbidades.Text = "Comorbidades:";
            // 
            // LblIdade
            // 
            this.LblIdade.AutoSize = true;
            this.LblIdade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdade.Location = new System.Drawing.Point(439, 63);
            this.LblIdade.Name = "LblIdade";
            this.LblIdade.Size = new System.Drawing.Size(62, 21);
            this.LblIdade.TabIndex = 1;
            this.LblIdade.Text = "Idade:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(145, 60);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(61, 21);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome:";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(695, 451);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(119, 27);
            this.BtnVoltar.TabIndex = 17;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // TCadastroProntuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(940, 512);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TCadastroProntuario";
            this.Text = "TCadastroProntuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.ComboBox ComboBoxMedicamento;
        private System.Windows.Forms.ComboBox ComboBoxComorbidades;
        private System.Windows.Forms.TextBox TxtBoxObservacoes;
        private System.Windows.Forms.TextBox TxtBoxIdade;
        private System.Windows.Forms.ComboBox ComboBoxNome;
        private System.Windows.Forms.Label LblObservacoes;
        private System.Windows.Forms.Label LblMedicamentos;
        private System.Windows.Forms.Label LblComorbidades;
        private System.Windows.Forms.Label LblIdade;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnVoltar;
    }
}