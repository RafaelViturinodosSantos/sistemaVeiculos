using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVeiculos
{
    public partial class ConsultaVeiculo : Form
    {
        private int idVeiculo = 1;

        public ConsultaVeiculo()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns.Contains("nCdVeiculoDataGridViewTextBoxColumn") && dataGridView1.Columns[e.ColumnIndex].Name == "nCdVeiculoDataGridViewTextBoxColumn")
            {
                idVeiculo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["nCdVeiculoDataGridViewTextBoxColumn"].Value);
            }
 
        }

        private void ConsultaVeiculo_Load(object sender, EventArgs e)
        {        
            this.veiculoTableAdapter.Fill(this.matrizDataSet.Veiculo);

        }

        //Consultar
        private void button1_Click(object sender, EventArgs e)
        {
            Consulta telaConsulta = new Consulta(idVeiculo);
            //telaConsulta.IdVeiculo = idVeiculo;
      
            //Direciona para tela Consulta
            telaConsulta.Show();
            this.Close();
        }

        //Voltar
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
