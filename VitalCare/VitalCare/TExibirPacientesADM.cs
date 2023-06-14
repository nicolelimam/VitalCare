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
    public partial class TExibirPacientesADM : Form
    {
        public TExibirPacientesADM()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            TCadastroPaciente x = new TCadastroPaciente();
            
            x.FormBorderStyle = FormBorderStyle.FixedDialog;
            x.StartPosition = FormStartPosition.CenterParent;
            x.ShowDialog();
        }
    }
}
