using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class listaEventosForm : Form
    {
        String connString = "server=localhost;user id=root;database=vitalcaree;sslmode=none";
        
        public listaEventosForm()
        {
            InitializeComponent();
        }

        private void listaEventosForm_Load(object sender, EventArgs e)
        {
            
        }
               
    }
}
