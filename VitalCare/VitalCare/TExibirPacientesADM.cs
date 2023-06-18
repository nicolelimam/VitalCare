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
    public partial class TExibirPacientesADM : Form
    {
        public TExibirPacientesADM()
        {
            InitializeComponent();

            lst_Pacientes.View = System.Windows.Forms.View.Details;

            lst_Pacientes.LabelEdit = true;
            lst_Pacientes.AllowColumnReorder = true;
            lst_Pacientes.FullRowSelect = true;
            lst_Pacientes.GridLines = true;


            lst_Pacientes.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Cuidador", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Data de nascimento", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("RG", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("CPF", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Nome do responsavel", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Quarto", 150, HorizontalAlignment.Left);


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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            TCadastroPaciente x = new TCadastroPaciente();
            
            x.FormBorderStyle = FormBorderStyle.FixedDialog;
            x.StartPosition = FormStartPosition.CenterParent;
            x.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            MySqlConnection connection = conexao.IniciarConexao();

            string busca = "'%" + TxtBoxPesquisar.Text + "%'";

            string sql = "SELECT * FROM cad_idoso WHERE nome_idoso LIKE" + busca;

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            lst_Pacientes.Items.Clear();


            while (reader.Read())
            {
                string[] row =
                {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8),
                };

                var linha_listview = new ListViewItem(row);

                lst_Pacientes.Items.Add(linha_listview);
            }
        }

        private void lst_Pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection ites_Selecionados = lst_Pacientes.SelectedItems;

            foreach (ListViewItem item in ites_Selecionados)
            {
                TextNome.Text = item.SubItems[1].Text;
                BoxFuncionarios.Text = item.SubItems[2].Text;
                TextDataNascimento.Text = item.SubItems[3].Text;
                TextCPF.Text = item.SubItems[5].Text;
                TextNomeResponsavel.Text = item.SubItems[6].Text;
                TextTele.Text = item.SubItems[7].Text;
                TextNumeroQuarto.Text = item.SubItems[8].Text;

            }
        }

        private void BtnCadastrar_Click_1(object sender, EventArgs e)
        {
            TCadastroPaciente cad = new TCadastroPaciente();
            cad.ShowDialog();
            cad.FormBorderStyle = FormBorderStyle.FixedDialog;
            cad.StartPosition = FormStartPosition.CenterParent;
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {


            Conexao conexao = new Conexao();
            MySqlConnection connection = conexao.IniciarConexao();

            string query = "UPDATE cad_idoso SET nome_idoso=@nome, data_nascimento_idoso=@data, nome_cuidador=@cuidador, cpf_idoso=@cpf, nome_responsavel=@nomeResp, telefone_responsavel=@tele, n_quarto=@numero WHERE cpf_idoso = @cpf";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@nome", TextNome.Text);
            cmd.Parameters.AddWithValue("@data", TextDataNascimento.Text);
            cmd.Parameters.AddWithValue("@cuidador", BoxFuncionarios.Text);
            cmd.Parameters.AddWithValue("@cpf", TextCPF.Text);
            cmd.Parameters.AddWithValue("@nomeResp", TextNomeResponsavel.Text);
            cmd.Parameters.AddWithValue("@tele", TextTele.Text);
            cmd.Parameters.AddWithValue("@numero", TextNumeroQuarto.Text);

            cmd.ExecuteNonQuery();
        }

        private void TxtBoxPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
