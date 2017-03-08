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
    public partial class Login : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BookingConnectionString"].ConnectionString;


        public Login()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool role = radioButton1.Checked;
            string sql = "select * from Account where username = '" + username + "' and password = '" + password + "' and role_Id = '" + role + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                   if(radioButton1.Checked == true)
                        {
                            Home h = (Home) this.MdiParent;
                            h.EnableAdminMenu = false;
                            h.EnableLoginMenu = false;
                            h.EnableLogoutMenu = true;
                            h.EnableUserMenu = true;
                            this.Close();
                        }

                   if (radioButton1.Checked == false)
                        {
                            Home h = (Home)this.MdiParent;
                            h.EnableAdminMenu = true;
                            h.EnableLoginMenu = false;
                            h.EnableLogoutMenu = true;
                            h.EnableUserMenu = false;
                            this.Close();
                        }
            }
            else 
            {
                MessageBox.Show("Invalid login or password. Please try again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
