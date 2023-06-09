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
    public partial class TCadastro : Form
    {
        Conexao conexao = new Conexao();
        public TCadastro()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private void botaoClick_Click(object sender, EventArgs e)
        {
            string email = campoEmail.Text;
            string senha = campoSenha.Text;

            MySqlConnection connection = conexao.IniciarConexao();

            try
            {
                string query = "INSERT INTO dados_login (email, senha) VALUES (@Email, @Senha)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", senha);
                command.ExecuteNonQuery();
                MessageBox.Show("Dados Salvos com Sucesso!");

                var TelaLogin = new TLogin();
                TelaLogin.Show();
            }
            catch
            {
                MessageBox.Show("Erro ao inserir dados: ");
            }

        }

        private void campoEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
