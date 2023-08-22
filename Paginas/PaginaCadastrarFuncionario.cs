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
    public partial class PaginaCadastrarFuncionario : Form
    {
        private MySqlConnection conn;
        private string data_source = ("datasource=localhost;username=root;password=Bnas123!@#;database=Ecommerce");
        public PaginaCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void InsertFuncionarios()
        {
            try
            {
                conn = new MySqlConnection(data_source);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO funcionarios (NomeFuncionario,IdadeFuncionario,EmailFuncionario,CPFuncionario,RGFuncionario,DataNascimentoFuncionario,CEPFuncionario," +
                    "NumeroCasaFuncionario,EstadoCivilFuncionario,CargoFuncionario,DataEntradaFuncionario,TurnoFuncionario)" +
                    "VALUES (@NomeFuncionario,@IdadeFuncionario,@EmailFuncionario,@CPFuncionario,@RGFuncionario,@DataNascimentoFuncionario,@CEPFuncionario," +
                    "@NumeroCasaFuncionario,@EstadoCivilFuncionario,@CargoFuncionario,@DataEntradaFuncionario,@TurnoFuncionario)";

                cmd.Parameters.AddWithValue("@NomeFuncionario", TxtNomeFuncionario.Text);
                cmd.Parameters.AddWithValue("@IdadeFuncionario", TxtIdadeFuncionario.Text);
                cmd.Parameters.AddWithValue("@EmailFuncionario", TxtEmailFuncionario.Text);
                cmd.Parameters.AddWithValue("@RGFuncionario", TxtRGFuncionario.Text);
                cmd.Parameters.AddWithValue("@DataNascimentoFuncionario", DataNascimentoFuncionario.Value);
                cmd.Parameters.AddWithValue("@CPFuncionario", TxtCPFuncionario.Text);
                cmd.Parameters.AddWithValue("@CEPFuncionario", TxtCEPFuncionario.Text);
                cmd.Parameters.AddWithValue("@NumeroCasaFuncionario", TxtNumeroCasaFuncionario.Text);
                cmd.Parameters.AddWithValue("@EstadoCivilFuncionario", ComboBoxEstadoCivilFuncionario.GetItemText(ComboBoxEstadoCivilFuncionario.SelectedItem));
                cmd.Parameters.AddWithValue("@CargoFuncionario", ComboBoxCargoFuncionario.GetItemText(ComboBoxCargoFuncionario.SelectedItem));
                cmd.Parameters.AddWithValue("@DataEntradaFuncionario", DataEntradaFuncionario.Value);
                cmd.Parameters.AddWithValue("@TurnoFuncionario", ComboBoxTurnoFuncionario.GetItemText(ComboBoxTurnoFuncionario.SelectedItem));
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario Cadastrado com Sucesso!!!");

                TxtNomeFuncionario.Text = string.Empty;
                TxtIdadeFuncionario.Text = string.Empty;
                TxtEmailFuncionario.Text = string.Empty;
                TxtCPFuncionario.Text = string.Empty;
                TxtRGFuncionario.Text = string.Empty;
                DataNascimentoFuncionario.Value = DateTime.Now;
                TxtCEPFuncionario.Text = string.Empty;
                TxtNumeroCasaFuncionario.Text = string.Empty;
                ComboBoxEstadoCivilFuncionario.Text = string.Empty;
                ComboBoxCargoFuncionario.Text = string.Empty;
                DataEntradaFuncionario.Value = DateTime.Now;
                ComboBoxTurnoFuncionario.Text = string.Empty;






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


        private void BtnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            InsertFuncionarios();
        }

        private void BtnSairCadastroFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
