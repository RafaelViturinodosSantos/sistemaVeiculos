
namespace sistemaVeiculos
{
    partial class ConsultarVeiculo
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
            this.matrizDataSet = new sistemaVeiculos.MatrizDataSet();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoTableAdapter = new sistemaVeiculos.MatrizDataSetTableAdapters.VeiculoTableAdapter();
            this.cNmMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNmVeiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCdVeiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // matrizDataSet
            // 
            this.matrizDataSet.DataSetName = "MatrizDataSet";
            this.matrizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this.matrizDataSet;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // cNmMarcaDataGridViewTextBoxColumn
            // 
            this.cNmMarcaDataGridViewTextBoxColumn.DataPropertyName = "cNmMarca";
            this.cNmMarcaDataGridViewTextBoxColumn.HeaderText = "cNmMarca";
            this.cNmMarcaDataGridViewTextBoxColumn.Name = "cNmMarcaDataGridViewTextBoxColumn";
            // 
            // cNmVeiculoDataGridViewTextBoxColumn
            // 
            this.cNmVeiculoDataGridViewTextBoxColumn.DataPropertyName = "cNmVeiculo";
            this.cNmVeiculoDataGridViewTextBoxColumn.HeaderText = "cNmVeiculo";
            this.cNmVeiculoDataGridViewTextBoxColumn.Name = "cNmVeiculoDataGridViewTextBoxColumn";
            // 
            // nCdVeiculoDataGridViewTextBoxColumn
            // 
            this.nCdVeiculoDataGridViewTextBoxColumn.DataPropertyName = "nCdVeiculo";
            this.nCdVeiculoDataGridViewTextBoxColumn.HeaderText = "nCdVeiculo";
            this.nCdVeiculoDataGridViewTextBoxColumn.Name = "nCdVeiculoDataGridViewTextBoxColumn";
            this.nCdVeiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCdVeiculoDataGridViewTextBoxColumn,
            this.cNmVeiculoDataGridViewTextBoxColumn,
            this.cNmMarcaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.veiculoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 113);
            this.dataGridView1.TabIndex = 0;
            // 
            // ConsultarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 162);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarVeiculo";
            this.Text = "Consultar Veiculo";
            this.Load += new System.EventHandler(this.ConsultarVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MatrizDataSet matrizDataSet;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private MatrizDataSetTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNmMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNmVeiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCdVeiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}