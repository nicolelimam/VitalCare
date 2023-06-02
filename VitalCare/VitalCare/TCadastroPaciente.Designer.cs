
namespace VitalCare
{
    partial class TCadastroPaciente
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
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoQuarto = new System.Windows.Forms.ComboBox();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.campoResponsavel = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.campoNasc = new System.Windows.Forms.TextBox();
            this.LblNQuarto = new System.Windows.Forms.Label();
            this.LblTelResponsavel = new System.Windows.Forms.Label();
            this.LblNomeResponsavel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.titulopanel = new System.Windows.Forms.Label();
            this.LblRg = new System.Windows.Forms.Label();
            this.TxtBoxRg = new System.Windows.Forms.TextBox();
            this.LblCpf = new System.Windows.Forms.Label();
            this.TxtBoxCpf = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtBoxCpf);
            this.panel1.Controls.Add(this.LblCpf);
            this.panel1.Controls.Add(this.TxtBoxRg);
            this.panel1.Controls.Add(this.LblRg);
            this.panel1.Controls.Add(this.campoNome);
            this.panel1.Controls.Add(this.campoQuarto);
            this.panel1.Controls.Add(this.campoTelefone);
            this.panel1.Controls.Add(this.campoResponsavel);
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Controls.Add(this.campoNasc);
            this.panel1.Controls.Add(this.LblNQuarto);
            this.panel1.Controls.Add(this.LblTelResponsavel);
            this.panel1.Controls.Add(this.LblNomeResponsavel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(128, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 293);
            this.panel1.TabIndex = 1;
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(136, 61);
            this.campoNome.Multiline = true;
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(215, 21);
            this.campoNome.TabIndex = 20;
            // 
            // campoQuarto
            // 
            this.campoQuarto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoQuarto.FormattingEnabled = true;
            this.campoQuarto.Location = new System.Drawing.Point(574, 181);
            this.campoQuarto.Name = "campoQuarto";
            this.campoQuarto.Size = new System.Drawing.Size(69, 25);
            this.campoQuarto.TabIndex = 19;
            // 
            // campoTelefone
            // 
            this.campoTelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTelefone.Location = new System.Drawing.Point(266, 180);
            this.campoTelefone.Multiline = true;
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(168, 21);
            this.campoTelefone.TabIndex = 18;
            // 
            // campoResponsavel
            // 
            this.campoResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoResponsavel.Location = new System.Drawing.Point(257, 141);
            this.campoResponsavel.Multiline = true;
            this.campoResponsavel.Name = "campoResponsavel";
            this.campoResponsavel.Size = new System.Drawing.Size(386, 21);
            this.campoResponsavel.TabIndex = 17;
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
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // campoNasc
            // 
            this.campoNasc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNasc.Location = new System.Drawing.Point(474, 61);
            this.campoNasc.Multiline = true;
            this.campoNasc.Name = "campoNasc";
            this.campoNasc.Size = new System.Drawing.Size(169, 21);
            this.campoNasc.TabIndex = 6;
            // 
            // LblNQuarto
            // 
            this.LblNQuarto.AutoSize = true;
            this.LblNQuarto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNQuarto.Location = new System.Drawing.Point(450, 180);
            this.LblNQuarto.Name = "LblNQuarto";
            this.LblNQuarto.Size = new System.Drawing.Size(118, 21);
            this.LblNQuarto.TabIndex = 4;
            this.LblNQuarto.Text = "Nº do Quarto:";
            // 
            // LblTelResponsavel
            // 
            this.LblTelResponsavel.AutoSize = true;
            this.LblTelResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelResponsavel.Location = new System.Drawing.Point(69, 179);
            this.LblTelResponsavel.Name = "LblTelResponsavel";
            this.LblTelResponsavel.Size = new System.Drawing.Size(191, 21);
            this.LblTelResponsavel.TabIndex = 3;
            this.LblTelResponsavel.Text = "Telefone do resposável:";
            // 
            // LblNomeResponsavel
            // 
            this.LblNomeResponsavel.AutoSize = true;
            this.LblNomeResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeResponsavel.Location = new System.Drawing.Point(69, 140);
            this.LblNomeResponsavel.Name = "LblNomeResponsavel";
            this.LblNomeResponsavel.Size = new System.Drawing.Size(182, 21);
            this.LblNomeResponsavel.TabIndex = 2;
            this.LblNomeResponsavel.Text = "Nome do responsável:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nascimento:";
            this.label1.Click += new System.EventHandler(this.LblIdade_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(69, 61);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(61, 21);
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
            this.BtnVoltar.Location = new System.Drawing.Point(830, 473);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(88, 27);
            this.BtnVoltar.TabIndex = 18;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            // 
            // titulopanel
            // 
            this.titulopanel.AutoSize = true;
            this.titulopanel.BackColor = System.Drawing.Color.Transparent;
            this.titulopanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulopanel.Location = new System.Drawing.Point(283, 38);
            this.titulopanel.Name = "titulopanel";
            this.titulopanel.Size = new System.Drawing.Size(358, 30);
            this.titulopanel.TabIndex = 19;
            this.titulopanel.Text = "CADASTRAR NOVO PACIENTE";
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRg.Location = new System.Drawing.Point(69, 99);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(38, 21);
            this.LblRg.TabIndex = 21;
            this.LblRg.Text = "RG:";
            this.LblRg.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtBoxRg
            // 
            this.TxtBoxRg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxRg.Location = new System.Drawing.Point(113, 100);
            this.TxtBoxRg.Multiline = true;
            this.TxtBoxRg.Name = "TxtBoxRg";
            this.TxtBoxRg.Size = new System.Drawing.Size(233, 21);
            this.TxtBoxRg.TabIndex = 22;
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.Location = new System.Drawing.Point(360, 100);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(44, 21);
            this.LblCpf.TabIndex = 23;
            this.LblCpf.Text = "CPF:";
            // 
            // TxtBoxCpf
            // 
            this.TxtBoxCpf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxCpf.Location = new System.Drawing.Point(410, 101);
            this.TxtBoxCpf.Multiline = true;
            this.TxtBoxCpf.Name = "TxtBoxCpf";
            this.TxtBoxCpf.Size = new System.Drawing.Size(233, 21);
            this.TxtBoxCpf.TabIndex = 24;
            // 
            // TCadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(940, 512);
            this.Controls.Add(this.titulopanel);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TCadastroPaciente";
            this.Text = "TCadastroPaciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox campoNasc;
        private System.Windows.Forms.Label LblNQuarto;
        private System.Windows.Forms.Label LblTelResponsavel;
        private System.Windows.Forms.Label LblNomeResponsavel;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.ComboBox campoQuarto;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.TextBox campoResponsavel;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulopanel;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.TextBox TxtBoxCpf;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.TextBox TxtBoxRg;
    }
}