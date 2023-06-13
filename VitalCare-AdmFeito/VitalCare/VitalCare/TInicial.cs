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
    public partial class TInicial : Form
    {
        public TInicial()
        {
            InitializeComponent();
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TLogin x = new TLogin();
            x.Show();
        }
    }
}
