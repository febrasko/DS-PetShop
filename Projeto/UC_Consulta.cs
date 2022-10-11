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
    public partial class UC_Consulta : UserControl
    {
        public UC_Consulta()
        {
            InitializeComponent();
        }

        private void UC_Consulta_Load(object sender, EventArgs e)
        {
            string conexao = @"Server=localhost;Database=pet_shop;Uid=root;Pwd=''";
            MySqlConnection msconnection = new MySqlConnection(conexao);
            msconnection.Open();

            MySqlCommand mscommand = new MySqlCommand();
            mscommand.CommandText = "select * from cadfuncionarios";
            mscommand.Connection = msconnection;
        }
    }
}
