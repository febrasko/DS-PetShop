﻿using System;
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

        private void UC_Agenda_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string conexao = @"Server=localhost;Database=pet_shop;Uid=root;Pwd=''";
            MySqlConnection msconnection = new MySqlConnection(conexao);
            msconnection.Open();
            MySqlCommand mscommand = new MySqlCommand();
            mscommand.CommandText = "select * from agendamento";
            mscommand.Connection = msconnection;
            MySqlDataAdapter msdAdapter = new MySqlDataAdapter(mscommand);
            msdAdapter.Fill(dt);
            dgvAgenda.DataSource = dt;
        }
    }
}