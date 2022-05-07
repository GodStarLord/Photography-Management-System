using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Management_V1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            login_timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.025;
            }
            else
                login_timer.Stop();
        }

        private void logout_btn_Click(object sender, EventArgs e)   //Moves to Home Screen
        {
            Login_Screen obj = new Login_Screen();
            this.Hide();
            obj.Show();
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            if(! user_control_panel.Controls.Contains(Customer_User_Control.Instance))
            {
                user_control_panel.Controls.Add(Customer_User_Control.Instance);
                Customer_User_Control.Instance.Dock = DockStyle.Fill;
                Customer_User_Control.Instance.BringToFront();
            }
            else
            {
                Customer_User_Control.Instance.BringToFront();
            }
        }

        private void booking_btn_Click(object sender, EventArgs e)
        {
            if (!user_control_panel.Controls.Contains(Booking_User_Control.Instance))
            {
                user_control_panel.Controls.Add(Booking_User_Control.Instance);
                Booking_User_Control.Instance.Dock = DockStyle.Fill;
                Booking_User_Control.Instance.BringToFront();
            }
            else
            {
                Booking_User_Control.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!user_control_panel.Controls.Contains(Payments_User_Controls.Instance))
            {
                user_control_panel.Controls.Add(Payments_User_Controls.Instance);
                Payments_User_Controls.Instance.Dock = DockStyle.Fill;
                Payments_User_Controls.Instance.BringToFront();
            }
            else
            {
                Payments_User_Controls.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!user_control_panel.Controls.Contains(Workers_User_controls.Instance))
            {
                user_control_panel.Controls.Add(Workers_User_controls.Instance);
                Workers_User_controls.Instance.Dock = DockStyle.Fill;
                Workers_User_controls.Instance.BringToFront();
            }
            else
            {
                Workers_User_controls.Instance.BringToFront();
            }
        }
    }
}
