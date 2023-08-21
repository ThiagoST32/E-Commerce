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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataTabelaProdutos = new DataGridView();
            BtnEditarProduto = new Button();
            BtnExcluirProdutos = new Button();
            textBoxPesquisarProdutos = new TextBox();
            BtnSairTabelaFuncionario = new Button();
            ((System.ComponentModel.ISupportInitialize)DataTabelaProdutos).BeginInit();
            SuspendLayout();
            // 
            // DataTabelaProdutos
            // 
            DataTabelaProdutos.BackgroundColor = Color.FromArgb(224, 81, 53);
            DataTabelaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTabelaProdutos.GridColor = Color.White;
            DataTabelaProdutos.Location = new Point(12, 85);
            DataTabelaProdutos.Name = "DataTabelaProdutos";
            dataGridViewCellStyle1.ForeColor = Color.White;
            DataTabelaProdutos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DataTabelaProdutos.RowTemplate.Height = 25;
            DataTabelaProdutos.Size = new Size(483, 187);
            DataTabelaProdutos.TabIndex = 0;
            // 
            // BtnEditarProduto
            // 
            BtnEditarProduto.FlatStyle = FlatStyle.Flat;
            BtnEditarProduto.ForeColor = Color.White;
            BtnEditarProduto.Location = new Point(295, 278);
            BtnEditarProduto.Name = "BtnEditarProduto";
            BtnEditarProduto.Size = new Size(92, 33);
            BtnEditarProduto.TabIndex = 2;
            BtnEditarProduto.Text = "Editar";
            BtnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // BtnExcluirProdutos
            // 
            BtnExcluirProdutos.FlatStyle = FlatStyle.Flat;
            BtnExcluirProdutos.ForeColor = Color.White;
            BtnExcluirProdutos.Location = new Point(403, 278);
            BtnExcluirProdutos.Name = "BtnExcluirProdutos";
            BtnExcluirProdutos.Size = new Size(92, 33);
            BtnExcluirProdutos.TabIndex = 3;
            BtnExcluirProdutos.Text = "Excluir";
            BtnExcluirProdutos.UseVisualStyleBackColor = true;
            // 
            // textBoxPesquisarProdutos
            // 
            textBoxPesquisarProdutos.Location = new Point(12, 56);
            textBoxPesquisarProdutos.Name = "textBoxPesquisarProdutos";
            textBoxPesquisarProdutos.PlaceholderText = "Pesquisar Produto";
            textBoxPesquisarProdutos.Size = new Size(406, 23);
            textBoxPesquisarProdutos.TabIndex = 4;
            // 
            // BtnSairTabelaFuncionario
            // 
            BtnSairTabelaFuncionario.FlatStyle = FlatStyle.Flat;
            BtnSairTabelaFuncionario.ForeColor = Color.White;
            BtnSairTabelaFuncionario.Location = new Point(185, 278);
            BtnSairTabelaFuncionario.Name = "BtnSairTabelaFuncionario";
            BtnSairTabelaFuncionario.Size = new Size(92, 33);
            BtnSairTabelaFuncionario.TabIndex = 8;
            BtnSairTabelaFuncionario.Text = "Sair";
            BtnSairTabelaFuncionario.UseVisualStyleBackColor = true;
            // 
            // PaginaTabelaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 81, 53);
            ClientSize = new Size(507, 336);
            Controls.Add(BtnSairTabelaFuncionario);
            Controls.Add(textBoxPesquisarProdutos);
            Controls.Add(BtnExcluirProdutos);
            Controls.Add(BtnEditarProduto);
            Controls.Add(DataTabelaProdutos);
            Name = "PaginaTabelaProdutos";
            Text = "PaginaTabelaProdutos";
            ((System.ComponentModel.ISupportInitialize)DataTabelaProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataTabelaProdutos;
        private Button BtnEditarProduto;
        private Button BtnExcluirProdutos;
        private TextBox textBoxPesquisarProdutos;
        private Button BtnExcluirFuncionario;
        private Button BtnSairTabelaFuncionario;
    }
}