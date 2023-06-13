
namespace VitalCare
{
    partial class PacienteUC
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
            this.BtnProntuário = new System.Windows.Forms.Button();
            this.campoQuarto = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnProntuário
            // 
            this.BtnProntuário.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(180)))), ((int)(((byte)(158)))));
            this.BtnProntuário.FlatAppearance.BorderSize = 0;
            this.BtnProntuário.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProntuário.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProntuário.ForeColor = System.Drawing.Color.White;
            this.BtnProntuário.Location = new System.Drawing.Point(603, 101);
            this.BtnProntuário.Name = "BtnProntuário";
            this.BtnProntuário.Size = new System.Drawing.Size(88, 27);
            this.BtnProntuário.TabIndex = 26;
            this.BtnProntuário.Text = "Prontuário";
            this.BtnProntuário.UseVisualStyleBackColor = false;
            this.BtnProntuário.Click += new System.EventHandler(this.BtnProntuário_Click);
            // 
            // campoQuarto
            // 
            this.campoQuarto.AutoSize = true;
            this.campoQuarto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoQuarto.Location = new System.Drawing.Point(26, 71);
            this.campoQuarto.Name = "campoQuarto";
            this.campoQuarto.Size = new System.Drawing.Size(144, 20);
            this.campoQuarto.TabIndex = 24;
            this.campoQuarto.Text = "Numero do quarto";
            // 
            // campoNome
            // 
            this.campoNome.AutoSize = true;
            this.campoNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.campoNome.Location = new System.Drawing.Point(26, 38);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(184, 22);
            this.campoNome.TabIndex = 23;
            this.campoNome.Text = "Nome do paciente";
            // 
            // PacienteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnProntuário);
            this.Controls.Add(this.campoQuarto);
            this.Controls.Add(this.campoNome);
            this.Name = "PacienteUC";
            this.Size = new System.Drawing.Size(716, 150);
            this.Load += new System.EventHandler(this.PacienteUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProntuário;
        private System.Windows.Forms.Label campoQuarto;
        private System.Windows.Forms.Label campoNome;
    }
}
