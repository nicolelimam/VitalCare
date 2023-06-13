namespace Calendar
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbDias = new System.Windows.Forms.Label();
            this.lbEvento = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_listarEventos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDias.Location = new System.Drawing.Point(31, 15);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(46, 32);
            this.lbDias.TabIndex = 0;
            this.lbDias.Text = "00";
            this.lbDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDias.MouseEnter += new System.EventHandler(this.lbDias_MouseEnter);
            this.lbDias.MouseLeave += new System.EventHandler(this.lbDias_MouseLeave);
            // 
            // lbEvento
            // 
            this.lbEvento.AutoSize = true;
            this.lbEvento.Location = new System.Drawing.Point(25, 60);
            this.lbEvento.Name = "lbEvento";
            this.lbEvento.Size = new System.Drawing.Size(0, 16);
            this.lbEvento.TabIndex = 1;
            this.lbEvento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbEvento.Click += new System.EventHandler(this.UserControlDays_Click);
            this.lbEvento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbEvento_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_listarEventos
            // 
            this.btn_listarEventos.BackColor = System.Drawing.Color.Transparent;
            this.btn_listarEventos.FlatAppearance.BorderSize = 0;
            this.btn_listarEventos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_listarEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_listarEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarEventos.Location = new System.Drawing.Point(3, 60);
            this.btn_listarEventos.Name = "btn_listarEventos";
            this.btn_listarEventos.Size = new System.Drawing.Size(102, 20);
            this.btn_listarEventos.TabIndex = 2;
            this.btn_listarEventos.Text = "EVENTOS";
            this.btn_listarEventos.UseVisualStyleBackColor = false;
            this.btn_listarEventos.Click += new System.EventHandler(this.btn_listarEventos_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_listarEventos);
            this.Controls.Add(this.lbEvento);
            this.Controls.Add(this.lbDias);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(108, 85);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlDays_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlDays_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UserControlDays_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.Label lbEvento;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_listarEventos;
    }
}
