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
    public partial class PacienteUC : UserControl
    {
        public PacienteUC()
        {
            InitializeComponent();
        }

        private void BtnProntuário_Click(object sender, EventArgs e)
        {
            TExibirProntuarioCuidador x = new TExibirProntuarioCuidador();
            x.ShowDialog();
            x.FormBorderStyle = FormBorderStyle.FixedDialog;
            x.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
