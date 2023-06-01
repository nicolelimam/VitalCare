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
    public partial class TCadastroProntuario : Form
    {
        Conexao conexao = new Conexao();
        public TCadastroProntuario()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nome = campoNome.Text;
            string idade = campoIdade.Text;
            string comorbidades = campoComorbidades.Text;
            string medicamentos = campoMedicamentos.Text;
            string observacao = campoObservacao.Text;

            MySqlConnection connection = conexao.IniciarConexao();

            try
            {
                string query = "INSERT INTO prontuario (nome, idade, comorbidades, medicamentos, observacao) VALUES (@Nome, @Idade, @Comorbidades, @Medicamentos, @Observacao)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Idade", idade);
                command.Parameters.AddWithValue("@Comorbidades", comorbidades);
                command.Parameters.AddWithValue("@Medicamentos", medicamentos);
                command.Parameters.AddWithValue("@Observacao", observacao);
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