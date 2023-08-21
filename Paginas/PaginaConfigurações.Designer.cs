namespace E_Commerce.Paginas
{
    partial class PaginaConfigurações
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFundoConfiguracao = new Panel();
            BtnHomeConfiguração = new Button();
            BtnSairConfiguração = new Button();
            BtnTesteBancoConfiguracao = new Button();
            panelFundoConfiguracao.SuspendLayout();
            SuspendLayout();
            // 
            // panelFundoConfiguracao
            // 
            panelFundoConfiguracao.Controls.Add(BtnHomeConfiguração);
            panelFundoConfiguracao.Controls.Add(BtnSairConfiguração);
            panelFundoConfiguracao.Controls.Add(BtnTesteBancoConfiguracao);
            panelFundoConfiguracao.Dock = DockStyle.Fill;
            panelFundoConfiguracao.Location = new Point(0, 0);
            panelFundoConfiguracao.Name = "panelFundoConfiguracao";
            panelFundoConfiguracao.Size = new Size(507, 336);
            panelFundoConfiguracao.TabIndex = 4;
            // 
            // BtnHomeConfiguração
            // 
            BtnHomeConfiguração.FlatStyle = FlatStyle.Flat;
            BtnHomeConfiguração.ForeColor = Color.White;
            BtnHomeConfiguração.Location = new Point(12, 222);
            BtnHomeConfiguração.Name = "BtnHomeConfiguração";
            BtnHomeConfiguração.Size = new Size(116, 42);
            BtnHomeConfiguração.TabIndex = 6;
            BtnHomeConfiguração.Text = "Home";
            BtnHomeConfiguração.UseVisualStyleBackColor = true;
            // 
            // BtnSairConfiguração
            // 
            BtnSairConfiguração.FlatStyle = FlatStyle.Flat;
            BtnSairConfiguração.ForeColor = Color.White;
            BtnSairConfiguração.Location = new Point(12, 270);
            BtnSairConfiguração.Name = "BtnSairConfiguração";
            BtnSairConfiguração.Size = new Size(116, 42);
            BtnSairConfiguração.TabIndex = 5;
            BtnSairConfiguração.Text = "Sair";
            BtnSairConfiguração.UseVisualStyleBackColor = true;
            // 
            // BtnTesteBancoConfiguracao
            // 
            BtnTesteBancoConfiguracao.FlatStyle = FlatStyle.Flat;
            BtnTesteBancoConfiguracao.ForeColor = Color.White;
            BtnTesteBancoConfiguracao.Location = new Point(12, 174);
            BtnTesteBancoConfiguracao.Name = "BtnTesteBancoConfiguracao";
            BtnTesteBancoConfiguracao.Size = new Size(116, 42);
            BtnTesteBancoConfiguracao.TabIndex = 4;
            BtnTesteBancoConfiguracao.Text = "Testar Conexão Banco";
            BtnTesteBancoConfiguracao.UseVisualStyleBackColor = true;
            BtnTesteBancoConfiguracao.Click += BtnTesteBancoConfiguracao_Click;
            // 
            // PaginaConfigurações
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 81, 53);
            ClientSize = new Size(507, 336);
            Controls.Add(panelFundoConfiguracao);
            Name = "PaginaConfigurações";
            Text = "PaginaConfigurações";
            panelFundoConfiguracao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button BtnHomeConfiguração;
        private Panel panelFundoConfiguracao;
        private Button BtnTesteBancoConfiguracao;
        private Button BtnSairConfiguração;
    }
}