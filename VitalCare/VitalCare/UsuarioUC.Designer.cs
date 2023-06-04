
namespace VitalCare
{
    partial class UsuarioUC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomeUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusUsuario = new System.Windows.Forms.Label();
            this.BtnDesativar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.AutoSize = true;
            this.NomeUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.NomeUsuario.Location = new System.Drawing.Point(28, 36);
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.Size = new System.Drawing.Size(165, 22);
            this.NomeUsuario.TabIndex = 0;
            this.NomeUsuario.Text = "Nome do usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email do usuário";
            // 
            // StatusUsuario
            // 
            this.StatusUsuario.AutoSize = true;
            this.StatusUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.StatusUsuario.Location = new System.Drawing.Point(628, 15);
            this.StatusUsuario.Name = "StatusUsuario";
            this.StatusUsuario.Size = new System.Drawing.Size(65, 22);
            this.StatusUsuario.TabIndex = 2;
            this.StatusUsuario.Text = "Status";
            // 
            // BtnDesativar
            // 
            this.BtnDesativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnDesativar.FlatAppearance.BorderSize = 0;
            this.BtnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesativar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesativar.ForeColor = System.Drawing.Color.White;
            this.BtnDesativar.Location = new System.Drawing.Point(605, 105);
            this.BtnDesativar.Name = "BtnDesativar";
            this.BtnDesativar.Size = new System.Drawing.Size(88, 27);
            this.BtnDesativar.TabIndex = 21;
            this.BtnDesativar.Text = "Desativar";
            this.BtnDesativar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(605, 69);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(88, 27);
            this.BtnEditar.TabIndex = 22;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // UsuarioUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnDesativar);
            this.Controls.Add(this.StatusUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeUsuario);
            this.Name = "UsuarioUC";
            this.Size = new System.Drawing.Size(716, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusUsuario;
        private System.Windows.Forms.Button BtnDesativar;
        private System.Windows.Forms.Button BtnEditar;
    }
}
