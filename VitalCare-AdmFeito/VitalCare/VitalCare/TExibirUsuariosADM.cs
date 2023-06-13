using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace VitalCare
{
    public partial class TExibirUsuariosADM : Form
    {
        public TExibirUsuariosADM()
        {
            InitializeComponent();
            lst_usuarios.View = System.Windows.Forms.View.Details;

            lst_usuarios.LabelEdit = true;
            lst_usuarios.AllowColumnReorder = true;
            lst_usuarios.FullRowSelect = true;
            lst_usuarios.GridLines = true;


            lst_usuarios.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_usuarios.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_usuarios.Columns.Add("Nome de Usuario", 150, HorizontalAlignment.Left);
            lst_usuarios.Columns.Add("Cargo", 150, HorizontalAlignment.Left);
            lst_usuarios.Columns.Add("Email", 150, HorizontalAlignment.Left);


        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            TCadastroUsuarioADM cad = new TCadastroUsuarioADM();
            cad.ShowDialog();
            cad.FormBorderStyle = FormBorderStyle.FixedDialog;
            cad.StartPosition = FormStartPosition.CenterParent;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            MySqlConnection connection = conexao.IniciarConexao();

            string busca = "'%" + TxtBoxPesquisar.Text + "%'";

            string sql = "SELECT * FROM cad_usuario WHERE nome LIKE" + busca;

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            lst_usuarios.Items.Clear();


            while (reader.Read())
            {
                string[] row =
                {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                };

                var linha_listview = new ListViewItem(row);

                lst_usuarios.Items.Add(linha_listview);
            }
        }

        private void lst_usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection ites_Selecionados = lst_usuarios.SelectedItems;

            foreach(ListViewItem item  in ites_Selecionados)
            {
                TextNome.Text = item.SubItems[1].Text;
                TextNomeUsu.Text = item.SubItems[2].Text;
                TextCargo.Text = item.SubItems[3].Text;
                TextEmail.Text = item.SubItems[4].Text;

            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection connection = conexao.IniciarConexao();

            string query = "UPDATE cad_usuario SET nome=@nome, nome_usuario=@nomeUsuario, cargo_usuario=@cargo, usuario_email=@email WHERE usuario_email = @email";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@nome", TextNome.Text);
            cmd.Parameters.AddWithValue("@nomeUsuario", TextNomeUsu.Text);
            cmd.Parameters.AddWithValue("@cargo", TextCargo.Text);
            cmd.Parameters.AddWithValue("@email", TextEmail.Text);

            cmd.ExecuteNonQuery();
        }
    }
}
