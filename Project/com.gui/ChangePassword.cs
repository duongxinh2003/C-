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
    public partial class ChangePassword : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BookingConnectionString"].ConnectionString;
        private string p;

        public ChangePassword()
        {

        }

        public ChangePassword(string p)
        {
            InitializeComponent();
            this.p = p;
            textBox4.Text = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Textfield cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "select * from Account where username = '" + p + "' and password = '" + textBox1.Text + "' and role_Id = '1'";
                SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (textBox2.Text.Equals(textBox3.Text))
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(connectionString);
                            conn.Open();
                            string query = "UPDATE [Booking].[dbo].[Account] "
                                        + "SET [password] = @password "
                                        + "WHERE [username] = @username";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@password", textBox2.Text);
                            cmd.Parameters.AddWithValue("@username", textBox4.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Update successfull!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("New password and Confirm password should match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Old password is invalid. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
