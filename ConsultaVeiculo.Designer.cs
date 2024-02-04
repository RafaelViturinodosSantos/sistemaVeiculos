
namespace sistemaVeiculos
{
    partial class ConsultaVeiculo
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
            this.nCdVeiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNmVeiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNmMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrizDataSet = new sistemaVeiculos.MatrizDataSet();
            this.veiculoTableAdapter = new sistemaVeiculos.MatrizDataSetTableAdapters.VeiculoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCdVeiculoDataGridViewTextBoxColumn,
            this.cNmVeiculoDataGridViewTextBoxColumn,
            this.cNmMarcaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.veiculoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.Size = new System.Drawing.Size(415, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // nCdVeiculoDataGridViewTextBoxColumn
            // 
            this.nCdVeiculoDataGridViewTextBoxColumn.DataPropertyName = "nCdVeiculo";
            this.nCdVeiculoDataGridViewTextBoxColumn.HeaderText = "nCdVeiculo";
            this.nCdVeiculoDataGridViewTextBoxColumn.Name = "nCdVeiculoDataGridViewTextBoxColumn";
            this.nCdVeiculoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this.matrizDataSet;
            // 
            // matrizDataSet
            // 
            this.matrizDataSet.DataSetName = "MatrizDataSet";
            this.matrizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaVeiculo";
            this.Text = "CadastrarVeiculo";
            this.Load += new System.EventHandler(this.ConsultaVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MatrizDataSet matrizDataSet;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private MatrizDataSetTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCdVeiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNmVeiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNmMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}