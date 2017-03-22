using Project.com.gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            userToolStripMenuItem.Enabled = adminToolStripMenuItem.Enabled = logoutToolStripMenuItem.Enabled = false;
        }

        public string SetTextUser
        {
            set { label1.Text = value; }
        }

        public bool EnableUserMenu
        {
            set { userToolStripMenuItem.Enabled = value; }
        }

        public bool EnableLoginMenu
        {
            set { loginToolStripMenuItem.Enabled = value; }
        }

        public bool EnableLogoutMenu
        {
            set { logoutToolStripMenuItem.Enabled = value; }
        }

        public bool EnableAdminMenu
        {
            set { adminToolStripMenuItem.Enabled = value; }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.MdiParent = this;
            l.StartPosition = FormStartPosition.CenterScreen;
            l.Show();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetTextUser = "";
            this.EnableLoginMenu = true;
            this.EnableAdminMenu = false;
            this.EnableUserMenu = false;
            this.EnableLogoutMenu = false;
        }

        private void addNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewAgentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddAgent aa = new AddAgent(label1.Text);
            aa.MdiParent = this;
            aa.StartPosition = FormStartPosition.CenterScreen;
            aa.Show();
        }

        private void addNewPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPassenger anp = new AddNewPassenger(label1.Text);
            anp.MdiParent = this;
            anp.StartPosition = FormStartPosition.CenterScreen;
            anp.Show();
        }

        private void updatePassengerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePassenger udp = new UpdatePassenger(label1.Text);
            udp.MdiParent = this;
            udp.StartPosition = FormStartPosition.CenterScreen;
            udp.Show();
        }

        private void addNewCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCity anc = new AddNewCity();
            anc.MdiParent = this;
            anc.StartPosition = FormStartPosition.CenterScreen;
            anc.Show();
        }

        private void addNewRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewRoute anr = new AddNewRoute();
            anr.MdiParent = this;
            anr.StartPosition = FormStartPosition.CenterScreen;
            anr.Show();
        }

        private void updateARouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateARoute ur = new UpdateARoute();
            ur.MdiParent = this;
            ur.StartPosition = FormStartPosition.CenterScreen;
            ur.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(label1.Text);
            cp.MdiParent = this;
            cp.StartPosition = FormStartPosition.CenterScreen;
            cp.Show();
        }

        private void addNewBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCityBus acb = new AddCityBus();
            acb.MdiParent = this;
            acb.StartPosition = FormStartPosition.CenterScreen;
            acb.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCityBus ucb = new UpdateCityBus();
            ucb.MdiParent = this;
            ucb.StartPosition = FormStartPosition.CenterScreen;
            ucb.Show();
        }
    }
}
