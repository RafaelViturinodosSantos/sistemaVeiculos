
namespace sistemaVeiculos
{
    partial class Listagem
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matrizDataSet1 = new sistemaVeiculos.MatrizDataSet1();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoTableAdapter = new sistemaVeiculos.MatrizDataSet1TableAdapters.VeiculoTableAdapter();
            this.cNmVeiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNmMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPrecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNmLocadoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCadastroVeiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNmVeiculoDataGridViewTextBoxColumn,
            this.cNmMarcaDataGridViewTextBoxColumn,
            this.nPrecoDataGridViewTextBoxColumn,
            this.cNmLocadoraDataGridViewTextBoxColumn,
            this.cEnderecoDataGridViewTextBoxColumn,
            this.dCadastroVeiculoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.veiculoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // matrizDataSet1
            // 
            this.matrizDataSet1.DataSetName = "MatrizDataSet1";
            this.matrizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this.matrizDataSet1;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // cNmVeiculoDataGridViewTextBoxColumn
            // 
            this.cNmVeiculoDataGridViewTextBoxColumn.DataPropertyName = "cNmVeiculo";
            this.cNmVeiculoDataGridViewTextBoxColumn.HeaderText = "cNmVeiculo";
            this.cNmVeiculoDataGridViewTextBoxColumn.Name = "cNmVeiculoDataGridViewTextBoxColumn";
            // 
            // cNmMarcaDataGridViewTextBoxColumn
            // 
            this.cNmMarcaDataGridViewTextBoxColumn.DataPropertyName = "cNmMarca";
            this.cNmMarcaDataGridViewTextBoxColumn.HeaderText = "cNmMarca";
            this.cNmMarcaDataGridViewTextBoxColumn.Name = "cNmMarcaDataGridViewTextBoxColumn";
            // 
            // nPrecoDataGridViewTextBoxColumn
            // 
            this.nPrecoDataGridViewTextBoxColumn.DataPropertyName = "nPreco";
            this.nPrecoDataGridViewTextBoxColumn.HeaderText = "nPreco";
            this.nPrecoDataGridViewTextBoxColumn.Name = "nPrecoDataGridViewTextBoxColumn";
            // 
            // cNmLocadoraDataGridViewTextBoxColumn
            // 
            this.cNmLocadoraDataGridViewTextBoxColumn.DataPropertyName = "cNmLocadora";
            this.cNmLocadoraDataGridViewTextBoxColumn.HeaderText = "cNmLocadora";
            this.cNmLocadoraDataGridViewTextBoxColumn.Name = "cNmLocadoraDataGridViewTextBoxColumn";
            // 
            // cEnderecoDataGridViewTextBoxColumn
            // 
            this.cEnderecoDataGridViewTextBoxColumn.DataPropertyName = "cEndereco";
            this.cEnderecoDataGridViewTextBoxColumn.HeaderText = "cEndereco";
            this.cEnderecoDataGridViewTextBoxColumn.Name = "cEnderecoDataGridViewTextBoxColumn";
            // 
            // dCadastroVeiculoDataGridViewTextBoxColumn
            // 
            this.dCadastroVeiculoDataGridViewTextBoxColumn.DataPropertyName = "dCadastroVeiculo";
            this.dCadastroVeiculoDataGridViewTextBoxColumn.HeaderText = "dCadastroVeiculo";
            this.dCadastroVeiculoDataGridViewTextBoxColumn.Name = "dCadastroVeiculoDataGridViewTextBoxColumn";
            // 
            // Listagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 350);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listagem";
            this.Text = "Listagem";
            this.Load += new System.EventHandler(this.Listagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MatrizDataSet1 matrizDataSet1;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private MatrizDataSet1TableAdapters.VeiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNmVeiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNmMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPrecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNmLocadoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCadastroVeiculoDataGridViewTextBoxColumn;
    }
}