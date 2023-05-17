using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalCare
{
    public partial class TLogin : Form
    {
        public TLogin() => InitializeComponent();

        private GraphicsPath GraphicsPath()
        {
            throw new NotImplementedException();
        }

        private void CampoEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CampoSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextoEmail_Click(object sender, EventArgs e)
        {

        }

        private void TextoLogin_Click(object sender, EventArgs e)
        {

        }

        //TESTE - direciona para a tela principal do cuidador
        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TMenuCuidador x = new TMenuCuidador();
            x.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TLogin_Load(object sender, EventArgs e)
        {
            //impede que o usuário expanda a janela
            this.MaximumSize = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TMenuAdministrador x = new TMenuAdministrador();
            x.Show();
        }
    }
}
