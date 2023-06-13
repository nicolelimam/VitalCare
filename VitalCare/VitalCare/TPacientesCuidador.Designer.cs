
namespace VitalCare
{
    partial class TPacientesCuidador
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
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.titulopanel = new System.Windows.Forms.Label();
            this.botaoBuscar = new System.Windows.Forms.Button();
            this.LblPesquisar = new System.Windows.Forms.Label();
            this.campoPesquisa = new System.Windows.Forms.TextBox();
            this.tabelaPacientes = new System.Windows.Forms.DataGridView();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaProntuario = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(852, 473);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(76, 27);
            this.BtnAtualizar.TabIndex = 39;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            // 
            // titulopanel
            // 
            this.titulopanel.AutoSize = true;
            this.titulopanel.BackColor = System.Drawing.Color.Transparent;
            this.titulopanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulopanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.titulopanel.Location = new System.Drawing.Point(365, 15);
            this.titulopanel.Name = "titulopanel";
            this.titulopanel.Size = new System.Drawing.Size(208, 30);
            this.titulopanel.TabIndex = 37;
            this.titulopanel.Text = "MEUS PACIENTES";
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.botaoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoBuscar.ForeColor = System.Drawing.Color.White;
            this.botaoBuscar.Location = new System.Drawing.Point(603, 95);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(98, 26);
            this.botaoBuscar.TabIndex = 43;
            this.botaoBuscar.Text = "Buscar";
            this.botaoBuscar.UseVisualStyleBackColor = false;
            this.botaoBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblPesquisar
            // 
            this.LblPesquisar.AutoSize = true;
            this.LblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.LblPesquisar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.LblPesquisar.Location = new System.Drawing.Point(249, 96);
            this.LblPesquisar.Name = "LblPesquisar";
            this.LblPesquisar.Size = new System.Drawing.Size(99, 22);
            this.LblPesquisar.TabIndex = 41;
            this.LblPesquisar.Text = "Pesquisar:";
            // 
            // campoPesquisa
            // 
            this.campoPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPesquisa.Location = new System.Drawing.Point(348, 97);
            this.campoPesquisa.Multiline = true;
            this.campoPesquisa.Name = "campoPesquisa";
            this.campoPesquisa.Size = new System.Drawing.Size(249, 21);
            this.campoPesquisa.TabIndex = 42;
            // 
            // tabelaPacientes
            // 
            this.tabelaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNome,
            this.colunaQuarto,
            this.colunaProntuario});
            this.tabelaPacientes.Location = new System.Drawing.Point(115, 127);
            this.tabelaPacientes.Name = "tabelaPacientes";
            this.tabelaPacientes.Size = new System.Drawing.Size(720, 306);
            this.tabelaPacientes.TabIndex = 45;
            this.tabelaPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaPacientes_CellContentClick);
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.Name = "colunaNome";
            // 
            // colunaQuarto
            // 
            this.colunaQuarto.HeaderText = "Quarto";
            this.colunaQuarto.Name = "colunaQuarto";
            // 
            // colunaProntuario
            // 
            this.colunaProntuario.HeaderText = "Prontuário";
            this.colunaProntuario.Name = "colunaProntuario";
            this.colunaProntuario.Text = "";
            // 
            // TPacientesCuidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(940, 512);
            this.Controls.Add(this.tabelaPacientes);
            this.Controls.Add(this.botaoBuscar);
            this.Controls.Add(this.LblPesquisar);
            this.Controls.Add(this.campoPesquisa);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.titulopanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TPacientesCuidador";
            this.Text = "TProntuariosCuidador";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Label titulopanel;
        private System.Windows.Forms.Button botaoBuscar;
        private System.Windows.Forms.Label LblPesquisar;
        private System.Windows.Forms.TextBox campoPesquisa;
        private System.Windows.Forms.DataGridView tabelaPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaQuarto;
        private System.Windows.Forms.DataGridViewButtonColumn colunaProntuario;
    }
}