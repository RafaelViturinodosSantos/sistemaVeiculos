using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sistemaVeiculos
{
    public partial class Cadastro : Form
    {

        private string connectionString = "Data Source=LAPTOP-1OTG8DGU\\SQLEXPRESS;Initial Catalog=Matriz;Integrated Security = True";
        //private string connectionString = "Downloads\\ConnectionString.txt";
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        //Cadastrar
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNomeVeiculo.Text) || string.IsNullOrEmpty(txtNomeMarca.Text) || string.IsNullOrEmpty(txtPreco.Text) || string.IsNullOrEmpty(txtLocadora.Text) || string.IsNullOrEmpty(txtEndereco.Text))
                {
                    MessageBox.Show("É necessário preencher todos os campos para o cadastro!");
                    return;
                }
                string nomeVeiculo = txtNomeVeiculo.Text;
                string nomeMarca = txtNomeMarca.Text;
                decimal nPrecoVeiculo = Convert.ToDecimal(txtPreco.Text);
                string nomeLocadora = txtLocadora.Text;
                string nomeEndereco = txtEndereco.Text;

                //DateTime dCadastro = DateTime.Now;

                //string sql = "INSERT INTO dbo.Veiculo (cNmVeiculo, cNmMarca, nPreco, cNmLocadora, cEndereco, dCadastroVeiculo) VALUES (@NomeVeiculo, @NomeMarca, @Preco, @NomeLocadora, @NmEndereco, @dCadastroVeiculo)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("CadastraVeiculo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AcNmVeiculo", nomeVeiculo);
                        command.Parameters.AddWithValue("@AcNmMarca", nomeMarca);
                        command.Parameters.AddWithValue("@AnPreco", nPrecoVeiculo);
                        command.Parameters.AddWithValue("@AcNmLocadora", nomeLocadora);
                        command.Parameters.AddWithValue("@AcNmEndereco", nomeEndereco);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Veículo Cadastrado com Sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Cadastrar o Veículo!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar processar ! {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SistemaVeiculo sistemaVeiculo = new SistemaVeiculo();
            sistemaVeiculo.Show();
            this.Close();
        }

    }
}
