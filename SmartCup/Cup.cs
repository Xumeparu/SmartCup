﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Timer = System.Timers.Timer;
using System.Timers;

namespace SmartCup
{
    public partial class Cup : Form
    {
        public static string strConn = @"Data Source=LAPTOP-NBAIPN8N\SQLEXPRESS;Initial Catalog=SmartCup;Integrated Security=True";

        DateTime t1, t2; // time counter test
        private bool buttonWasClicked = false;

        public Cup()
        {
            InitializeComponent();
            DisplayData();

            timer.Interval = 1000;
            timer.Start();
            t1 = DateTime.Now;
        }

        private void drinksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drinksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.smartCupDataSet);
        }

        private void Cup_Load(object sender, EventArgs e)
        {
            this.drinksTableAdapter.Fill(this.smartCupDataSet.Drinks);
        }

        // Display of drinks table //
        private void DisplayData()
        {
            string sql = "SELECT Name AS Name, Value AS Value FROM Drinks";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dataTable);
                drinksDataGridView.DataSource = dataTable;

                conn.Close();
            }
        }

        // For SQL requests //
        private void SQLRequest(string sqlRequest)
        {
            string sql = sqlRequest;

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();

                conn.Close();
                DisplayData();
            }
        }

        // Compote // temp = 0
        private void getCompote_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;

            string sql = "UPDATE Drinks SET Value = Value - 250 WHERE Name = 'Компот' AND Value > 0";
            SQLRequest(sql);
        }

        // Tea // temp = 70
        private void getTea_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;

            string sql = "UPDATE Drinks SET Value = Value - 250 WHERE Name = 'Чай' AND Value > 0";
            SQLRequest(sql);
        }

        // Coffee // temp = 90
        private void getCoffee_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;

            string sql = "UPDATE Drinks SET Value = Value - 250 WHERE Name = 'Кофе' AND Value > 0";
            SQLRequest(sql);
        }

        // Water // temp = 20
        private void getWater_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;

            string sql = "UPDATE Drinks SET Value = Value - 250 WHERE Name = 'Вода' AND Value > 0";
            SQLRequest(sql);
        }

        // Replenish Stock //
        private void replenishStock_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Drinks SET Value = 1000 WHERE Value < 1000";
            SQLRequest(sql);
        }

        // Time counter test //
        private void timer_Tick(object sender, EventArgs e)
        {
            t2 = DateTime.Now;
            TimeSpan ts = t2 - t1;
            time.Text = ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString();

            int hour = 3600;

            buttonWasClicked = true;

            if (buttonWasClicked)
            {
                int temp = 50;
                temperature.Text = temp.ToString();

                for (int i = 0; i <= hour; i++) 
                {
                    temp -= 1;
                    temperature.Text = temp.ToString();
                }
            }
        }

        // Updating the database by clicking on a specific cell //
        private void drinksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql;

            if (drinksDataGridView.CurrentCell.Value.ToString() == "Компот")
            {
                sql = "UPDATE Drinks SET Value = Value - 250 WHERE Name = 'Компот' AND Value > 0";
                SQLRequest(sql);
            }

            if (drinksDataGridView.CurrentCell.Value.ToString() == "Чай")
            {
                sql = "UPDATE Drinks SET Value = Value - 250 WHERE Name = 'Чай' AND Value > 0";
                SQLRequest(sql);
            }

            if (drinksDataGridView.CurrentCell.Value.ToString() == "Кофе")
            {
                sql = "UPDATE Drinks SET Value = Value - 250 WHERE Name = 'Кофе' AND Value > 0";
                SQLRequest(sql);
            }

            if (drinksDataGridView.CurrentCell.Value.ToString() == "Вода")
            {
                sql = "UPDATE Drinks SET Value = Value - 250 WHERE Name = 'Вода' AND Value > 0";
                SQLRequest(sql);
            }
        }

        // Exit //
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
