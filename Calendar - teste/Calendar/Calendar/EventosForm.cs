using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calendar
{
    public partial class EventosForm : Form
    {
        //criar a connectionstring
        String connString = "server=localhost;user id=root;database=vitalcaree;sslmode=none";
        
        public EventosForm()
        {
            InitializeComponent();
            listarCuidador();
            listarIdoso();
        }

        private void EventosForm_Load(object sender, EventArgs e)
        {
            //chamar as variaveis estaticos que declaramos
            //textData.Text = Form1.static_mes+"/" + UserControlDays.static_dia + "/" + Form1.static_ano;
            textData.Text = UserControlDays.static_dia + "/" + Form1.static_mes + "/" + Form1.static_ano;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tb_calendario(data,titulo,evento)values(?,?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("data", textData.Text);
            cmd.Parameters.AddWithValue("titulo", txtTituloEvento.Text);
            cmd.Parameters.AddWithValue("evento", txtEvento.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("SALVO COM SUCESSO!");

            //limpar campos depos de ter salvo
            txtTituloEvento.Text = "";
            txtEvento.Text = "";

            cmd.Dispose();
            conn.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listCuidador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void listarCuidador()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                String cuidador = "select *from tb_cuidador";
                MySqlCommand cmdsalvar = new MySqlCommand(cuidador, conn);
                conn.Open();
                DataSet ds = new DataSet();
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmdsalvar);
                adpt.Fill(ds);
                listCuidador.DataSource = ds.Tables[0];
                listCuidador.DisplayMember = "nome_cuidador";
                listCuidador.ValueMember = "id";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void listarIdoso()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                String idoso = "select *from tb_idoso";
                MySqlCommand cmdsalvar = new MySqlCommand(idoso, conn);
                conn.Open();
                DataSet ds = new DataSet();
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmdsalvar);
                adpt.Fill(ds);
                listIdoso.DataSource = ds.Tables[0];
                listIdoso.DisplayMember = "nome_idoso";
                listIdoso.ValueMember = "id";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //sair da janela adicionar eventos
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
