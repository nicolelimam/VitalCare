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
            tabelaPacientes.AllowUserToAddRows = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string q = campoPesquisa.Text.Trim();

                string query;

                if (string.IsNullOrEmpty(q))
                {
                    query = "SELECT * FROM pacientes";
                }
                else
                {
                    q = "'%" + q + "%'";
                    query = "SELECT * FROM pacientes WHERE nome LIKE " + q + " OR quarto LIKE " + q;
                }

                MySqlConnection connection = conexao.IniciarConexao();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                tabelaPacientes.Rows.Clear();

                while (reader.Read())
                {
                    string nome = reader.GetString(0);
                    string quarto = reader.GetString(1);

                    tabelaPacientes.Rows.Add(nome, quarto);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados: " + ex.Message);
            }
        }

        private void tabelaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabelaPacientes.Columns["colunaProntuario"].Index && e.RowIndex >= 0)
            {
                TExibirProntuarioCuidador prontuarioForm = new TExibirProntuarioCuidador();
                prontuarioForm.Show();
            }
        }

    }
}