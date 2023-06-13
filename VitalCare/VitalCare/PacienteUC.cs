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
    public partial class PacienteUC : UserControl
    {
        private Conexao conexao;
        public PacienteUC()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private void BtnProntuário_Click(object sender, EventArgs e)
        {
            TExibirProntuarioCuidador x = new TExibirProntuarioCuidador();
            x.ShowDialog();
            x.FormBorderStyle = FormBorderStyle.FixedDialog;
            x.StartPosition = FormStartPosition.CenterParent;
        }

        private void PacienteUC_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = conexao.IniciarConexao();

            try
            {
                string query = "SELECT nome, quarto FROM dados_paciente";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nome = reader.GetString("nome");
                        string quarto = reader.GetString("quarto");
                        campoNome.Text = nome;
                        campoNome.Text = nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar os dados do paciente: " + ex.Message);
            }
        }

    }
}
