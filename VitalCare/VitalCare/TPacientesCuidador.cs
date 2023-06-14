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
    public partial class TPacientesCuidador : Form
    {
        private Conexao conexao;

        public TPacientesCuidador()
        {
            conexao = new Conexao();
            InitializeComponent();

            tabelaPacientes.View = View.Details;
            tabelaPacientes.LabelEdit = true;
            tabelaPacientes.AllowColumnReorder = true;
            tabelaPacientes.FullRowSelect = true;
            tabelaPacientes.GridLines = true;
            tabelaPacientes.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            tabelaPacientes.Columns.Add("Quarto", 200, HorizontalAlignment.Left);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                string q = campoPesquisa.Text.Trim();

                string query;

                if (string.IsNullOrEmpty(q))
                {
                    // Consulta para buscar todos os registros
                    query = "SELECT * FROM pacientes";
                }
                else
                {
                    // Consulta para buscar registros com base no campo de pesquisa
                    q = "'%" + q + "%'";
                    query = "SELECT * FROM pacientes WHERE nome LIKE " + q + " OR quarto LIKE " + q;
                }

                MySqlConnection connection = conexao.IniciarConexao();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                tabelaPacientes.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                reader.GetString(0),
                reader.GetString(1),
            };
                    var linha_listview = new ListViewItem(row);
                    tabelaPacientes.Items.Add(linha_listview);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao inserir dados");
            }
        }
    }
}
