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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Commerce.Paginas
{
    public partial class PaginaProdutos : Form
    {
        private MySqlConnection conn;

        private string data_source = ("datasource=localhost;username=root;password=Bnas123!@#;database=Ecommerce");
        public PaginaProdutos()
        {
            InitializeComponent();
            ConxãoBancoMysql();
        }
        private void ConxãoBancoMysql()
        {
            try
            {
                conn = new MySqlConnection(data_source);
                conn.Open();
                MessageBox.Show("Conectado com Sucesso!!!!");

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
                conn.Close();
            }
        }

        private void InsertProdutos()
        {
            try
            {
                //ConxãoBancoMysql();
                conn = new MySqlConnection(data_source);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;


                DateTime dataCadastro = Convert.ToDateTime(DataCadastroProdutos);
                DateTime dataEntrada = Convert.ToDateTime(DataEntradaProdutos);


                cmd.CommandText = "INSERT INTO produtos (NomeProduto,PrecoProduto,QuantidadeProduto,MarcaProduto,FornecedorProduto,PesoProduto,DadosFiscaisProduto,CodigoProduto,EmbalagemProduto," +
                    "TipoProduto,DataCadastro,DataEntrada)" +
                    "VALUES (@NomeProduto,@Preço,@Quantidade,@Marca,@Fornecedores,@Peso" +
                    ",@DadosFiscais,@CodigoDeBarras,@Embalagem,@TipoProduto,'" + DataCadastroProdutos.ToString() + "','" + DataEntradaProdutos.ToString() + "')";

                

                cmd.Parameters.AddWithValue("@NomeProduto", TxtNomeProduto.Text);
                cmd.Parameters.AddWithValue("@Preço", TxtPreçoProduto.Text);
                cmd.Parameters.AddWithValue("@Quantidade", TxtQuantidadeProduto.Text);
                cmd.Parameters.AddWithValue("@Marca", TxtMarcaProduto.Text);
                cmd.Parameters.AddWithValue("@Fornecedores", TxtFornercedorProduto.Text);
                cmd.Parameters.AddWithValue("@Peso", TxtPesoProduto.Text);
                cmd.Parameters.AddWithValue("@DadosFiscais", TxtDadosFiscaisProduto.Text);
                cmd.Parameters.AddWithValue("@CodigoDeBarras", TxtCodigoProduto.Text);
                cmd.Parameters.AddWithValue("@Embalagem", TxtEmbalagemProduto.Text);
                cmd.Parameters.AddWithValue("@TipoProduto", ComboBoxTipoProdutos.GetItemText(ComboBoxTipoProdutos.SelectedItem));
                cmd.Parameters.AddWithValue("@DataCadastro", SqlDbType.Date).Value = DataCadastroProdutos.Value.Date;
                cmd.Parameters.AddWithValue("@DataEntrada", SqlDbType.Date).Value = DataEntradaProdutos.Value.Date;
                cmd.Prepare();
                cmd.ExecuteNonQuery();


                MessageBox.Show("Produto Cadastrado com sucesso!!!");

                TxtNomeProduto.Text = string.Empty;
                TxtPreçoProduto.Text = string.Empty;
                TxtQuantidadeProduto.Text = string.Empty;
                TxtMarcaProduto.Text = string.Empty;
                TxtFornercedorProduto.Text = string.Empty;
                TxtPesoProduto.Text = string.Empty;
                TxtDadosFiscaisProduto.Text = string.Empty;
                TxtCodigoProduto.Text = string.Empty;
                TxtEmbalagemProduto.Text = string.Empty;
                ComboBoxTipoProdutos.Text = string.Empty;
                DataCadastroProdutos.Value = DateTime.Now;
                DataEntradaProdutos.Value = DateTime.Now;




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
                conn.Close();
            }
        }

        private void BtnCadastrarProduto_Click(object sender, EventArgs e)
        {
            InsertProdutos();
        }
    }
}
