using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Paginas
{
    public partial class PaginaConfigurações : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private MySqlConnection conn;
        private string data_source = ("datasource=localhost;username=root;password=Bnas123!@#;database=Ecommerce;");

        public PaginaConfigurações()
        {
            InitializeComponent();
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
        private void BtnTesteBancoConfiguracao_Click(object sender, EventArgs e)
        {
            ConxãoBancoMysql();
        }

        private void BtnSairConfiguração_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
