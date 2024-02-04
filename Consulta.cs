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
    public partial class Consulta : Form
    {
        public int IdVeiculo { get; set; }
        private string connectionString = "Data Source=LAPTOP-1OTG8DGU\\SQLEXPRESS;Initial Catalog=Matriz;Integrated Security = True";
        //private string connectionString = "Downloads\\ConnectionString.txt";

        public Consulta(int idVeiculo)
        {
            this.IdVeiculo = idVeiculo;
            InitializeComponent();
            CarregaConsulta();
        }

        public Consulta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                decimal nCdVeiculo = Convert.ToDecimal(txtCdVeiculo.Text);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ExcluiVeiculo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AnCdVeiculo", nCdVeiculo);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Exclusão de Veículo Feita Com Sucesso!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Excluir o Cadastro do Veículo!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar processar ! {ex.Message}");
            }                          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregaConsulta();
        }

        private void CarregaConsulta()
        {
            try
            {
                decimal nCdVeiculo = Convert.ToDecimal(IdVeiculo);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ConsultaVeiculo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AnCdVeiculo", nCdVeiculo);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet dsVeiculo = new DataSet();
                            adapter.Fill(dsVeiculo, "ConsultaVeiculo");
                            DataTable dtVeiculo = dsVeiculo.Tables["ConsultaVeiculo"];

                            if (dtVeiculo.Rows.Count > 0)
                            {
                                txtNomeVeiculo.Text = dtVeiculo.Rows[0]["cNmVeiculo"].ToString();
                                txtCdVeiculo.Text = dtVeiculo.Rows[0]["nCdVeiculo"].ToString();
                                txtNomeMarca.Text = dtVeiculo.Rows[0]["cNmMarca"].ToString();
                                txtPreco.Text = dtVeiculo.Rows[0]["nPreco"].ToString();
                                txtLocadora.Text = dtVeiculo.Rows[0]["cNmLocadora"].ToString();
                                txtEndereco.Text = dtVeiculo.Rows[0]["cEndereco"].ToString();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNomeVeiculo.Text) || string.IsNullOrEmpty(txtNomeMarca.Text) || string.IsNullOrEmpty(txtPreco.Text) || string.IsNullOrEmpty(txtLocadora.Text) || string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("É necessário preencher todos os campos para o cadastro!");
                return;
            }
            decimal nCdVeiculo = Convert.ToDecimal(txtCdVeiculo.Text);
            string nomeVeiculo = txtNomeVeiculo.Text;
            string nomeMarca = txtNomeMarca.Text;
            decimal nPrecoVeiculo = Convert.ToDecimal(txtPreco.Text);
            string nomeLocadora = txtLocadora.Text;
            string nomeEndereco = txtEndereco.Text;
;

            //string sql = "UPDATE dbo.Veiculo " +
            //    "            SET cNmVeiculo  = @NomeVeiculo" +
            //    "              , cNmMarca    = @NomeMarca" +
            //    "              , nPreco      = @Preco" +
            //    "              , cNmLocadora = @NomeLocadora" +
            //    "              , cEndereco   = @NmEndereco" +
            //    "          WHERE nCdVeiculo = @AnCdVeiculo";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AtualizaVeiculo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AnCdVeiculo", nCdVeiculo);
                    command.Parameters.AddWithValue("@AcNomeVeiculo", nomeVeiculo);
                    command.Parameters.AddWithValue("@AcNomeMarca", nomeMarca);
                    command.Parameters.AddWithValue("@AnPreco", nPrecoVeiculo);
                    command.Parameters.AddWithValue("@AcNomeLocadora", nomeLocadora);
                    command.Parameters.AddWithValue("@AcNmEndereco", nomeEndereco);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cadastro Atualizado Com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha na Alteração.");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SistemaVeiculo sistemaVeiculo = new SistemaVeiculo();
            sistemaVeiculo.Show();
            this.Close();
        }
    }
}
