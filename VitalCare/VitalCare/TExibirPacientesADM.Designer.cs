
namespace VitalCare
{
    partial class TExibirPacientesADM
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
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextTele = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextRG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextNomeResponsavel = new System.Windows.Forms.TextBox();
            this.TextCPF = new System.Windows.Forms.TextBox();
            this.TextDataNascimento = new System.Windows.Forms.TextBox();
            this.TextNumeroQuarto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.lst_Pacientes = new System.Windows.Forms.ListView();
            this.LblPesquisar = new System.Windows.Forms.Label();
            this.TxtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.titulopanel = new System.Windows.Forms.Label();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(719, 59);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(109, 26);
            this.BtnCadastrar.TabIndex = 35;
            this.BtnCadastrar.Text = "Criar novo";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click_1);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.Location = new System.Drawing.Point(852, 473);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(76, 27);
            this.BtnVoltar.TabIndex = 32;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(462, 60);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 26);
            this.BtnBuscar.TabIndex = 34;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.TextTele);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TextRG);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextNomeResponsavel);
            this.panel1.Controls.Add(this.TextCPF);
            this.panel1.Controls.Add(this.TextDataNascimento);
            this.panel1.Controls.Add(this.TextNumeroQuarto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextNome);
            this.panel1.Controls.Add(this.lst_Pacientes);
            this.panel1.Location = new System.Drawing.Point(112, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 408);
            this.panel1.TabIndex = 31;
            // 
            // TextTele
            // 
            this.TextTele.Location = new System.Drawing.Point(4, 301);
            this.TextTele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextTele.Name = "TextTele";
            this.TextTele.Size = new System.Drawing.Size(158, 20);
            this.TextTele.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 285);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "RG";
            // 
            // TextRG
            // 
            this.TextRG.Location = new System.Drawing.Point(4, 161);
            this.TextRG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextRG.Name = "TextRG";
            this.TextRG.Size = new System.Drawing.Size(158, 20);
            this.TextRG.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome do responsavel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quarto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data nascimento";
            // 
            // TextNomeResponsavel
            // 
            this.TextNomeResponsavel.Location = new System.Drawing.Point(4, 253);
            this.TextNomeResponsavel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextNomeResponsavel.Name = "TextNomeResponsavel";
            this.TextNomeResponsavel.Size = new System.Drawing.Size(158, 20);
            this.TextNomeResponsavel.TabIndex = 6;
            // 
            // TextCPF
            // 
            this.TextCPF.Location = new System.Drawing.Point(4, 106);
            this.TextCPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextCPF.Name = "TextCPF";
            this.TextCPF.Size = new System.Drawing.Size(158, 20);
            this.TextCPF.TabIndex = 5;
            // 
            // TextDataNascimento
            // 
            this.TextDataNascimento.Location = new System.Drawing.Point(4, 206);
            this.TextDataNascimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextDataNascimento.Name = "TextDataNascimento";
            this.TextDataNascimento.Size = new System.Drawing.Size(158, 20);
            this.TextDataNascimento.TabIndex = 4;
            // 
            // TextNumeroQuarto
            // 
            this.TextNumeroQuarto.Location = new System.Drawing.Point(4, 336);
            this.TextNumeroQuarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextNumeroQuarto.Name = "TextNumeroQuarto";
            this.TextNumeroQuarto.Size = new System.Drawing.Size(158, 20);
            this.TextNumeroQuarto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // TextNome
            // 
            this.TextNome.Location = new System.Drawing.Point(4, 43);
            this.TextNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(158, 20);
            this.TextNome.TabIndex = 1;
            this.TextNome.TextChanged += new System.EventHandler(this.TextNome_TextChanged);
            // 
            // lst_Pacientes
            // 
            this.lst_Pacientes.HideSelection = false;
            this.lst_Pacientes.Location = new System.Drawing.Point(221, 0);
            this.lst_Pacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lst_Pacientes.Name = "lst_Pacientes";
            this.lst_Pacientes.Size = new System.Drawing.Size(494, 406);
            this.lst_Pacientes.TabIndex = 0;
            this.lst_Pacientes.UseCompatibleStateImageBehavior = false;
            this.lst_Pacientes.SelectedIndexChanged += new System.EventHandler(this.lst_Pacientes_SelectedIndexChanged);
            // 
            // LblPesquisar
            // 
            this.LblPesquisar.AutoSize = true;
            this.LblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.LblPesquisar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblPesquisar.Location = new System.Drawing.Point(108, 61);
            this.LblPesquisar.Name = "LblPesquisar";
            this.LblPesquisar.Size = new System.Drawing.Size(99, 22);
            this.LblPesquisar.TabIndex = 30;
            this.LblPesquisar.Text = "Pesquisar:";
            // 
            // TxtBoxPesquisar
            // 
            this.TxtBoxPesquisar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPesquisar.Location = new System.Drawing.Point(207, 62);
            this.TxtBoxPesquisar.Multiline = true;
            this.TxtBoxPesquisar.Name = "TxtBoxPesquisar";
            this.TxtBoxPesquisar.Size = new System.Drawing.Size(249, 21);
            this.TxtBoxPesquisar.TabIndex = 33;
            this.TxtBoxPesquisar.TextChanged += new System.EventHandler(this.TxtBoxPesquisar_TextChanged);
            // 
            // titulopanel
            // 
            this.titulopanel.AutoSize = true;
            this.titulopanel.BackColor = System.Drawing.Color.Transparent;
            this.titulopanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulopanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.titulopanel.Location = new System.Drawing.Point(296, 11);
            this.titulopanel.Name = "titulopanel";
            this.titulopanel.Size = new System.Drawing.Size(322, 30);
            this.titulopanel.TabIndex = 29;
            this.titulopanel.Text = "PACIENTES CADASTRADOS";
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(852, 420);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(76, 27);
            this.BtnAtualizar.TabIndex = 36;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // TExibirPacientesADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(940, 512);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblPesquisar);
            this.Controls.Add(this.TxtBoxPesquisar);
            this.Controls.Add(this.titulopanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TExibirPacientesADM";
            this.Text = "TExibirPacientesADM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPesquisar;
        private System.Windows.Forms.TextBox TxtBoxPesquisar;
        private System.Windows.Forms.Label titulopanel;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.ListView lst_Pacientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextNomeResponsavel;
        private System.Windows.Forms.TextBox TextCPF;
        private System.Windows.Forms.TextBox TextDataNascimento;
        private System.Windows.Forms.TextBox TextNumeroQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextRG;
        private System.Windows.Forms.TextBox TextTele;
        private System.Windows.Forms.Label label7;
    }
}