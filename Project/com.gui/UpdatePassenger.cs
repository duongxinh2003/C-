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
    public partial class UpdatePassenger : Form
    {
        private string p;
        string connectionString = ConfigurationManager.ConnectionStrings["BookingConnectionString"].ConnectionString;
        DataSet ds = null;

        public UpdatePassenger()
        {

        }

        public UpdatePassenger(string p)
        {
            InitializeComponent();
            this.p = p;
            string sql = "SELECT [passenger_Id],[passenger_Name],[passenger_Create],[national_Id],[username]"
                        + "FROM [Booking].[dbo].[Passenger] where username = '" + p + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "passenger_Id";
            comboBox1.ValueMember = "passenger_Name";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string passengerName = comboBox1.SelectedValue.ToString();
            textBox1.Text = passengerName;
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
                    string sql = "UPDATE [Booking].[dbo].[Passenger] "
                             + " SET [passenger_Name] = @passengerName,[national_Id] = @nationalId "
                             + " WHERE passenger_Id = '" + comboBox1.Text + "' ";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@passengerName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@nationalId", textBox2.Text);
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
                                 + " VALUES (@nationalId) "
                                 + "UPDATE [Booking].[dbo].[Passenger] "
                                 + " SET [passenger_Name] = @passengerName,[national_Id] = @nationalId "
                                 + " WHERE passenger_Id = '" + comboBox1.Text + "' ";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@passengerName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@nationalId", textBox2.Text);
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
