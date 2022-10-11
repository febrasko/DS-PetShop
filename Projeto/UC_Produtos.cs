using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PetShop
{
    public partial class UC_Produtos : UserControl
    {
        public UC_Produtos()
        {
            InitializeComponent();
        }
        Util util = new Util();
        private void UC_Produtos_Load(object sender, EventArgs e)
        {
            util.abrirDgv(dgvProdutos, "cadprodutos");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtMarca.Text == "" || txtValor.Text == "" || txtQtd.Text == "" || txtMedida.Text == "" || txtMarca.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                string conexao = @"Server=localhost;Database=pet_shop;Uid=root;Pwd=''";
                MySqlConnection msconnection = new MySqlConnection(conexao);
                msconnection.Open();

                MySqlCommand mscommand = new MySqlCommand();
                mscommand.Connection = msconnection;
                mscommand.CommandText = $"INSERT INTO cadprodutos " +
                    $"(nmProd, valor, Qtd, undMedida, marca) VALUES " +
                    $"(@nome, @valor, @qtd, @medida, @marca)";
                mscommand.Parameters.AddWithValue("@nome", txtNome.Text);
                mscommand.Parameters.AddWithValue("@valor", txtValor.Text);
                mscommand.Parameters.AddWithValue("@qtd", txtQtd.Text);
                mscommand.Parameters.AddWithValue("@medida", txtMedida.Text);
                mscommand.Parameters.AddWithValue("@marca", txtMarca.Text);
                mscommand.Prepare();
                mscommand.ExecuteNonQuery();

                msconnection.Close();

                util.abrirDgv(dgvProdutos, "cadprodutos");
            }
        }
    }
}
