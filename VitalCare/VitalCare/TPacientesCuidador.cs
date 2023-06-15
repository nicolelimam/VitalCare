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
    public partial class TPacientesCuidador : Form
    {
        private string nome;
        public TPacientesCuidador(string nome)
        {
            InitializeComponent();
            this.nome = nome;

            lst_Pacientes.View = System.Windows.Forms.View.Details;

            lst_Pacientes.LabelEdit = true;
            lst_Pacientes.AllowColumnReorder = true;
            lst_Pacientes.FullRowSelect = true;
            lst_Pacientes.GridLines = true;

            lst_Pacientes.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Quarto", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Idade", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Médico", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Comorbidade", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Medicamentos", 150, HorizontalAlignment.Left);
            lst_Pacientes.Columns.Add("Observação", 150, HorizontalAlignment.Left);
        }

        private void TPacientesCuidador_Load(object sender, EventArgs e)
        {

        }

        private void titulopanel_Click(object sender, EventArgs e)
        {

        }

        private void LblPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            TLogin Tlogin = new TLogin();

            MySqlConnection connection = conexao.IniciarConexao();

            string busca = TxtBoxPesquisar.Text.Trim();

            string sql;

            if (string.IsNullOrEmpty(busca))
            {
                sql = "SELECT * FROM ficha_medica WHERE nome_cuidador = @nome";
            }
            else
            {
                busca = '%' + busca + '%';
                sql = "SELECT * FROM ficha_medica WHERE (nome_idoso LIKE @busca OR quarto LIKE @busca) AND nome_cuidador = @nome";
            }

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@busca", busca);
            cmd.Parameters.AddWithValue("@nome", nome);

            MySqlDataReader reader = cmd.ExecuteReader();

            lst_Pacientes.Items.Clear();

            while (reader.Read())
            {
                string[] row =
                {
            reader.GetString(0),
            reader.GetString(2),
            reader.GetString(10),
            reader.GetString(3),
            reader.GetString(9),
            reader.GetString(5),
            reader.GetString(6),
            reader.GetString(7),
        };

                var linha_listview = new ListViewItem(row);

                lst_Pacientes.Items.Add(linha_listview);
            }
        }

        private void lst_Pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items_Selecionados = lst_Pacientes.SelectedItems;

            foreach (ListViewItem item in items_Selecionados)
            {
                TextNome.Text = item.SubItems[1].Text;
                TextQuarto.Text = item.SubItems[2].Text;
                TextIdade.Text = item.SubItems[3].Text;
                TextMedico.Text = item.SubItems[4].Text;
                TextComorbidade.Text = item.SubItems[5].Text;
                TextMedicamentos.Text = item.SubItems[6].Text;
                TextObservacao.Text = item.SubItems[7].Text;
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection connection = conexao.IniciarConexao();

            try
            {
                string query = "UPDATE ficha_medica SET nome_idoso=@nome, idade_idoso=@idade, quarto=@quarto, nome_medico=@medico, nome_comorbidade=@comorbidades, tratamento_ficha_medica=@medicamentos, observacoes=@observacoes WHERE nome_idoso=@nome";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nome", TextNome.Text);
                cmd.Parameters.AddWithValue("@idade", TextIdade.Text);
                cmd.Parameters.AddWithValue("@quarto", TextQuarto.Text);
                cmd.Parameters.AddWithValue("@medico", TextMedico.Text);
                cmd.Parameters.AddWithValue("@comorbidades", TextComorbidade.Text);
                cmd.Parameters.AddWithValue("@medicamentos", TextMedicamentos.Text);
                cmd.Parameters.AddWithValue("@observacoes", TextObservacao.Text); 
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Atualizados!");
                BtnBuscar_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao Atualizar: " + ex.Message);
            }

           
        }
    }
}