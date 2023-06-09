namespace Calendar
{
    partial class EventosForm
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
            this.textData = new System.Windows.Forms.TextBox();
            this.listCuidador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.RichTextBox();
            this.txtTituloEvento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listIdoso = new System.Windows.Forms.ComboBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textData
            // 
            this.textData.Enabled = false;
            this.textData.Location = new System.Drawing.Point(68, 139);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(306, 22);
            this.textData.TabIndex = 0;
            // 
            // listCuidador
            // 
            this.listCuidador.FormattingEnabled = true;
            this.listCuidador.Location = new System.Drawing.Point(68, 67);
            this.listCuidador.Name = "listCuidador";
            this.listCuidador.Size = new System.Drawing.Size(306, 24);
            this.listCuidador.TabIndex = 2;
            this.listCuidador.SelectedIndexChanged += new System.EventHandler(this.listCuidador_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cuidador";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(226, 456);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 28);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Observações:\r\n";
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(69, 337);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(305, 102);
            this.txtEvento.TabIndex = 9;
            this.txtEvento.Text = "";
            // 
            // txtTituloEvento
            // 
            this.txtTituloEvento.Location = new System.Drawing.Point(68, 204);
            this.txtTituloEvento.Name = "txtTituloEvento";
            this.txtTituloEvento.Size = new System.Drawing.Size(306, 22);
            this.txtTituloEvento.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome do paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Título:";
            // 
            // listIdoso
            // 
            this.listIdoso.FormattingEnabled = true;
            this.listIdoso.Location = new System.Drawing.Point(68, 277);
            this.listIdoso.Name = "listIdoso";
            this.listIdoso.Size = new System.Drawing.Size(306, 24);
            this.listIdoso.TabIndex = 13;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(69, 456);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(141, 28);
            this.btn_sair.TabIndex = 14;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // EventosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 517);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.listIdoso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCuidador);
            this.Controls.Add(this.txtTituloEvento);
            this.Controls.Add(this.textData);
            this.Name = "EventosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventosForm";
            this.Load += new System.EventHandler(this.EventosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.ComboBox listCuidador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtEvento;
        private System.Windows.Forms.TextBox txtTituloEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listIdoso;
        private System.Windows.Forms.Button btn_sair;
    }
}