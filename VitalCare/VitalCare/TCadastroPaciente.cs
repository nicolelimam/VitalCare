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
            string nome=campoNome.Text;
            string nasci = campoNasc.Text;
            string rg = CampoRG.Text;
            string cpf = CampoCPF.Text;
            string nomeResp = campoResponsavel.Text;
            string tele = campoTelefone.Text;
            string quarto = campoQuarto.Text;
       

            MySqlConnection connection = conexao.IniciarConexao();
            string query = "INSERT INTO cad_idoso (id_idoso, nome_idoso, data_nascimento_idoso, rg_idoso, cpf_idoso, nome_responsavel, telefone_responsavel, n_quarto) VALUES (@id, @nome, @nasci, @rg, @cpf, @nomeRespon, @telefone, @quarto)";
            
            
            MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", null);
                cmd.Parameters.AddWithValue("@nome", nome);
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
    }
}
