namespace Management_V1
{
    partial class Booking_User_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Booking_id_textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.TextBox();
            this.booking_date = new System.Windows.Forms.TextBox();
            this.order_date = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateformat_label = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.update_details_display = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking ID:";
            // 
            // Booking_id_textbox
            // 
            this.Booking_id_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_id_textbox.Location = new System.Drawing.Point(256, 47);
            this.Booking_id_textbox.Name = "Booking_id_textbox";
            this.Booking_id_textbox.Size = new System.Drawing.Size(561, 24);
            this.Booking_id_textbox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(974, 220);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(847, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search Booking";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Booking Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount :";
            // 
            // customer_id
            // 
            this.customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id.Location = new System.Drawing.Point(181, 382);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(411, 24);
            this.customer_id.TabIndex = 8;
            // 
            // booking_date
            // 
            this.booking_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_date.Location = new System.Drawing.Point(181, 439);
            this.booking_date.Name = "booking_date";
            this.booking_date.Size = new System.Drawing.Size(411, 24);
            this.booking_date.TabIndex = 9;
            this.booking_date.MouseEnter += new System.EventHandler(this.date_format_display);
            this.booking_date.MouseLeave += new System.EventHandler(this.date_format_hide);
            // 
            // order_date
            // 
            this.order_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_date.Location = new System.Drawing.Point(181, 498);
            this.order_date.Name = "order_date";
            this.order_date.Size = new System.Drawing.Size(411, 24);
            this.order_date.TabIndex = 10;
            this.order_date.MouseEnter += new System.EventHandler(this.date_format_display);
            this.order_date.MouseLeave += new System.EventHandler(this.date_format_hide);
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(181, 548);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(411, 24);
            this.amount.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(714, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 53);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add Booking";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Add_Booking_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(714, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 53);
            this.button3.TabIndex = 13;
            this.button3.Text = "Update Booking";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.update_click);
            this.button3.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.button3.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(955, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 53);
            this.button4.TabIndex = 14;
            this.button4.Text = "Delete Booking";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.delete_button);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(955, 483);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 53);
            this.button5.TabIndex = 15;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.clear_click);
            // 
            // dateformat_label
            // 
            this.dateformat_label.AutoSize = true;
            this.dateformat_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dateformat_label.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateformat_label.Location = new System.Drawing.Point(769, 547);
            this.dateformat_label.Name = "dateformat_label";
            this.dateformat_label.Size = new System.Drawing.Size(312, 24);
            this.dateformat_label.TabIndex = 16;
            this.dateformat_label.Text = "The Date format is YYYY-MM-DD";
            this.dateformat_label.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1015, 349);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 26);
            this.button6.TabIndex = 17;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.refresh_click);
            // 
            // update_details_display
            // 
            this.update_details_display.AutoSize = true;
            this.update_details_display.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_details_display.Location = new System.Drawing.Point(782, 547);
            this.update_details_display.Name = "update_details_display";
            this.update_details_display.Size = new System.Drawing.Size(284, 23);
            this.update_details_display.TabIndex = 18;
            this.update_details_display.Text = "Only Order date can be Updated";
            this.update_details_display.Visible = false;
            // 
            // Booking_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.update_details_display);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dateformat_label);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.order_date);
            this.Controls.Add(this.booking_date);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Booking_id_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Booking_User_Control";
            this.Size = new System.Drawing.Size(1226, 600);
            this.Load += new System.EventHandler(this.Booking_User_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Booking_id_textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customer_id;
        private System.Windows.Forms.TextBox booking_date;
        private System.Windows.Forms.TextBox order_date;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label dateformat_label;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label update_details_display;
    }
}
