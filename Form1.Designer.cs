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
            panelMenu = new Panel();
            BtnConfigurações = new Button();
            BtnTabelaFuncionarios = new Button();
            BtnFuncionarios = new Button();
            BtnTabelaProdutos = new Button();
            BtnProduto = new Button();
            panelLogo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(224, 81, 53);
            panelMenu.Controls.Add(BtnConfigurações);
            panelMenu.Controls.Add(BtnTabelaFuncionarios);
            panelMenu.Controls.Add(BtnFuncionarios);
            panelMenu.Controls.Add(BtnTabelaProdutos);
            panelMenu.Controls.Add(BtnProduto);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 450);
            panelMenu.TabIndex = 0;
            // 
            // BtnConfigurações
            // 
            BtnConfigurações.Dock = DockStyle.Top;
            BtnConfigurações.FlatAppearance.BorderSize = 0;
            BtnConfigurações.FlatStyle = FlatStyle.Flat;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Name = "Form1";
            panelMenu.ResumeLayout(false);
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
    }
}