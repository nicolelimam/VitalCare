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

            //Puxando dados do Banco
            Conexao conexao = new Conexao();
            MySqlConnection connection = conexao.IniciarConexao();

            string comorbidades = "SELECT nome_comorbidade FROM comorbidade";
            MySqlCommand cmdComorbidades = new MySqlCommand(comorbidades, connection);

            MySqlDataReader readerComorbidades = cmdComorbidades.ExecuteReader();

            while (readerComorbidades.Read())
            {
                string nomeComorbidade = readerComorbidades["nome_comorbidade"].ToString();
                campoComorbidades.Items.Add(nomeComorbidade);


            }
            readerComorbidades.Close();


            //Idosos
            string idosos = "SELECT nome_idoso FROM cad_idoso";
            MySqlCommand cmdIdosos = new MySqlCommand(idosos, connection);

            MySqlDataReader readerIdoso = cmdIdosos.ExecuteReader();

            while (readerIdoso.Read())
            {
                string nomeIdosos = readerIdoso["nome_idoso"].ToString();
                campoNome.Items.Add(nomeIdosos);

            }
            readerIdoso.Close();

            //Medicamentos
            string medicamento = "SELECT nome_medicamento FROM medicamento";

            MySqlCommand cmdMedicamento = new MySqlCommand(medicamento, connection);

            MySqlDataReader readerMedicamento = cmdMedicamento.ExecuteReader();

            while (readerMedicamento.Read())
            {
                string nomeMedicamento = readerMedicamento["nome_medicamento"].ToString();
                campoMedicamentos.Items.Add(nomeMedicamento);

            }
            readerMedicamento.Close();


            // Nome cuidador
            string cuidador = "SELECT nome FROM cad_usuario";
            MySqlCommand cmdcuiudador = new MySqlCommand(cuidador, connection);

            MySqlDataReader readercuiudador = cmdcuiudador.ExecuteReader();

            while (readercuiudador.Read())
            {
                string nomeCuidador = readercuiudador["nome"].ToString();
                BoxEmail.Items.Add(nomeCuidador);

            }

            readercuiudador.Close();


        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = conexao.IniciarConexao();
            
            string nome = campoNome.Text;

            int idade = int.Parse(campoIdade.Text);
            string nomeMedico = CampoMedico.Text;
            string comorbidade = campoComorbidades.Text;
            string medicamento = campoMedicamentos.Text;
            string obs = campoObservacao.Text;
            string cuidador = BoxEmail.Text;
            string quarto = TextQuarto.Text;
            

            string sql = "INSERT INTO ficha_medica (nome_idoso, idade_idoso, nome_comorbidade, tratamento_ficha_medica, observacoes, nome_medico, nome_cuidador, quarto)" +
                "VALUES (@nomeIdoso, @idade, @comorbidade, @medicamento, @obs, @nomeMedico, @cuidador, @quarto)";

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@nomeIdoso", nome);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.Parameters.AddWithValue("@comorbidade", comorbidade);
            cmd.Parameters.AddWithValue("@medicamento", medicamento);
            cmd.Parameters.AddWithValue("@obs", obs);
            cmd.Parameters.AddWithValue("@nomeMedico", nomeMedico);
            cmd.Parameters.AddWithValue("@cuidador", cuidador);
            cmd.Parameters.AddWithValue("@quarto", quarto);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Dados Salvos com Sucesso!");

        }

        private void campoNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void campoComorbidades_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }