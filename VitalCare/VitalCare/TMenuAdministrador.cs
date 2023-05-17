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
    }
}
