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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            textBoxPesquisarFuncionario = new TextBox();
            DataTabelaFuncionario = new DataGridView();
            paginaTabelaFuncionarioBindingSource = new BindingSource(components);
            BtnSairTabelaFuncionario = new Button();
            BtnBuscarDados = new Button();
            ((System.ComponentModel.ISupportInitialize)DataTabelaFuncionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paginaTabelaFuncionarioBindingSource).BeginInit();
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
            // DataTabelaFuncionario
            // 
            DataTabelaFuncionario.BackgroundColor = Color.FromArgb(224, 81, 53);
            DataTabelaFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTabelaFuncionario.GridColor = Color.Black;
            DataTabelaFuncionario.Location = new Point(12, 106);
            DataTabelaFuncionario.Name = "DataTabelaFuncionario";
            dataGridViewCellStyle1.ForeColor = Color.Black;
            DataTabelaFuncionario.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DataTabelaFuncionario.RowTemplate.Height = 25;
            DataTabelaFuncionario.Size = new Size(483, 187);
            DataTabelaFuncionario.TabIndex = 5;
            // 
            // paginaTabelaFuncionarioBindingSource
            // 
            paginaTabelaFuncionarioBindingSource.DataSource = typeof(PaginaTabelaFuncionario);
            // 
            // BtnSairTabelaFuncionario
            // 
            BtnSairTabelaFuncionario.FlatStyle = FlatStyle.Flat;
            BtnSairTabelaFuncionario.ForeColor = Color.White;
            BtnSairTabelaFuncionario.Location = new Point(403, 299);
            BtnSairTabelaFuncionario.Name = "BtnSairTabelaFuncionario";
            BtnSairTabelaFuncionario.Size = new Size(92, 33);
            BtnSairTabelaFuncionario.TabIndex = 9;
            BtnSairTabelaFuncionario.Text = "Sair";
            BtnSairTabelaFuncionario.UseVisualStyleBackColor = true;
            BtnSairTabelaFuncionario.Click += BtnSairTabelaFuncionario_Click;
            // 
            // BtnBuscarDados
            // 
            BtnBuscarDados.FlatStyle = FlatStyle.Flat;
            BtnBuscarDados.ForeColor = Color.White;
            BtnBuscarDados.Location = new Point(420, 77);
            BtnBuscarDados.Name = "BtnBuscarDados";
            BtnBuscarDados.Size = new Size(75, 23);
            BtnBuscarDados.TabIndex = 11;
            BtnBuscarDados.Text = "Buscar";
            BtnBuscarDados.UseVisualStyleBackColor = true;
            BtnBuscarDados.Click += BtnBuscarDados_Click;
            // 
            // PaginaTabelaFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 81, 53);
            ClientSize = new Size(499, 357);
            Controls.Add(BtnBuscarDados);
            Controls.Add(BtnSairTabelaFuncionario);
            Controls.Add(textBoxPesquisarFuncionario);
            Controls.Add(DataTabelaFuncionario);
            Name = "PaginaTabelaFuncionario";
            Text = "TabelaFuncionario";
            ((System.ComponentModel.ISupportInitialize)DataTabelaFuncionario).EndInit();
            ((System.ComponentModel.ISupportInitialize)paginaTabelaFuncionarioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPesquisarFuncionario;
        private DataGridView DataTabelaFuncionario;
        private Button button1;
        private Button BtnSairTabelaFuncionario;
        private BindingSource paginaTabelaFuncionarioBindingSource;
        private Button BtnBuscarDados;
    }
}