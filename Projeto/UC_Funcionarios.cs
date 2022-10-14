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
    public partial class UC_Funcionarios : UserControl
    {
        public UC_Funcionarios()
        {
            InitializeComponent();
        }
        Util util = new Util();
        private void UC_Funcionarios_Load(object sender, EventArgs e)
        {
            util.abrirDgv(dgvFuncionarios, "cadfuncionarios");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCPF.Text == "" || dtpNascimento.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                // Convertendo a data inserida para o formato do MySQL
                string nascimento = dtpNascimento.Value.ToString("yyyy-MM-dd");

                // Abrindo conexão
                string conexao = @"Server=localhost;Database=pet_shop;Uid=root;Pwd=''";
                MySqlConnection msconnection = new MySqlConnection(conexao);
                msconnection.Open();

                // Executando comando insert
                MySqlCommand mscommand = new MySqlCommand();
                mscommand.Connection = msconnection;
                mscommand.CommandText = $"INSERT INTO cadfuncionarios " +
                    $"(nmFunc, dtNascimento, cpf, endereco, tel) VALUES " +
                    $"(@nome, @nascimento, @cpf, @endereco, @tel)";
                mscommand.Parameters.AddWithValue("@nome", txtNome.Text);
                mscommand.Parameters.AddWithValue("@cpf", txtCPF.Text);
                mscommand.Parameters.AddWithValue("@nascimento", nascimento);
                mscommand.Parameters.AddWithValue("@tel", txtTelefone.Text);
                mscommand.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                mscommand.Prepare();
                mscommand.ExecuteNonQuery();
                
                // Fechando conexão
                msconnection.Close();

                // Atualizando datagridview
                util.abrirDgv(dgvFuncionarios, "cadfuncionarios");
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string conexao = @"Server=localhost;Database=pet_shop;Uid=root;Pwd=''";
            MySqlConnection msconnection = new MySqlConnection(conexao);
            msconnection.Open();
            MySqlCommand mscommand = new MySqlCommand();
            DataTable dt = new DataTable();
            mscommand.CommandText = "select * from cadfuncionarios where nmFunc LIKE '%" + txtPesquisa.Text + "%'";
            mscommand.Connection = msconnection;
            MySqlDataAdapter msdAdapter = new MySqlDataAdapter(mscommand);
            msdAdapter.Fill(dt);
            dgvFuncionarios.DataSource = dt;
        }
    }
}
