﻿
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
            this.label6 = new System.Windows.Forms.Label();
            this.TextRG = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(953, 73);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(145, 32);
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
            this.BtnVoltar.Location = new System.Drawing.Point(1115, 577);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(101, 33);
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
            this.BtnBuscar.Location = new System.Drawing.Point(611, 74);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(131, 32);
            this.BtnBuscar.TabIndex = 34;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.TextRG);
            this.panel1.Controls.Add(this.TextTele);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
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
            this.panel1.Location = new System.Drawing.Point(144, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 502);
            this.panel1.TabIndex = 31;
            // 
            // TextTele
            // 
            this.TextTele.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextTele.Location = new System.Drawing.Point(15, 395);
            this.TextTele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextTele.Name = "TextTele";
            this.TextTele.Size = new System.Drawing.Size(253, 27);
            this.TextTele.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label7.Location = new System.Drawing.Point(9, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label5.Location = new System.Drawing.Point(9, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome do responsavel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(9, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quarto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(9, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data de nascimento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextNomeResponsavel
            // 
            this.TextNomeResponsavel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextNomeResponsavel.Location = new System.Drawing.Point(15, 327);
            this.TextNomeResponsavel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextNomeResponsavel.Name = "TextNomeResponsavel";
            this.TextNomeResponsavel.Size = new System.Drawing.Size(253, 27);
            this.TextNomeResponsavel.TabIndex = 6;
            // 
            // TextCPF
            // 
            this.TextCPF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCPF.Location = new System.Drawing.Point(8, 121);
            this.TextCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextCPF.Name = "TextCPF";
            this.TextCPF.Size = new System.Drawing.Size(260, 27);
            this.TextCPF.TabIndex = 5;
            // 
            // TextDataNascimento
            // 
            this.TextDataNascimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDataNascimento.Location = new System.Drawing.Point(13, 261);
            this.TextDataNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextDataNascimento.Name = "TextDataNascimento";
            this.TextDataNascimento.Size = new System.Drawing.Size(255, 27);
            this.TextDataNascimento.TabIndex = 4;
            // 
            // TextNumeroQuarto
            // 
            this.TextNumeroQuarto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextNumeroQuarto.Location = new System.Drawing.Point(15, 454);
            this.TextNumeroQuarto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextNumeroQuarto.Name = "TextNumeroQuarto";
            this.TextNumeroQuarto.Size = new System.Drawing.Size(253, 27);
            this.TextNumeroQuarto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // TextNome
            // 
            this.TextNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNome.Location = new System.Drawing.Point(8, 55);
            this.TextNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(260, 27);
            this.TextNome.TabIndex = 1;
            this.TextNome.TextChanged += new System.EventHandler(this.TextNome_TextChanged);
            // 
            // lst_Pacientes
            // 
            this.lst_Pacientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lst_Pacientes.HideSelection = false;
            this.lst_Pacientes.Location = new System.Drawing.Point(289, 0);
            this.lst_Pacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_Pacientes.Name = "lst_Pacientes";
            this.lst_Pacientes.Size = new System.Drawing.Size(657, 499);
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
            this.LblPesquisar.Location = new System.Drawing.Point(139, 75);
            this.LblPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPesquisar.Name = "LblPesquisar";
            this.LblPesquisar.Size = new System.Drawing.Size(130, 30);
            this.LblPesquisar.TabIndex = 30;
            this.LblPesquisar.Text = "Pesquisar:";
            // 
            // TxtBoxPesquisar
            // 
            this.TxtBoxPesquisar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPesquisar.Location = new System.Drawing.Point(271, 76);
            this.TxtBoxPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBoxPesquisar.Multiline = true;
            this.TxtBoxPesquisar.Name = "TxtBoxPesquisar";
            this.TxtBoxPesquisar.Size = new System.Drawing.Size(331, 25);
            this.TxtBoxPesquisar.TabIndex = 33;
            this.TxtBoxPesquisar.TextChanged += new System.EventHandler(this.TxtBoxPesquisar_TextChanged);
            // 
            // titulopanel
            // 
            this.titulopanel.AutoSize = true;
            this.titulopanel.BackColor = System.Drawing.Color.Transparent;
            this.titulopanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulopanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.titulopanel.Location = new System.Drawing.Point(395, 14);
            this.titulopanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulopanel.Name = "titulopanel";
            this.titulopanel.Size = new System.Drawing.Size(396, 37);
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
            this.BtnAtualizar.Location = new System.Drawing.Point(1115, 532);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(101, 33);
            this.BtnAtualizar.TabIndex = 36;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.Location = new System.Drawing.Point(5, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "RG";
            // 
            // TextRG
            // 
            this.TextRG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRG.Location = new System.Drawing.Point(8, 195);
            this.TextRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextRG.Name = "TextRG";
            this.TextRG.Size = new System.Drawing.Size(260, 27);
            this.TextRG.TabIndex = 15;
            // 
            // TExibirPacientesADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(1253, 630);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblPesquisar);
            this.Controls.Add(this.TxtBoxPesquisar);
            this.Controls.Add(this.titulopanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox TextTele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextRG;
        private System.Windows.Forms.Label label6;
    }
}