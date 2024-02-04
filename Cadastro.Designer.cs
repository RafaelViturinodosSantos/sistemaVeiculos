
namespace sistemaVeiculos
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeVeiculo = new System.Windows.Forms.TextBox();
            this.nPreco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.cNmLocadora = new System.Windows.Forms.Label();
            this.txtLocadora = new System.Windows.Forms.TextBox();
            this.cNmEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veículo";
            // 
            // txtNomeVeiculo
            // 
            this.txtNomeVeiculo.Location = new System.Drawing.Point(74, 31);
            this.txtNomeVeiculo.Name = "txtNomeVeiculo";
            this.txtNomeVeiculo.Size = new System.Drawing.Size(250, 20);
            this.txtNomeVeiculo.TabIndex = 2;
            // 
            // nPreco
            // 
            this.nPreco.AutoSize = true;
            this.nPreco.Location = new System.Drawing.Point(12, 91);
            this.nPreco.Name = "nPreco";
            this.nPreco.Size = new System.Drawing.Size(35, 13);
            this.nPreco.TabIndex = 3;
            this.nPreco.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Location = new System.Drawing.Point(484, 31);
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(155, 20);
            this.txtNomeMarca.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(74, 91);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 6;
            // 
            // cNmLocadora
            // 
            this.cNmLocadora.AutoSize = true;
            this.cNmLocadora.Location = new System.Drawing.Point(12, 158);
            this.cNmLocadora.Name = "cNmLocadora";
            this.cNmLocadora.Size = new System.Drawing.Size(52, 13);
            this.cNmLocadora.TabIndex = 7;
            this.cNmLocadora.Text = "Locadora";
            // 
            // txtLocadora
            // 
            this.txtLocadora.Location = new System.Drawing.Point(74, 155);
            this.txtLocadora.Name = "txtLocadora";
            this.txtLocadora.Size = new System.Drawing.Size(250, 20);
            this.txtLocadora.TabIndex = 8;
            // 
            // cNmEndereco
            // 
            this.cNmEndereco.AutoSize = true;
            this.cNmEndereco.Location = new System.Drawing.Point(18, 228);
            this.cNmEndereco.Name = "cNmEndereco";
            this.cNmEndereco.Size = new System.Drawing.Size(53, 13);
            this.cNmEndereco.TabIndex = 9;
            this.cNmEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(74, 228);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(250, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sistema Veículos";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.cNmEndereco);
            this.Controls.Add(this.txtLocadora);
            this.Controls.Add(this.cNmLocadora);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNomeMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nPreco);
            this.Controls.Add(this.txtNomeVeiculo);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeVeiculo;
        private System.Windows.Forms.Label nPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeMarca;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label cNmLocadora;
        private System.Windows.Forms.TextBox txtLocadora;
        private System.Windows.Forms.Label cNmEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

