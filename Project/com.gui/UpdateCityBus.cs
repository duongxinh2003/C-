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
    public partial class UpdateCityBus : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BookingConnectionString"].ConnectionString;
        DataSet ds = null;

        public UpdateCityBus()
        {
            InitializeComponent();
            string sql = "select * from Route ; select * from Bus";
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "route_Name";
            comboBox1.ValueMember = "route_Id";
            comboBox2.DataSource = ds.Tables[1];
            comboBox2.DisplayMember = "bus_Id";
            comboBox2.ValueMember = "bus_Id";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getFromCity = "SELECT City.city_Name FromCity, c.city_Name ToCity "
                                    + "FROM Route r  "
                                    + "JOIN City  "
                                    + "ON r.from_City = City.city_Id "
                                    + "JOIN City c " + " ON r.to_City = c.city_Id "
                                    + "where r.route_Id = '" + comboBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(getFromCity, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string fromCity = (string)dt.Rows[0]["FromCity"];
            string toCity = (string)dt.Rows[0]["ToCity"];
            textBox1.Text = fromCity + " to " + toCity;
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
                MessageBox.Show("Fare is invalid, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    string sql = "UPDATE [Booking].[dbo].[Bus] "
                                + "SET [route_Id] = @routeID,[fare] = @fare "
                                + "WHERE bus_Id = @busID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@busID", comboBox2.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@routeID", comboBox1.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@fare", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update city bus successfull!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
