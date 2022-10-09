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

        private void UC_Produtos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string conexao = @"Server=localhost;Database=pet_shop;Uid=root;Pwd=''";
            MySqlConnection msconnection = new MySqlConnection(conexao);
            msconnection.Open();
            MySqlCommand mscommand = new MySqlCommand();
            mscommand.CommandText = "select * from cadProdutos";
            mscommand.Connection = msconnection;
            MySqlDataAdapter msdAdapter = new MySqlDataAdapter(mscommand);
            msdAdapter.Fill(dt);
            dgvProdutos.DataSource = dt;
            msconnection.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtMarca.Text == "" || txtValor.Text == "" || txtQtd.Text == "" || txtMedida.Text == "" || txtMarca.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            /*else
            {
                string conexao = @"Server=localhost;Database=pet_shop;Uid=root;Pwd=''";
                MySqlConnection msconnection = new MySqlConnection(conexao);
                msconnection.Open();
                MySqlCommand mscommand = new MySqlCommand();
                mscommand.Connection = msconnection;
                mscommand.CommandText = $"insert into cadprodutos values (0, '{txtNome.Text}', '{txtValor.Text}', '{txtQtd.Text}', '{txtMedida.Text}', '{txtMarca.Text}')";
                mscommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                mscommand.CommandText = "select * from cadProdutos";
                mscommand.Connection = msconnection;
                MySqlDataAdapter msdAdapter = new MySqlDataAdapter(mscommand);
                msdAdapter.Fill(dt);
                dgvProdutos.DataSource = dt;

                msconnection.Close();
            }*/
        }
    }
}
