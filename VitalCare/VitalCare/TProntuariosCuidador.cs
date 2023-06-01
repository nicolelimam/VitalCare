using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VitalCare
{
    public partial class TProntuariosCuidador : Form
    {
        
        public TMenuCuidador FormPrincipal { get; set; } 

        public TProntuariosCuidador()
        {
            InitializeComponent();
           
        }

        private void TProntuariosCuidador_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
