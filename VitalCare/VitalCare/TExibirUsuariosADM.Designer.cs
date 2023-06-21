
namespace VitalCare
{
    partial class TExibirUsuariosADM
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.titulopanel = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.TextCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextNomeUsu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.lst_usuarios = new System.Windows.Forms.ListView();
            this.LblPesquisar = new System.Windows.Forms.Label();
            this.TxtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulopanel
            // 
            this.titulopanel.AutoSize = true;
            this.titulopanel.BackColor = System.Drawing.Color.Transparent;
            this.titulopanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulopanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.titulopanel.Location = new System.Drawing.Point(400, 16);
            this.titulopanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulopanel.Name = "titulopanel";
            this.titulopanel.Size = new System.Drawing.Size(386, 37);
            this.titulopanel.TabIndex = 22;
            this.titulopanel.Text = "USUÁRIOS CADASTRADOS";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(967, 70);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(145, 32);
            this.BtnCadastrar.TabIndex = 28;
            this.BtnCadastrar.Text = "Criar novo";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.Location = new System.Drawing.Point(1128, 581);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(101, 33);
            this.BtnVoltar.TabIndex = 25;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(592, 71);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(131, 32);
            this.BtnBuscar.TabIndex = 27;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.TextEmail);
            this.panel1.Controls.Add(this.TextCargo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextNomeUsu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextNome);
            this.panel1.Controls.Add(this.lst_usuarios);
            this.panel1.Location = new System.Drawing.Point(125, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 502);
            this.panel1.TabIndex = 24;
            // 
            // TextEmail
            // 
            this.TextEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextEmail.Location = new System.Drawing.Point(16, 311);
            this.TextEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(235, 27);
            this.TextEmail.TabIndex = 8;
            // 
            // TextCargo
            // 
            this.TextCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextCargo.Location = new System.Drawing.Point(16, 242);
            this.TextCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextCargo.Name = "TextCargo";
            this.TextCargo.Size = new System.Drawing.Size(235, 27);
            this.TextCargo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(13, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(13, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome de usuário";
            // 
            // TextNomeUsu
            // 
            this.TextNomeUsu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextNomeUsu.Location = new System.Drawing.Point(16, 175);
            this.TextNomeUsu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextNomeUsu.Name = "TextNomeUsu";
            this.TextNomeUsu.Size = new System.Drawing.Size(235, 27);
            this.TextNomeUsu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // TextNome
            // 
            this.TextNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextNome.Location = new System.Drawing.Point(16, 105);
            this.TextNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(235, 27);
            this.TextNome.TabIndex = 1;
            // 
            // lst_usuarios
            // 
            this.lst_usuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lst_usuarios.HideSelection = false;
            this.lst_usuarios.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lst_usuarios.Location = new System.Drawing.Point(267, 15);
            this.lst_usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_usuarios.Name = "lst_usuarios";
            this.lst_usuarios.Size = new System.Drawing.Size(705, 470);
            this.lst_usuarios.TabIndex = 0;
            this.lst_usuarios.UseCompatibleStateImageBehavior = false;
            this.lst_usuarios.SelectedIndexChanged += new System.EventHandler(this.lst_usuarios_SelectedIndexChanged);
            // 
            // LblPesquisar
            // 
            this.LblPesquisar.AutoSize = true;
            this.LblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.LblPesquisar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblPesquisar.Location = new System.Drawing.Point(120, 73);
            this.LblPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPesquisar.Name = "LblPesquisar";
            this.LblPesquisar.Size = new System.Drawing.Size(130, 30);
            this.LblPesquisar.TabIndex = 23;
            this.LblPesquisar.Text = "Pesquisar:";
            // 
            // TxtBoxPesquisar
            // 
            this.TxtBoxPesquisar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPesquisar.Location = new System.Drawing.Point(252, 74);
            this.TxtBoxPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBoxPesquisar.Multiline = true;
            this.TxtBoxPesquisar.Name = "TxtBoxPesquisar";
            this.TxtBoxPesquisar.Size = new System.Drawing.Size(331, 25);
            this.TxtBoxPesquisar.TabIndex = 26;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(1128, 534);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(101, 33);
            this.BtnAtualizar.TabIndex = 29;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // TExibirUsuariosADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(1253, 649);
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
            this.Name = "TExibirUsuariosADM";
            this.Text = "TExibirUsuariosADM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulopanel;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPesquisar;
        private System.Windows.Forms.TextBox TxtBoxPesquisar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.ListView lst_usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextNomeUsu;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.TextBox TextCargo;
    }
}