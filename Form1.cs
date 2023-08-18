namespace E_Commerce
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;


        public Form1()
        {

            InitializeComponent();

        }



        //Methods

        //Fun��o que faz com que o bot�o pressionado permane�a em uma cor pr�-determinada
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        //Fun��o onde ir� executar a fun��o SeletcThemeColor
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton == (Button)btnSender)
                {
                    //Chamo a fun��o Disable
                    DisableButton();
                    Color color = SelectThemeColor();
                    //Chamo a variavel currentButton para 
                    currentButton = (Button)btnSender;
                    //Chamo a variavel color e defino como backColor
                    currentButton.BackColor = color;
                    //Defino uma cor para o backColor chamando a fun��o Color
                    currentButton.ForeColor = Color.White;
                    //Defino a fonte do bot�o 
                    currentButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        //Fun��o Desativa o bot�o

        private void DisableButton()
        {
            foreach (Control previuosBtn in panelMenu.Controls)
            {
                if (previuosBtn.GetType() == typeof(Button))
                {
                    previuosBtn.BackColor = Color.FromArgb(14, 42, 86);
                    previuosBtn.ForeColor = Color.White;
                    previuosBtn.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void BtnConfigura��es_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void BtnTabelaProdutos_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void BtnTabelaFuncionarios_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
    }
}