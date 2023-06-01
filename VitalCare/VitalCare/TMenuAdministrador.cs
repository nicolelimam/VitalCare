using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalCare
{
    public partial class TMenuAdministrador : Form
    {
        public TMenuAdministrador()
        {
            InitializeComponent();
        }

        public void abrirForms(object Form)
        {
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            Form x = Form as Form;
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            x.Location = new Point(0, 0);
            x.Size = panelprincipal.Size;
            panelprincipal.Controls.Clear();
            this.panelprincipal.Controls.Add(x);
            this.panelprincipal.Tag = x;
            x.Show();
        }

        private void TMenuAdministrador_Load(object sender, EventArgs e)
        {
            //impede que o usuário expanda a janela
            this.MaximumSize = this.Size;
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            TLogin x = new TLogin();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnProntuario_Click(object sender, EventArgs e)
        {
            abrirForms(new TCadastroProntuario());
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            TExibirPacientesADM x = new TExibirPacientesADM();
            x.Show();
        }
    }
}
