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
    public partial class AddNewRoute : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BookingConnectionString"].ConnectionString;
        DataSet ds = null;
        string route = " to ";

        public AddNewRoute()
        {
            InitializeComponent();
            label6.Text = getCode();
            string sql = "select city_Id, city_Name from City;select city_Id, city_Name from City";
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            comboBox1.DataSource = ds.Tables[0];
            comboBox2.DataSource = ds.Tables[1];
            comboBox1.DisplayMember = "city_Name";
            comboBox2.DisplayMember = "city_Name";
            comboBox1.ValueMember = "city_Id";
            comboBox2.ValueMember = "city_Id";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(null,null);
            textBox1.Text = comboBox1.Text + route + comboBox2.Text;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text +route + comboBox2.Text;
        }

        public static string getCode()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public bool checkCode(string code)
        {
            string sql = "select * from Route where route_Id = '" + code + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return false;
            }
            else
                return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double duration;
            if (string.IsNullOrEmpty(textBox2.Text) || Double.TryParse(textBox2.Text, out duration) == false)
            {
                MessageBox.Show("Duration is invalid, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkCode(label6.Text) == false)
            {
                MessageBox.Show("Error, ID have been used please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    string sql = "INSERT INTO [Booking].[dbo].[Route] "
                                + "([route_Id],[from_City],[to_City],[duration]) "
                                + "VALUES(@routeID,@fromCity,@toCity,@duration)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@routeID", label6.Text);
                    cmd.Parameters.AddWithValue("@fromCity", comboBox1.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@toCity", comboBox2.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@duration", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Add successfull!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
