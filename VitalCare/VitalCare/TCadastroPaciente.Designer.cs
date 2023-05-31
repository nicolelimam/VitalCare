
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtBoxNasc = new System.Windows.Forms.TextBox();
            this.LblNQuarto = new System.Windows.Forms.Label();
            this.LblTelResponsavel = new System.Windows.Forms.Label();
            this.LblNomeResponsavel = new System.Windows.Forms.Label();
            this.LblDataNasc = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtBoxNomeResponsavel = new System.Windows.Forms.TextBox();
            this.TxtBoxTelResponsavel = new System.Windows.Forms.TextBox();
            this.ComboBoxNQuarto = new System.Windows.Forms.ComboBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.TxtBoxNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.TxtBoxNome);
            this.panel1.Controls.Add(this.ComboBoxNQuarto);
            this.panel1.Controls.Add(this.TxtBoxTelResponsavel);
            this.panel1.Controls.Add(this.TxtBoxNomeResponsavel);
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Controls.Add(this.TxtBoxNasc);
            this.panel1.Controls.Add(this.LblNQuarto);
            this.panel1.Controls.Add(this.LblTelResponsavel);
            this.panel1.Controls.Add(this.LblNomeResponsavel);
            this.panel1.Controls.Add(this.LblDataNasc);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(89, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 384);
            this.panel1.TabIndex = 1;
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
            // TxtBoxNasc
            // 
            this.TxtBoxNasc.Location = new System.Drawing.Point(547, 63);
            this.TxtBoxNasc.Multiline = true;
            this.TxtBoxNasc.Name = "TxtBoxNasc";
            this.TxtBoxNasc.Size = new System.Drawing.Size(118, 21);
            this.TxtBoxNasc.TabIndex = 6;
            // 
            // LblNQuarto
            // 
            this.LblNQuarto.AutoSize = true;
            this.LblNQuarto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNQuarto.Location = new System.Drawing.Point(145, 188);
            this.LblNQuarto.Name = "LblNQuarto";
            this.LblNQuarto.Size = new System.Drawing.Size(118, 21);
            this.LblNQuarto.TabIndex = 4;
            this.LblNQuarto.Text = "Nº do Quarto:";
            // 
            // LblTelResponsavel
            // 
            this.LblTelResponsavel.AutoSize = true;
            this.LblTelResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelResponsavel.Location = new System.Drawing.Point(145, 144);
            this.LblTelResponsavel.Name = "LblTelResponsavel";
            this.LblTelResponsavel.Size = new System.Drawing.Size(191, 21);
            this.LblTelResponsavel.TabIndex = 3;
            this.LblTelResponsavel.Text = "Telefone do resposável:";
            // 
            // LblNomeResponsavel
            // 
            this.LblNomeResponsavel.AutoSize = true;
            this.LblNomeResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeResponsavel.Location = new System.Drawing.Point(145, 101);
            this.LblNomeResponsavel.Name = "LblNomeResponsavel";
            this.LblNomeResponsavel.Size = new System.Drawing.Size(182, 21);
            this.LblNomeResponsavel.TabIndex = 2;
            this.LblNomeResponsavel.Text = "Nome do responsável:";
            // 
            // LblDataNasc
            // 
            this.LblDataNasc.AutoSize = true;
            this.LblDataNasc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataNasc.Location = new System.Drawing.Point(433, 63);
            this.LblDataNasc.Name = "LblDataNasc";
            this.LblDataNasc.Size = new System.Drawing.Size(108, 21);
            this.LblDataNasc.TabIndex = 1;
            this.LblDataNasc.Text = "Nascimento:";
            this.LblDataNasc.Click += new System.EventHandler(this.LblIdade_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(145, 63);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(61, 21);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome:";
            // 
            // TxtBoxNomeResponsavel
            // 
            this.TxtBoxNomeResponsavel.Location = new System.Drawing.Point(333, 104);
            this.TxtBoxNomeResponsavel.Multiline = true;
            this.TxtBoxNomeResponsavel.Name = "TxtBoxNomeResponsavel";
            this.TxtBoxNomeResponsavel.Size = new System.Drawing.Size(332, 21);
            this.TxtBoxNomeResponsavel.TabIndex = 17;
            // 
            // TxtBoxTelResponsavel
            // 
            this.TxtBoxTelResponsavel.Location = new System.Drawing.Point(342, 144);
            this.TxtBoxTelResponsavel.Multiline = true;
            this.TxtBoxTelResponsavel.Name = "TxtBoxTelResponsavel";
            this.TxtBoxTelResponsavel.Size = new System.Drawing.Size(323, 21);
            this.TxtBoxTelResponsavel.TabIndex = 18;
            // 
            // ComboBoxNQuarto
            // 
            this.ComboBoxNQuarto.FormattingEnabled = true;
            this.ComboBoxNQuarto.Location = new System.Drawing.Point(269, 188);
            this.ComboBoxNQuarto.Name = "ComboBoxNQuarto";
            this.ComboBoxNQuarto.Size = new System.Drawing.Size(396, 21);
            this.ComboBoxNQuarto.TabIndex = 19;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(699, 464);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(119, 27);
            this.BtnVoltar.TabIndex = 18;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // TxtBoxNome
            // 
            this.TxtBoxNome.Location = new System.Drawing.Point(212, 63);
            this.TxtBoxNome.Multiline = true;
            this.TxtBoxNome.Name = "TxtBoxNome";
            this.TxtBoxNome.Size = new System.Drawing.Size(215, 21);
            this.TxtBoxNome.TabIndex = 20;
            // 
            // TCadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(940, 512);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TCadastroPaciente";
            this.Text = "TCadastroPaciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtBoxNasc;
        private System.Windows.Forms.Label LblNQuarto;
        private System.Windows.Forms.Label LblTelResponsavel;
        private System.Windows.Forms.Label LblNomeResponsavel;
        private System.Windows.Forms.Label LblDataNasc;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.ComboBox ComboBoxNQuarto;
        private System.Windows.Forms.TextBox TxtBoxTelResponsavel;
        private System.Windows.Forms.TextBox TxtBoxNomeResponsavel;
        private System.Windows.Forms.TextBox TxtBoxNome;
        private System.Windows.Forms.Button BtnVoltar;
    }
}