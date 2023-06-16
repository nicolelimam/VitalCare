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

            CampoCPF.Text = CampoCPF.Text.Replace(".", "").Replace("-", "");

            //Puxando dados do Banco
            Conexao conexao = new Conexao();
            MySqlConnection connection = conexao.IniciarConexao();

            string funcionarios = "SELECT nome_usuario FROM cad_usuario";
            MySqlCommand cmd = new MySqlCommand(funcionarios, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nomeFuncionario = reader["nome_usuario"].ToString();
                BoxFuncionarios.Items.Add(nomeFuncionario);


            }
            reader.Close();
        }

        private void LblIdade_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Boolean cpfValido = false;

            string nome=campoNome.Text;
            string nasci = campoNasc.Text;
            string rg = CampoRG.Text;
            string cpf = CampoCPF.Text;
            string nomeResp = campoResponsavel.Text;
            string tele = campoTelefone.Text;
            string quarto = campoQuarto.Text;
            string cuidador = BoxFuncionarios.Text;
       

            MySqlConnection connection = conexao.IniciarConexao();
            string query = "INSERT INTO cad_idoso (id_idoso, nome_idoso, nome_cuidador, data_nascimento_idoso, rg_idoso, cpf_idoso, nome_responsavel, telefone_responsavel, n_quarto) VALUES (@id, @nome, @cuidador, @nasci, @rg, @cpf, @nomeRespon, @telefone, @quarto)";
            
            
            MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", null);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cuidador", cuidador);
                cmd.Parameters.AddWithValue("@nasci", nasci);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@nomeRespon", nomeResp);
                cmd.Parameters.AddWithValue("@telefone", tele);
                cmd.Parameters.AddWithValue("@quarto", quarto);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Salvos com Sucesso!");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CampoCPF_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
