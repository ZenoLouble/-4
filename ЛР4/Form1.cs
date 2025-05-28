using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace ЛР4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            string connectionString =
                "Server=(localdb)\\mssqllocaldb;Database=RealEstateAgency;Trusted_Connection=True";

            using SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Підключення успішне!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}

