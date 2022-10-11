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
    public partial class UC_Fornecedores : UserControl
    {
        public UC_Fornecedores()
        {
            InitializeComponent();
        }
        Util util = new Util();
        private void UC_Fornecedores_Load(object sender, EventArgs e)
        {
            util.abrirDgv(dgvFornecedores, "cadfornecedor");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCNPJ.Text == "" || txtProdFornecidos.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "")
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
                mscommand.CommandText = $"INSERT INTO cadfornecedor VALUES " +
                    $"(0, @cnpj, @nome, @prodForn, @endereco, @tel)";
                mscommand.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                mscommand.Parameters.AddWithValue("@nome", txtNome.Text);
                mscommand.Parameters.AddWithValue("@prodForn", txtProdFornecidos.Text);
                mscommand.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                mscommand.Parameters.AddWithValue("@tel", txtTelefone.Text);
                mscommand.Prepare();
                mscommand.ExecuteNonQuery();

                msconnection.Close();
                
                util.abrirDgv(dgvFornecedores, "cadfornecedor");
            }
        }
    }
}
