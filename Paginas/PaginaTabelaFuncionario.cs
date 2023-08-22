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

namespace E_Commerce.Paginas
{
    public partial class PaginaTabelaFuncionario : Form
    {
        private MySqlConnection conn;
        private int? id_contato_selecionado = null;

        private string data_source = ("datasource=localhost;username=root;password=Bnas123!@#;database=Ecommerce");
        public PaginaTabelaFuncionario()
        {

            InitializeComponent();
            LoadDataFromDatabase();
        }



        private void BtnBuscarDados_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(data_source))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    string buscar = "'%" + textBoxPesquisarFuncionario.Text + "%'";

                    cmd.Parameters.AddWithValue("@buscarDados", buscar);

                    string query = "SELECT * FROM funcionarios WHERE NomeFuncionario LIKE" + buscar + ";";


                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    DataTabelaFuncionario.DataSource = dataTable;

                    if (buscar == "" || buscar == string.Empty)
                    {
                        LoadDataFromDatabase();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERRO " + ex.Number + " ocorreu " + ex.Message,
                        "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu " + ex.Message,
                        "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void LoadDataFromDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(data_source))
                try
                {
                    string query = "SELECT * FROM funcionarios;";


                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    DataTabelaFuncionario.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERRO " + ex.Number + " ocorreu " + ex.Message,
                        "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu " + ex.Message,
                        "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }
        }



        private void BtnSairTabelaFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
