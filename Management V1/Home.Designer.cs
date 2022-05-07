namespace Management_V1
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
            this.components = new System.ComponentModel.Container();
            this.login_timer = new System.Windows.Forms.Timer(this.components);
            this.Dock_panel = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customer_btn = new System.Windows.Forms.Button();
            this.booking_btn = new System.Windows.Forms.Button();
            this.user_control_panel = new System.Windows.Forms.Panel();
            this.Dock_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_timer
            // 
            this.login_timer.Interval = 20;
            this.login_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dock_panel
            // 
            this.Dock_panel.Controls.Add(this.button1);
            this.Dock_panel.Controls.Add(this.booking_btn);
            this.Dock_panel.Controls.Add(this.logout_btn);
            this.Dock_panel.Controls.Add(this.button2);
            this.Dock_panel.Controls.Add(this.customer_btn);
            this.Dock_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dock_panel.Location = new System.Drawing.Point(0, 0);
            this.Dock_panel.Name = "Dock_panel";
            this.Dock_panel.Size = new System.Drawing.Size(1226, 45);
            this.Dock_panel.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(979, 0);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(248, 43);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(735, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Workers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(489, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Payments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customer_btn
            // 
            this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.Location = new System.Drawing.Point(1, 0);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(248, 43);
            this.customer_btn.TabIndex = 1;
            this.customer_btn.Text = "Customer";
            this.customer_btn.UseVisualStyleBackColor = true;
            this.customer_btn.Click += new System.EventHandler(this.customer_btn_Click);
            // 
            // booking_btn
            // 
            this.booking_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booking_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_btn.Location = new System.Drawing.Point(244, 0);
            this.booking_btn.Name = "booking_btn";
            this.booking_btn.Size = new System.Drawing.Size(248, 43);
            this.booking_btn.TabIndex = 2;
            this.booking_btn.Text = "Bookings";
            this.booking_btn.UseVisualStyleBackColor = true;
            this.booking_btn.Click += new System.EventHandler(this.booking_btn_Click);
            // 
            // user_control_panel
            // 
            this.user_control_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.user_control_panel.Location = new System.Drawing.Point(0, 47);
            this.user_control_panel.Name = "user_control_panel";
            this.user_control_panel.Size = new System.Drawing.Size(1226, 600);
            this.user_control_panel.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 647);
            this.Controls.Add(this.user_control_panel);
            this.Controls.Add(this.Dock_panel);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Dock_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer login_timer;
        private System.Windows.Forms.Panel Dock_panel;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Button booking_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel user_control_panel;
    }
}