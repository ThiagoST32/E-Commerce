using System.Windows.Forms;
using System.Xml.Linq;

namespace E_Commerce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            BtnSairHome = new Button();
            BtnConfigurações = new Button();
            BtnTabelaFuncionarios = new Button();
            BtnFuncionarios = new Button();
            BtnTabelaProdutos = new Button();
            BtnProduto = new Button();
            panelLogo = new Panel();
            panelLogoMain = new Panel();
            labelHome = new Label();
            panelFundoSystem = new Panel();
            panelMenu.SuspendLayout();
            panelLogoMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(224, 81, 53);
            panelMenu.Controls.Add(BtnSairHome);
            panelMenu.Controls.Add(BtnConfigurações);
            panelMenu.Controls.Add(BtnTabelaFuncionarios);
            panelMenu.Controls.Add(BtnFuncionarios);
            panelMenu.Controls.Add(BtnTabelaProdutos);
            panelMenu.Controls.Add(BtnProduto);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 447);
            panelMenu.TabIndex = 0;
            // 
            // BtnSairHome
            // 
            BtnSairHome.Dock = DockStyle.Top;
            BtnSairHome.FlatAppearance.BorderSize = 0;
            BtnSairHome.FlatStyle = FlatStyle.Flat;
            BtnSairHome.ForeColor = Color.White;
            BtnSairHome.Image = (Image)resources.GetObject("BtnSairHome.Image");
            BtnSairHome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSairHome.Location = new Point(0, 325);
            BtnSairHome.Name = "BtnSairHome";
            BtnSairHome.Size = new Size(200, 50);
            BtnSairHome.TabIndex = 6;
            BtnSairHome.Text = "Sair";
            BtnSairHome.UseVisualStyleBackColor = true;
            BtnSairHome.Click += BtnSairHome_Click;
            // 
            // BtnConfigurações
            // 
            BtnConfigurações.Dock = DockStyle.Top;
            BtnConfigurações.FlatAppearance.BorderSize = 0;
            BtnConfigurações.FlatStyle = FlatStyle.Flat;
            BtnConfigurações.ForeColor = Color.White;
            BtnConfigurações.Image = Properties.Resources.configuracoes;
            BtnConfigurações.ImageAlign = ContentAlignment.MiddleLeft;
            BtnConfigurações.Location = new Point(0, 275);
            BtnConfigurações.Name = "BtnConfigurações";
            BtnConfigurações.Size = new Size(200, 50);
            BtnConfigurações.TabIndex = 5;
            BtnConfigurações.Text = "Configurações";
            BtnConfigurações.UseVisualStyleBackColor = true;
            BtnConfigurações.Click += BtnConfigurações_Click;
            // 
            // BtnTabelaFuncionarios
            // 
            BtnTabelaFuncionarios.Dock = DockStyle.Top;
            BtnTabelaFuncionarios.FlatAppearance.BorderSize = 0;
            BtnTabelaFuncionarios.FlatStyle = FlatStyle.Flat;
            BtnTabelaFuncionarios.ForeColor = Color.White;
            BtnTabelaFuncionarios.Image = Properties.Resources.mesa;
            BtnTabelaFuncionarios.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTabelaFuncionarios.Location = new Point(0, 225);
            BtnTabelaFuncionarios.Name = "BtnTabelaFuncionarios";
            BtnTabelaFuncionarios.Size = new Size(200, 50);
            BtnTabelaFuncionarios.TabIndex = 4;
            BtnTabelaFuncionarios.Text = "Tabela Funcionarios";
            BtnTabelaFuncionarios.UseVisualStyleBackColor = true;
            BtnTabelaFuncionarios.Click += BtnTabelaFuncionarios_Click;
            // 
            // BtnFuncionarios
            // 
            BtnFuncionarios.Dock = DockStyle.Top;
            BtnFuncionarios.FlatAppearance.BorderSize = 0;
            BtnFuncionarios.FlatStyle = FlatStyle.Flat;
            BtnFuncionarios.ForeColor = Color.White;
            BtnFuncionarios.Image = Properties.Resources.do_utilizador;
            BtnFuncionarios.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFuncionarios.Location = new Point(0, 175);
            BtnFuncionarios.Name = "BtnFuncionarios";
            BtnFuncionarios.Size = new Size(200, 50);
            BtnFuncionarios.TabIndex = 3;
            BtnFuncionarios.Text = "Funcionarios";
            BtnFuncionarios.UseVisualStyleBackColor = true;
            BtnFuncionarios.Click += BtnFuncionarios_Click;
            // 
            // BtnTabelaProdutos
            // 
            BtnTabelaProdutos.Dock = DockStyle.Top;
            BtnTabelaProdutos.FlatAppearance.BorderSize = 0;
            BtnTabelaProdutos.FlatStyle = FlatStyle.Flat;
            BtnTabelaProdutos.ForeColor = Color.White;
            BtnTabelaProdutos.Image = Properties.Resources.tabela_de_edicao;
            BtnTabelaProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTabelaProdutos.Location = new Point(0, 125);
            BtnTabelaProdutos.Name = "BtnTabelaProdutos";
            BtnTabelaProdutos.Size = new Size(200, 50);
            BtnTabelaProdutos.TabIndex = 2;
            BtnTabelaProdutos.Text = "Tabela Produtos";
            BtnTabelaProdutos.UseVisualStyleBackColor = true;
            BtnTabelaProdutos.Click += BtnTabelaProdutos_Click;
            // 
            // BtnProduto
            // 
            BtnProduto.Dock = DockStyle.Top;
            BtnProduto.FlatAppearance.BorderSize = 0;
            BtnProduto.FlatStyle = FlatStyle.Flat;
            BtnProduto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnProduto.ForeColor = Color.White;
            BtnProduto.Image = Properties.Resources.carrinho_de_compras__2_;
            BtnProduto.ImageAlign = ContentAlignment.MiddleLeft;
            BtnProduto.Location = new Point(0, 75);
            BtnProduto.Name = "BtnProduto";
            BtnProduto.Size = new Size(200, 50);
            BtnProduto.TabIndex = 1;
            BtnProduto.Text = "Produtos";
            BtnProduto.UseVisualStyleBackColor = true;
            BtnProduto.Click += BtnProduto_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = Properties.Resources.loja_virtual;
            panelLogo.BackgroundImageLayout = ImageLayout.Center;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Enabled = false;
            panelLogo.ForeColor = Color.White;
            panelLogo.ImeMode = ImeMode.Off;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 75);
            panelLogo.TabIndex = 0;
            // 
            // panelLogoMain
            // 
            panelLogoMain.BackColor = Color.FromArgb(224, 81, 53);
            panelLogoMain.Controls.Add(labelHome);
            panelLogoMain.Dock = DockStyle.Top;
            panelLogoMain.Location = new Point(200, 0);
            panelLogoMain.Name = "panelLogoMain";
            panelLogoMain.Size = new Size(539, 75);
            panelLogoMain.TabIndex = 1;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            labelHome.ForeColor = Color.White;
            labelHome.Location = new Point(6, 9);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(131, 51);
            labelHome.TabIndex = 0;
            labelHome.Text = "HOME";
            // 
            // panelFundoSystem
            // 
            panelFundoSystem.BackColor = Color.FromArgb(224, 81, 53);
            panelFundoSystem.Dock = DockStyle.Fill;
            panelFundoSystem.Location = new Point(200, 75);
            panelFundoSystem.Name = "panelFundoSystem";
            panelFundoSystem.Size = new Size(539, 372);
            panelFundoSystem.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 447);
            Controls.Add(panelFundoSystem);
            Controls.Add(panelLogoMain);
            Controls.Add(panelMenu);
            Name = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogoMain.ResumeLayout(false);
            panelLogoMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button BtnConfigurações;
        private Button BtnTabelaFuncionarios;
        private Button BtnFuncionarios;
        private Button BtnTabelaProdutos;
        private Button BtnProduto;
        private Panel panelLogo;
        private Panel panelLogoMain;
        private Label labelHome;
        private Panel panelFundoSystem;
        private Button BtnSairHome;
    }
}