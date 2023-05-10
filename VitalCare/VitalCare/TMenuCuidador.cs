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
        public TMenuCuidador()
        {
            InitializeComponent();
        }

        private void TMenuCuidador_Load(object sender, EventArgs e)
        {

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
    }
}
