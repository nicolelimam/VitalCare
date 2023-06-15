using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VitalCare
{
    public partial class TLogin : Form
    {
        private Conexao conexao;
        private string nome;

        public TLogin()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private GraphicsPath GraphicsPath()
        {
            throw new NotImplementedException();
        }

        private void CampoEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CampoSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextoEmail_Click(object sender, EventArgs e)
        {

        }

        private void TextoLogin_Click(object sender, EventArgs e)
        {

        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            string email = campoEmail.Text;
            string senha = campoSenha.Text;

            MySqlConnection connection = conexao.IniciarConexao();

            try
            {
                string query = "SELECT COUNT(*) FROM cad_usuario WHERE usuario_email = @usuario_email AND senha_login = @senha_login";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario_email", email);
                command.Parameters.AddWithValue("@senha_login", senha);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    query = "SELECT nome FROM cad_usuario WHERE usuario_email = @usuario_email";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario_email", email);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        nome = result.ToString();

                        MessageBox.Show("Login realizado com Sucesso !!");
                        this.Hide();
                        TMenuCuidador x = new TMenuCuidador(nome);
                        x.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nome não encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Email ou senha inválidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Realizar o Login: " + ex.Message);
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TLogin_Load(object sender, EventArgs e)
        {
            // Impede que o usuário expanda a janela
            this.MaximumSize = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TMenuAdministrador x = new TMenuAdministrador();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TExibirProntuarioCuidador p = new TExibirProntuarioCuidador();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}