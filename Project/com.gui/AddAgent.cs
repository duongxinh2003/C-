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
    public partial class AddAgent : Form
    {
        private string user;
        string connectionString = ConfigurationManager.ConnectionStrings["BookingConnectionString"].ConnectionString;

        public AddAgent()
        {
            
        }

        public AddAgent(string SetTextUser)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.user = SetTextUser;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string sql = "INSERT INTO [Booking].[dbo].[Account]"
                         + " VALUES (@username,@password,'True')";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Add successfull!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Username has been existed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
