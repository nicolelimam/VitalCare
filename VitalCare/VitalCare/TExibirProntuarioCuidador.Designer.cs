
namespace VitalCare
{
    partial class TExibirProntuarioCuidador
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
            this.NQuarto = new System.Windows.Forms.Label();
            this.LblNQuarto = new System.Windows.Forms.Label();
            this.ObsPaciente = new System.Windows.Forms.TextBox();
            this.MedicamentosPaciente = new System.Windows.Forms.Label();
            this.Comorbidades = new System.Windows.Forms.Label();
            this.Medico = new System.Windows.Forms.Label();
            this.IdadePaciente = new System.Windows.Forms.Label();
            this.NomePaciente = new System.Windows.Forms.Label();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.LblMedico = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.LblObservacoes = new System.Windows.Forms.Label();
            this.LblMedicamentos = new System.Windows.Forms.Label();
            this.LblComorbidades = new System.Windows.Forms.Label();
            this.LblIdade = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulopanel
            // 
            this.titulopanel.AutoSize = true;
            this.titulopanel.BackColor = System.Drawing.Color.Transparent;
            this.titulopanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulopanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.titulopanel.Location = new System.Drawing.Point(377, 12);
            this.titulopanel.Name = "titulopanel";
            this.titulopanel.Size = new System.Drawing.Size(167, 30);
            this.titulopanel.TabIndex = 21;
            this.titulopanel.Text = "PRONTUÁRIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NQuarto);
            this.panel1.Controls.Add(this.LblNQuarto);
            this.panel1.Controls.Add(this.ObsPaciente);
            this.panel1.Controls.Add(this.MedicamentosPaciente);
            this.panel1.Controls.Add(this.Comorbidades);
            this.panel1.Controls.Add(this.Medico);
            this.panel1.Controls.Add(this.IdadePaciente);
            this.panel1.Controls.Add(this.NomePaciente);
            this.panel1.Controls.Add(this.BtnAtualizar);
            this.panel1.Controls.Add(this.LblMedico);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.LblObservacoes);
            this.panel1.Controls.Add(this.LblMedicamentos);
            this.panel1.Controls.Add(this.LblComorbidades);
            this.panel1.Controls.Add(this.LblIdade);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(21, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 395);
            this.panel1.TabIndex = 22;
            // 
            // NQuarto
            // 
            this.NQuarto.AutoSize = true;
            this.NQuarto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NQuarto.ForeColor = System.Drawing.Color.Black;
            this.NQuarto.Location = new System.Drawing.Point(585, 84);
            this.NQuarto.Name = "NQuarto";
            this.NQuarto.Size = new System.Drawing.Size(28, 21);
            this.NQuarto.TabIndex = 26;
            this.NQuarto.Text = "00";
            // 
            // LblNQuarto
            // 
            this.LblNQuarto.AutoSize = true;
            this.LblNQuarto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblNQuarto.Location = new System.Drawing.Point(496, 84);
            this.LblNQuarto.Name = "LblNQuarto";
            this.LblNQuarto.Size = new System.Drawing.Size(93, 21);
            this.LblNQuarto.TabIndex = 25;
            this.LblNQuarto.Text = "Nº Quarto:";
            // 
            // ObsPaciente
            // 
            this.ObsPaciente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObsPaciente.Location = new System.Drawing.Point(41, 260);
            this.ObsPaciente.Multiline = true;
            this.ObsPaciente.Name = "ObsPaciente";
            this.ObsPaciente.ReadOnly = true;
            this.ObsPaciente.Size = new System.Drawing.Size(416, 105);
            this.ObsPaciente.TabIndex = 24;
            this.ObsPaciente.Text = "Observações sobre o paciente";
            // 
            // MedicamentosPaciente
            // 
            this.MedicamentosPaciente.AutoSize = true;
            this.MedicamentosPaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicamentosPaciente.ForeColor = System.Drawing.Color.Black;
            this.MedicamentosPaciente.Location = new System.Drawing.Point(37, 194);
            this.MedicamentosPaciente.Name = "MedicamentosPaciente";
            this.MedicamentosPaciente.Size = new System.Drawing.Size(229, 21);
            this.MedicamentosPaciente.TabIndex = 23;
            this.MedicamentosPaciente.Text = "Medicamentos do paciente";
            // 
            // Comorbidades
            // 
            this.Comorbidades.AutoSize = true;
            this.Comorbidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comorbidades.ForeColor = System.Drawing.Color.Black;
            this.Comorbidades.Location = new System.Drawing.Point(163, 125);
            this.Comorbidades.Name = "Comorbidades";
            this.Comorbidades.Size = new System.Drawing.Size(227, 21);
            this.Comorbidades.TabIndex = 22;
            this.Comorbidades.Text = "Comorbidades do paciente";
            // 
            // Medico
            // 
            this.Medico.AutoSize = true;
            this.Medico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medico.ForeColor = System.Drawing.Color.Black;
            this.Medico.Location = new System.Drawing.Point(108, 84);
            this.Medico.Name = "Medico";
            this.Medico.Size = new System.Drawing.Size(145, 21);
            this.Medico.TabIndex = 21;
            this.Medico.Text = "Nome do médico";
            // 
            // IdadePaciente
            // 
            this.IdadePaciente.AutoSize = true;
            this.IdadePaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdadePaciente.ForeColor = System.Drawing.Color.Black;
            this.IdadePaciente.Location = new System.Drawing.Point(553, 47);
            this.IdadePaciente.Name = "IdadePaciente";
            this.IdadePaciente.Size = new System.Drawing.Size(58, 21);
            this.IdadePaciente.TabIndex = 20;
            this.IdadePaciente.Text = "Idade";
            // 
            // NomePaciente
            // 
            this.NomePaciente.AutoSize = true;
            this.NomePaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomePaciente.ForeColor = System.Drawing.Color.Black;
            this.NomePaciente.Location = new System.Drawing.Point(98, 47);
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.Size = new System.Drawing.Size(158, 21);
            this.NomePaciente.TabIndex = 19;
            this.NomePaciente.Text = "Nome do paciente";
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(762, 74);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(99, 27);
            this.BtnAtualizar.TabIndex = 18;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // LblMedico
            // 
            this.LblMedico.AutoSize = true;
            this.LblMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblMedico.Location = new System.Drawing.Point(37, 84);
            this.LblMedico.Name = "LblMedico";
            this.LblMedico.Size = new System.Drawing.Size(73, 21);
            this.LblMedico.TabIndex = 17;
            this.LblMedico.Text = "Médico:";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(762, 41);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(99, 27);
            this.BtnEditar.TabIndex = 16;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // LblObservacoes
            // 
            this.LblObservacoes.AutoSize = true;
            this.LblObservacoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblObservacoes.Location = new System.Drawing.Point(37, 227);
            this.LblObservacoes.Name = "LblObservacoes";
            this.LblObservacoes.Size = new System.Drawing.Size(117, 21);
            this.LblObservacoes.TabIndex = 4;
            this.LblObservacoes.Text = "Observações:";
            // 
            // LblMedicamentos
            // 
            this.LblMedicamentos.AutoSize = true;
            this.LblMedicamentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedicamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblMedicamentos.Location = new System.Drawing.Point(37, 163);
            this.LblMedicamentos.Name = "LblMedicamentos";
            this.LblMedicamentos.Size = new System.Drawing.Size(132, 21);
            this.LblMedicamentos.TabIndex = 3;
            this.LblMedicamentos.Text = "Medicamentos:";
            // 
            // LblComorbidades
            // 
            this.LblComorbidades.AutoSize = true;
            this.LblComorbidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComorbidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblComorbidades.Location = new System.Drawing.Point(37, 125);
            this.LblComorbidades.Name = "LblComorbidades";
            this.LblComorbidades.Size = new System.Drawing.Size(130, 21);
            this.LblComorbidades.TabIndex = 2;
            this.LblComorbidades.Text = "Comorbidades:";
            // 
            // LblIdade
            // 
            this.LblIdade.AutoSize = true;
            this.LblIdade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblIdade.Location = new System.Drawing.Point(496, 47);
            this.LblIdade.Name = "LblIdade";
            this.LblIdade.Size = new System.Drawing.Size(62, 21);
            this.LblIdade.TabIndex = 1;
            this.LblIdade.Text = "Idade:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblNome.Location = new System.Drawing.Point(37, 47);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(61, 21);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome:";
            // 
            // TExibirProntuarioCuidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(924, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titulopanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TExibirProntuarioCuidador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "]";
            this.Load += new System.EventHandler(this.TExibirProntuarioCuidador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulopanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ObsPaciente;
        private System.Windows.Forms.Label MedicamentosPaciente;
        private System.Windows.Forms.Label Comorbidades;
        private System.Windows.Forms.Label Medico;
        private System.Windows.Forms.Label IdadePaciente;
        private System.Windows.Forms.Label NomePaciente;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Label LblMedico;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label LblObservacoes;
        private System.Windows.Forms.Label LblMedicamentos;
        private System.Windows.Forms.Label LblComorbidades;
        private System.Windows.Forms.Label LblIdade;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label NQuarto;
        private System.Windows.Forms.Label LblNQuarto;
    }
}