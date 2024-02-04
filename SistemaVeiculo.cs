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
    public partial class SistemaVeiculo : Form
    {
        public SistemaVeiculo()
        {
            InitializeComponent();
        }

        //Cadastro
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
            
        }

        //Exclusão
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirConsultarVeiculo();
        }

        //Atualização
        private void button4_Click(object sender, EventArgs e)
        {
            AbrirConsultarVeiculo();
        }

        //Consulta
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirConsultarVeiculo();
           // this.Close();
        }

        private void AbrirCadastro()
        {
            Cadastro cadastroTela = new Cadastro();
            //this.Close();
            cadastroTela.Show();
            

        }
        private void AbrirConsulta()
        {
            Consulta consultaTela = new Consulta();
            //this.Close();
            consultaTela.Show();            
            
        }

        private void AbrirConsultarVeiculo()
        {
            ConsultaVeiculo consultarVeiculoTela = new ConsultaVeiculo();
            //this.Close();
            consultarVeiculoTela.Show();
       

        }

        //Listagem
        private void button5_Click(object sender, EventArgs e)
        {
            Listagem listagemVeiculoTela = new Listagem();
            listagemVeiculoTela.Show();

        }
    }
}
