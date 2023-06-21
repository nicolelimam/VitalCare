using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalCare
{
    public partial class TCadastroUsuarioADM : Form
    {
        Conexao conexao = new Conexao();
        
        public TCadastroUsuarioADM()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = conexao.IniciarConexao();

            string nome, nomeUsario, senha, email, cargo;

            nome = campoNome.Text;
            nomeUsario = campoNomeUsu.Text;
            email = campoEmail.Text;
            cargo = BoxCargo.Text;
            senha = CampoSenha.Text;
           

            string sql = "INSERT INTO cad_usuario (id_usuario, nome, nome_usuario, cargo_usuario, usuario_email, senha_login) " +  "VALUES" + "('" + null + "','" + nome + "','" + nomeUsario + "','" + cargo + "','" + email + "','" + senha + "')";
            
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.ExecuteReader();
            MessageBox.Show("Dados Salvos com Sucesso!");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
