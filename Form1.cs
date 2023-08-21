using MySql.Data.MySqlClient;

namespace E_Commerce
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
       

        public Form1()
        {
            random = new Random();
            InitializeComponent();

        }

        //Methods

        //Função que faz com que o botão pressionado permaneça em uma cor pré-determinada
        private Color SelectThemeColor()
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
                    //Defino a fonte do botão 
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        //Função Desativa o botão

        private void DisableButton()
        {
            foreach (Control previuosBtn in panelMenu.Controls)
            {
                if (previuosBtn.GetType() == typeof(Button))
                {
                    previuosBtn.BackColor = Color.FromArgb(224, 81, 53);
                    previuosBtn.ForeColor = Color.White;
                    previuosBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

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
            this.panelFundoSystem.Controls.Add(childform);
            this.panelFundoSystem.Tag = childform;
            childform.BringToFront();
            childform.Show();
            labelHome.Text = childform.Text;


        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Paginas.PaginaProdutos(), sender);
        }
        private void BtnTabelaProdutos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Paginas.PaginaTabelaProdutos(), sender);
        }
        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Paginas.PaginaCadastrarFuncionario(), sender);
        }
        private void BtnTabelaFuncionarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Paginas.PaginaTabelaFuncionario(), sender);
        }
        private void BtnConfigurações_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Paginas.PaginaConfigurações(), sender);
        }
    }
}