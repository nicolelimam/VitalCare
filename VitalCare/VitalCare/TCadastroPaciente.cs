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
    public partial class TCadastroPaciente : Form
    {
        Conexao conexao = new Conexao();
        public TCadastroPaciente()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private void LblIdade_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nome = campoNome.Text;
            string nascimento = campoNasc.Text;
            string responsavel = campoResponsavel.Text;
            string telefone = campoTelefone.Text;
            string quarto = campoQuarto.Text;

            MySqlConnection connection = conexao.IniciarConexao();

            try
            {
                string query = "INSERT INTO pacientes (nome, nascimento, responsavel, telefone, quarto) VALUES (@Nome, @Nascimento, @Responsavel, @Telefone, @Quarto)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Nascimento", nascimento);
                command.Parameters.AddWithValue("@Responsavel", responsavel);
                command.Parameters.AddWithValue("@Telefone", telefone);
                command.Parameters.AddWithValue("@Quarto", quarto);
                command.ExecuteNonQuery();
                MessageBox.Show("Dados Salvos com Sucesso!");

            }
            catch
            {
                MessageBox.Show("Erro ao Salvar Dados: ");
            }

        }
    }
}
