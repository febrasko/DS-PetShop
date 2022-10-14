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
    public partial class UC_Agenda : UserControl
    {
        public UC_Agenda()
        {
            InitializeComponent();
        }
        Util util = new Util(); 
        private void UC_Agenda_Load(object sender, EventArgs e)
        {
            util.abrirDgv(dgvAgenda, "agendamento");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNomeResp.Text == "" || txtNomeAnimal.Text == "" || cbTipo.Text == "" || dtpData.Text == "" || txtObs.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                string data = dtpData.Value.ToString("yyyy-MM-dd");

                string conexao = @"Server=localhost;Database=pet_shop;Uid=root;Pwd=''";
                MySqlConnection msconnection = new MySqlConnection(conexao);
                msconnection.Open();

                MySqlCommand mscommand = new MySqlCommand();
                mscommand.Connection = msconnection;
                mscommand.CommandText = $"INSERT INTO agendamento VALUES " +
                    $"(0, @nomeres, @nomeanimal, @tipo, @data, @obs)";
                mscommand.Parameters.AddWithValue("@nomeres", txtNomeResp.Text);
                mscommand.Parameters.AddWithValue("@nomeanimal", txtNomeAnimal.Text);
                mscommand.Parameters.AddWithValue("@tipo", cbTipo.Text);
                mscommand.Parameters.AddWithValue("@data", data);
                mscommand.Parameters.AddWithValue("@obs", txtObs.Text);
                mscommand.Prepare();
                mscommand.ExecuteNonQuery();

                util.abrirDgv(dgvAgenda, "agendamento");

                msconnection.Close();
            }
        }
    }
}
