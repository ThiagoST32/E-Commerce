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
        /* 
* private Color SelectThemeColor()
{
    int index = random.Next(ThemeColor.ColorList.Count);
    while (tempIndex == index)
    {
        index = random.Next(ThemeColor.ColorList.Count);
    }
    tempIndex = index;
    string color = ThemeColor.ColorList[tempIndex];
    return ColorTranslator.FromHtml(color);
}

//Função onde irá executar a função SeletcThemeColor
private void ActiveButton(object btnSender)
{
    if (btnSender != null)
    {
        if (currentButton != (Button)btnSender)
        {
            //Chamo a função Disable//Chamo a variavel currentButton para//Chamo a variavel color e defino como backColor//Defino uma cor para o backColor chamando a função Color
            currentButton = (Button)btnSender;
        }
    }
}

//Função Desativa o botão
private void OpenChildForm(Form childform, object btnsender)
{
    if (activeForm != null)
    {
        activeForm.Close();
    }
    ActiveButton(btnsender);
    activeForm = childform;
    childform.TopLevel = false;
    childform.FormBorderStyle = FormBorderStyle.None;
    childform.Dock = DockStyle.Fill;
    this.panelFundoConfiguracao.Controls.Add(childform);
    this.panelFundoConfiguracao.Tag = childform;
    childform.BringToFront();
    childform.Show();

}
private void BtnSairConfiguracao_Click(object sender, EventArgs e)
{

}

private void BtnHomeConfiguracao_Click(object sender, EventArgs e)
{
    OpenChildForm(new Form1(), sender);
}*/
    }
}
