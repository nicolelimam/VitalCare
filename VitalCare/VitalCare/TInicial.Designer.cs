
namespace VitalCare
{
    partial class TInicial
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
            this.Btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnlogout
            // 
            this.Btnlogout.Location = new System.Drawing.Point(771, 442);
            this.Btnlogout.Name = "Btnlogout";
            this.Btnlogout.Size = new System.Drawing.Size(125, 31);
            this.Btnlogout.TabIndex = 0;
            this.Btnlogout.Text = "Log out";
            this.Btnlogout.UseVisualStyleBackColor = true;
            this.Btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // TInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VitalCare.Properties.Resources.Tela_Principal___Cuidador;
            this.ClientSize = new System.Drawing.Size(940, 512);
            this.Controls.Add(this.Btnlogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnlogout;
    }
}