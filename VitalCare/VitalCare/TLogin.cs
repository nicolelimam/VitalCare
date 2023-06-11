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
        MySqlConnection Conexao;
        public TLogin()
        {
            InitializeComponent();
            campoEmail.Select();
            campoSenha.PasswordChar = '*';
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
            try
            {
                if (campoEmail.Text == "" && campoSenha.Text == "")
                {
                    MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    campoEmail.Select();

                }
                else
                {
                    string data_source = "datasource=localhost;username=root;password=;database=vitalcare";

                    Conexao = new MySqlConnection(data_source);


                    string sql = "select cargo_usuario from cad_usuario where usuario_email = '" + campoEmail.Text + "' and senha_login = '" + campoSenha.Text + "' ";


                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    Conexao.Open();

                    MySqlDataReader dr = comando.ExecuteReader();

                    if (dr.Read() == true)
                    {

                        string cargo = dr.GetString(0);

                        string adm = "Administrador", user = "Cuidador";

                        if (cargo.Equals(adm))
                        {
                            TMenuAdministrador x = new TMenuAdministrador();
                            this.Hide();
                            x.Show();

                        }
                        else if (cargo.Equals(user))
                        {
                            TMenuCuidador n = new TMenuCuidador();
                            this.Hide();
                            n.Show();

                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha invalidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            limparCampos();
                        }

                        Conexao.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha invalidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limparCampos();
                    }

                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                limparCampos();
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TExibirProntuarioCuidador p = new TExibirProntuarioCuidador();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TMenuCuidador n = new TMenuCuidador();
            n.Show();
        }

        private void limparCampos()
        {
            campoEmail.Text = "";
            campoSenha.Text = "";
            campoEmail.Select();
        }
    }
}
