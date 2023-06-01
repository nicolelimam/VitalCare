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

        //TESTE - direciona para a tela principal do cuidador
        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            string email = campoEmail.Text;
            string senha = campoSenha.Text;

            MySqlConnection connection = conexao.IniciarConexao();

            try
            {
                string query = "SELECT COUNT(*) FROM dados_login WHERE email = @Email AND senha = @Senha";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", senha);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Login realizado com Sucesso !!");
                    this.Hide();
                    TMenuCuidador x = new TMenuCuidador();
                    x.Show();
                }
                else
                {
                    MessageBox.Show("Email ou senha inválidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Realizaro Login: " + ex.Message);
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
            //impede que o usuário expanda a janela
            this.MaximumSize = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TMenuAdministrador x = new TMenuAdministrador();
            x.Show();
        }
    }
}
