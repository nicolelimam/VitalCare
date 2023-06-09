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
    public partial class TExibirUsuariosADM : Form
    {
        public TExibirUsuariosADM()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            TCadastroUsuarioADM cad = new TCadastroUsuarioADM();
            cad.ShowDialog();
            cad.FormBorderStyle = FormBorderStyle.FixedDialog;
            cad.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
