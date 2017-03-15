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
    public partial class UpdateARoute : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BookingConnectionString"].ConnectionString;
        DataSet ds = null;
        string route = " to ";

        public UpdateARoute()
        {
            InitializeComponent();
            string sql = "select city_Id, city_Name from City;select city_Id, city_Name from City; select route_Id from Route";
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            ds = new DataSet();
            da.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox2.DataSource = ds.Tables[1];
            comboBox3.DataSource = ds.Tables[2];
            comboBox1.DisplayMember = "city_Name";
            comboBox2.DisplayMember = "city_Name";
            comboBox1.ValueMember = "city_Id";
            comboBox2.ValueMember = "city_Id";
            comboBox3.DisplayMember = "route_Id";
            comboBox3.ValueMember = "route_Id";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
        }

        void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getFromCity = "select from_City, to_City, duration from Route where route_Id = '" + comboBox3.SelectedValue.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(getFromCity,connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int fromCity = (int)dt.Rows[0]["from_City"];
            int toCity = (int)dt.Rows[0]["to_City"];
            comboBox1.SelectedValue = fromCity;
            comboBox2.SelectedValue = toCity;
            textBox2.Text = (string)dt.Rows[0]["duration"];
        }

        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(null, null);
            textBox1.Text = comboBox1.Text + route + comboBox2.Text;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text + route + comboBox2.Text;
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
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    string sql = "UPDATE [Booking].[dbo].[Route] "
                                + "SET [from_City] = @fromCity, [to_City] = @toCity, [duration] = @duration "
                                + "WHERE route_Id = @routeID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@fromCity", comboBox1.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@toCity", comboBox2.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@duration", textBox2.Text);
                    cmd.Parameters.AddWithValue("@routeID", comboBox3.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update successfull!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
