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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }
        String connString = "server=localhost;user id=root;database=vitalcare;sslmode=none";

        //criar outra variavel estatico para dia;
        public static string static_dia;

       

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void Dias(int numDia)
        {
            lbDias.Text = numDia + "";
        }

       /* private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_dia = lbDias.Text;

            timer1.Start();

            EventosForm eventosForm = new EventosForm();
            eventosForm.Show();*/
        

        //mudar de cor quando mouse passar 
        private void UserControlDays_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.GreenYellow;
        }

        private void UserControlDays_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.GreenYellow;
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void lbDias_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.GreenYellow;
        }

        private void lbDias_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        /*//criar metodo para mostrar evento
        private void mostrarEvento()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM calendario where data = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("data", UserControlDays.static_dia + "/" + Form1.static_mes + "/" + Form1.static_ano);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //lbEvento.Text = reader.GetString("data");
                lbEvento.Text = reader["evento"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        //criar o tempo para auto mostrar evento se o novo evento foi adicionado
        private void timer1_Tick(object sender, EventArgs e)
        {
            //chamar o metodo mostrarEvento
            mostrarEvento();

        }*/

        private void VerificarData()
        {
            DateTime dataAtual = DateTime.Today;
            DateTime dataComparacao = new DateTime(2023, 5, 27);

            if (dataAtual == dataComparacao)
            {
                BackColor = System.Drawing.Color.Blue;
            }
        }
    }
}
