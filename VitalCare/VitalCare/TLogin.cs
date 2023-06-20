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


                    string sql = "select cargo_usuario, nome_usuario  from cad_usuario where usuario_email = '" + campoEmail.Text + "' and senha_login = '" + campoSenha.Text + "' ";


                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    Conexao.Open();

                    MySqlDataReader dr = comando.ExecuteReader();

                    if (dr.Read() == true)
                    {

                        string cargo = dr.GetString(0);
                        String nome = dr.GetString(1);


                        string adm = "Administrador", user = "Cuidador";

                        if (cargo.Equals(adm))
                        {
                            TMenuAdministrador x = new TMenuAdministrador();
                            this.Hide();
                            x.Show();

                        }
                        else if (cargo.Equals(user))
                        {
                            TMenuCuidador n = new TMenuCuidador(nome);
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
                MessageBox.Show("Erro ao Realizar o Login: " + ex.Message);
                limparCampos();
            }


        }

        private void limparCampos()
        {
            campoEmail.Text = "";
            campoSenha.Text = "";
            campoEmail.Select();

        }
    }
}
