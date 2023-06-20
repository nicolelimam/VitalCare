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
    public partial class TMenuCuidador : Form
    {
        private string nome;

        public TMenuCuidador(string nome)
        {
            InitializeComponent();
            abrirForms(new TInicial());
            this.nome = nome;
        }


        private void TMenuCuidador_Load(object sender, EventArgs e)
        {
            //impede que o usuário expanda a janela
            this.MaximumSize = this.Size;
            TInicial x = new TInicial();
        }

        //Abre uma janela dentro do painel principal (para abrir as telas sem ocultar o menu)
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

        //volta para a tela de login
        private void BotaoVoitar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TLogin l = new TLogin();
            l.Show();

        }

        private void Logo_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void FundoMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botaoLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TLogin x = new TLogin();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirForms(new TCalendarioCuidador());
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            TLogin x = new TLogin();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirForms(new TPacientesCuidador(nome));
        }

        private void panelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
