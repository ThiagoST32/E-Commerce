namespace E_Commerce.Paginas
{
    partial class PaginaTabelaFuncionario
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
            textBoxPesquisarFuncionario = new TextBox();
            BtnExcluirFuncionario = new Button();
            BtnEditarFuncionario = new Button();
            DataTabelaFuncionario = new DataGridView();
            BtnSairTabelaFuncionario = new Button();
            ((System.ComponentModel.ISupportInitialize)DataTabelaFuncionario).BeginInit();
            SuspendLayout();
            // 
            // textBoxPesquisarFuncionario
            // 
            textBoxPesquisarFuncionario.Location = new Point(12, 77);
            textBoxPesquisarFuncionario.Name = "textBoxPesquisarFuncionario";
            textBoxPesquisarFuncionario.PlaceholderText = "Pesquisar Funcionario";
            textBoxPesquisarFuncionario.Size = new Size(406, 23);
            textBoxPesquisarFuncionario.TabIndex = 8;
            // 
            // BtnExcluirFuncionario
            // 
            BtnExcluirFuncionario.FlatStyle = FlatStyle.Flat;
            BtnExcluirFuncionario.ForeColor = Color.White;
            BtnExcluirFuncionario.Location = new Point(403, 299);
            BtnExcluirFuncionario.Name = "BtnExcluirFuncionario";
            BtnExcluirFuncionario.Size = new Size(92, 33);
            BtnExcluirFuncionario.TabIndex = 7;
            BtnExcluirFuncionario.Text = "Excluir";
            BtnExcluirFuncionario.UseVisualStyleBackColor = true;
            // 
            // BtnEditarFuncionario
            // 
            BtnEditarFuncionario.FlatStyle = FlatStyle.Flat;
            BtnEditarFuncionario.ForeColor = Color.White;
            BtnEditarFuncionario.Location = new Point(295, 299);
            BtnEditarFuncionario.Name = "BtnEditarFuncionario";
            BtnEditarFuncionario.Size = new Size(92, 33);
            BtnEditarFuncionario.TabIndex = 6;
            BtnEditarFuncionario.Text = "Editar";
            BtnEditarFuncionario.UseVisualStyleBackColor = true;
            // 
            // DataTabelaFuncionario
            // 
            DataTabelaFuncionario.BackgroundColor = Color.FromArgb(224, 81, 53);
            DataTabelaFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTabelaFuncionario.GridColor = Color.White;
            DataTabelaFuncionario.Location = new Point(12, 106);
            DataTabelaFuncionario.Name = "DataTabelaFuncionario";
            dataGridViewCellStyle1.ForeColor = Color.White;
            DataTabelaFuncionario.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DataTabelaFuncionario.RowTemplate.Height = 25;
            DataTabelaFuncionario.Size = new Size(483, 187);
            DataTabelaFuncionario.TabIndex = 5;
            // 
            // BtnSairTabelaFuncionario
            // 
            BtnSairTabelaFuncionario.FlatStyle = FlatStyle.Flat;
            BtnSairTabelaFuncionario.ForeColor = Color.White;
            BtnSairTabelaFuncionario.Location = new Point(197, 299);
            BtnSairTabelaFuncionario.Name = "BtnSairTabelaFuncionario";
            BtnSairTabelaFuncionario.Size = new Size(92, 33);
            BtnSairTabelaFuncionario.TabIndex = 9;
            BtnSairTabelaFuncionario.Text = "Sair";
            BtnSairTabelaFuncionario.UseVisualStyleBackColor = true;
            // 
            // PaginaTabelaFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 81, 53);
            ClientSize = new Size(503, 343);
            Controls.Add(BtnSairTabelaFuncionario);
            Controls.Add(textBoxPesquisarFuncionario);
            Controls.Add(BtnExcluirFuncionario);
            Controls.Add(BtnEditarFuncionario);
            Controls.Add(DataTabelaFuncionario);
            Name = "PaginaTabelaFuncionario";
            Text = "TabelaFuncionario";
            ((System.ComponentModel.ISupportInitialize)DataTabelaFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPesquisarFuncionario;
        private Button BtnExcluirFuncionario;
        private Button BtnEditarFuncionario;
        private DataGridView DataTabelaFuncionario;
        private Button button1;
        private Button BtnSairTabelaFuncionario;
    }
}