
namespace VitalCare
{
    partial class TProntuariosCuidador
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
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(54, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 435);
            this.panel1.TabIndex = 0;
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Location = new System.Drawing.Point(836, 489);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(100, 26);
            this.botaoVoltar.TabIndex = 1;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // TProntuariosCuidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(948, 527);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TProntuariosCuidador";
            this.Text = "TProntuariosCuidador";
            this.Load += new System.EventHandler(this.TProntuariosCuidador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botaoVoltar;
    }
}