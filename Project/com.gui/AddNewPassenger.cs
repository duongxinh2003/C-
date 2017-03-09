using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Project.com.gui
{
    public partial class AddNewPassenger : Form
    {
        private string p;
        string connectionString = ConfigurationManager.ConnectionStrings["BookingConnectionString"].ConnectionString;

        public AddNewPassenger()
        {

        }

        public AddNewPassenger(string p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("City name or National ID not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    string sql = "INSERT INTO [Booking].[dbo].[Passenger] "
                             + " ([passenger_Name],[passenger_Create],[national_Id],[username]) "
                             + " VALUES (@passenger_Name,@date,@national_ID,@username) ";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@national_Id", textBox2.Text);
                    cmd.Parameters.AddWithValue("@passenger_Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));
                    cmd.Parameters.AddWithValue("@username", p);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Add successfull!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(connectionString);
                        conn.Open();
                        string sql = "INSERT INTO [Booking].[dbo].[National] ([national_Id])"
                                 + " VALUES (@national_Id) "
                                 + "INSERT INTO [Booking].[dbo].[Passenger] "
                                 + " ([passenger_Name],[passenger_Create],[national_Id],[username]) "
                                 + " VALUES (@passenger_Name,@date,@national_ID,@username) ";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@national_Id", textBox2.Text);
                        cmd.Parameters.AddWithValue("@passenger_Name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));
                        cmd.Parameters.AddWithValue("@username", p);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Add successfull!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
