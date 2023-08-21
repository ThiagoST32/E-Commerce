namespace E_Commerce.Paginas
{
    partial class PaginaTabelaProdutos
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
            components = new System.ComponentModel.Container();
            TxtBoxPesquisarProdutos = new TextBox();
            BtnSairTabelaFuncionario = new Button();
            DataGridTabelaProdutos = new DataGridView();
            mySqlConnectionBindingSource = new BindingSource(components);
            BtnBuscarDados = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridTabelaProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mySqlConnectionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TxtBoxPesquisarProdutos
            // 
            TxtBoxPesquisarProdutos.Location = new Point(12, 56);
            TxtBoxPesquisarProdutos.Name = "TxtBoxPesquisarProdutos";
            TxtBoxPesquisarProdutos.PlaceholderText = "Pesquisar Produto";
            TxtBoxPesquisarProdutos.Size = new Size(406, 23);
            TxtBoxPesquisarProdutos.TabIndex = 4;
            // 
            // BtnSairTabelaFuncionario
            // 
            BtnSairTabelaFuncionario.FlatStyle = FlatStyle.Flat;
            BtnSairTabelaFuncionario.ForeColor = Color.White;
            BtnSairTabelaFuncionario.Location = new Point(403, 278);
            BtnSairTabelaFuncionario.Name = "BtnSairTabelaFuncionario";
            BtnSairTabelaFuncionario.Size = new Size(92, 33);
            BtnSairTabelaFuncionario.TabIndex = 8;
            BtnSairTabelaFuncionario.Text = "Sair";
            BtnSairTabelaFuncionario.UseVisualStyleBackColor = true;
            BtnSairTabelaFuncionario.Click += BtnSairTabelaFuncionario_Click;
            // 
            // DataGridTabelaProdutos
            // 
            DataGridTabelaProdutos.BackgroundColor = Color.FromArgb(224, 81, 53);
            DataGridTabelaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridTabelaProdutos.GridColor = Color.White;
            DataGridTabelaProdutos.Location = new Point(12, 85);
            DataGridTabelaProdutos.Name = "DataGridTabelaProdutos";
            DataGridTabelaProdutos.RowTemplate.Height = 25;
            DataGridTabelaProdutos.Size = new Size(483, 187);
            DataGridTabelaProdutos.TabIndex = 9;
            // 
            // mySqlConnectionBindingSource
            // 
            mySqlConnectionBindingSource.DataSource = typeof(MySql.Data.MySqlClient.MySqlConnection);
            // 
            // BtnBuscarDados
            // 
            BtnBuscarDados.FlatStyle = FlatStyle.Flat;
            BtnBuscarDados.ForeColor = Color.White;
            BtnBuscarDados.Location = new Point(420, 56);
            BtnBuscarDados.Name = "BtnBuscarDados";
            BtnBuscarDados.Size = new Size(75, 23);
            BtnBuscarDados.TabIndex = 10;
            BtnBuscarDados.Text = "Buscar";
            BtnBuscarDados.UseVisualStyleBackColor = true;
            BtnBuscarDados.Click += BtnBuscarDados_Click;
            // 
            // PaginaTabelaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 81, 53);
            ClientSize = new Size(507, 336);
            Controls.Add(BtnBuscarDados);
            Controls.Add(DataGridTabelaProdutos);
            Controls.Add(BtnSairTabelaFuncionario);
            Controls.Add(TxtBoxPesquisarProdutos);
            Name = "PaginaTabelaProdutos";
            Text = "PaginaTabelaProdutos";
            ((System.ComponentModel.ISupportInitialize)DataGridTabelaProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)mySqlConnectionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnEditarProduto;
        private Button BtnExcluirProdutos;
        private TextBox textBoxPesquisarProdutos;
        private Button BtnExcluirFuncionario;
        private Button BtnSairTabelaFuncionario;
        private TextBox TxtBoxPesquisarProdutos;
        private DataGridView DataGridTabelaProdutos;
        private BindingSource mySqlConnectionBindingSource;
        private Button BtnBuscarDados;
    }
}