namespace Project
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePassengerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingByPassengerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateARouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAgentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listByRouteIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAgentToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.userToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookingToolStripMenuItem,
            this.passengerToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // addNewBookingToolStripMenuItem
            // 
            this.addNewBookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBookingToolStripMenuItem,
            this.addNewBookingToolStripMenuItem1,
            this.viewBookingDetailsToolStripMenuItem,
            this.updateBookingToolStripMenuItem});
            this.addNewBookingToolStripMenuItem.Name = "addNewBookingToolStripMenuItem";
            this.addNewBookingToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.addNewBookingToolStripMenuItem.Text = "Booking";
            this.addNewBookingToolStripMenuItem.Click += new System.EventHandler(this.addNewBookingToolStripMenuItem_Click);
            // 
            // searchBookingToolStripMenuItem
            // 
            this.searchBookingToolStripMenuItem.Name = "searchBookingToolStripMenuItem";
            this.searchBookingToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.searchBookingToolStripMenuItem.Text = "Search Booking";
            // 
            // addNewBookingToolStripMenuItem1
            // 
            this.addNewBookingToolStripMenuItem1.Name = "addNewBookingToolStripMenuItem1";
            this.addNewBookingToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.addNewBookingToolStripMenuItem1.Text = "Add New Booking";
            // 
            // viewBookingDetailsToolStripMenuItem
            // 
            this.viewBookingDetailsToolStripMenuItem.Name = "viewBookingDetailsToolStripMenuItem";
            this.viewBookingDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.viewBookingDetailsToolStripMenuItem.Text = "View Booking Details";
            // 
            // updateBookingToolStripMenuItem
            // 
            this.updateBookingToolStripMenuItem.Name = "updateBookingToolStripMenuItem";
            this.updateBookingToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.updateBookingToolStripMenuItem.Text = "Update Booking";
            // 
            // passengerToolStripMenuItem
            // 
            this.passengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPassengerToolStripMenuItem,
            this.updatePassengerInfoToolStripMenuItem,
            this.viewBookingByPassengerNameToolStripMenuItem});
            this.passengerToolStripMenuItem.Name = "passengerToolStripMenuItem";
            this.passengerToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.passengerToolStripMenuItem.Text = "Passenger";
            // 
            // addNewPassengerToolStripMenuItem
            // 
            this.addNewPassengerToolStripMenuItem.Name = "addNewPassengerToolStripMenuItem";
            this.addNewPassengerToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.addNewPassengerToolStripMenuItem.Text = "Add New Passenger";
            this.addNewPassengerToolStripMenuItem.Click += new System.EventHandler(this.addNewPassengerToolStripMenuItem_Click);
            // 
            // updatePassengerInfoToolStripMenuItem
            // 
            this.updatePassengerInfoToolStripMenuItem.Name = "updatePassengerInfoToolStripMenuItem";
            this.updatePassengerInfoToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.updatePassengerInfoToolStripMenuItem.Text = "Update Passenger Info";
            this.updatePassengerInfoToolStripMenuItem.Click += new System.EventHandler(this.updatePassengerInfoToolStripMenuItem_Click);
            // 
            // viewBookingByPassengerNameToolStripMenuItem
            // 
            this.viewBookingByPassengerNameToolStripMenuItem.Name = "viewBookingByPassengerNameToolStripMenuItem";
            this.viewBookingByPassengerNameToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.viewBookingByPassengerNameToolStripMenuItem.Text = "View Booking by Passenger Name";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeToolStripMenuItem,
            this.addNewAgentToolStripMenuItem,
            this.addNewAgentToolStripMenuItem1,
            this.addNewCityToolStripMenuItem,
            this.addNewAgentToolStripMenuItem2});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // routeToolStripMenuItem
            // 
            this.routeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRouteToolStripMenuItem,
            this.updateARouteToolStripMenuItem});
            this.routeToolStripMenuItem.Name = "routeToolStripMenuItem";
            this.routeToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.routeToolStripMenuItem.Text = "Route";
            // 
            // addNewRouteToolStripMenuItem
            // 
            this.addNewRouteToolStripMenuItem.Name = "addNewRouteToolStripMenuItem";
            this.addNewRouteToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.addNewRouteToolStripMenuItem.Text = "Add New Route";
            // 
            // updateARouteToolStripMenuItem
            // 
            this.updateARouteToolStripMenuItem.Name = "updateARouteToolStripMenuItem";
            this.updateARouteToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.updateARouteToolStripMenuItem.Text = "Update A Route";
            // 
            // addNewAgentToolStripMenuItem
            // 
            this.addNewAgentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBusToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.addNewAgentToolStripMenuItem.Name = "addNewAgentToolStripMenuItem";
            this.addNewAgentToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.addNewAgentToolStripMenuItem.Text = "Bus";
            this.addNewAgentToolStripMenuItem.Click += new System.EventHandler(this.addNewAgentToolStripMenuItem_Click);
            // 
            // addNewBusToolStripMenuItem
            // 
            this.addNewBusToolStripMenuItem.Name = "addNewBusToolStripMenuItem";
            this.addNewBusToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.addNewBusToolStripMenuItem.Text = "Add New City bus";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.updateToolStripMenuItem.Text = "Update A City Bus";
            // 
            // addNewAgentToolStripMenuItem1
            // 
            this.addNewAgentToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listByRouteIDToolStripMenuItem,
            this.listByToolStripMenuItem});
            this.addNewAgentToolStripMenuItem1.Name = "addNewAgentToolStripMenuItem1";
            this.addNewAgentToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.addNewAgentToolStripMenuItem1.Text = "Passenger";
            // 
            // listByRouteIDToolStripMenuItem
            // 
            this.listByRouteIDToolStripMenuItem.Name = "listByRouteIDToolStripMenuItem";
            this.listByRouteIDToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.listByRouteIDToolStripMenuItem.Text = "List By Bus ID";
            // 
            // listByToolStripMenuItem
            // 
            this.listByToolStripMenuItem.Name = "listByToolStripMenuItem";
            this.listByToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.listByToolStripMenuItem.Text = "List By Route ID";
            // 
            // addNewCityToolStripMenuItem
            // 
            this.addNewCityToolStripMenuItem.Name = "addNewCityToolStripMenuItem";
            this.addNewCityToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.addNewCityToolStripMenuItem.Text = "Add New City";
            this.addNewCityToolStripMenuItem.Click += new System.EventHandler(this.addNewCityToolStripMenuItem_Click);
            // 
            // addNewAgentToolStripMenuItem2
            // 
            this.addNewAgentToolStripMenuItem2.Name = "addNewAgentToolStripMenuItem2";
            this.addNewAgentToolStripMenuItem2.Size = new System.Drawing.Size(190, 26);
            this.addNewAgentToolStripMenuItem2.Text = "Add New Agent";
            this.addNewAgentToolStripMenuItem2.Click += new System.EventHandler(this.addNewAgentToolStripMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewBookingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePassengerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingByPassengerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateARouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAgentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listByRouteIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAgentToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
    }
}

