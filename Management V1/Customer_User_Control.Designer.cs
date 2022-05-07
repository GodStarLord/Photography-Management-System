namespace Management_V1
{
    partial class Customer_User_Control
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
            this.label2 = new System.Windows.Forms.Label();
            this.customer_id_TextBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customer_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customer_address = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.update_details_display = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID :";
            // 
            // customer_id_TextBox
            // 
            this.customer_id_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_id_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.customer_id_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customer_id_TextBox.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id_TextBox.Location = new System.Drawing.Point(258, 56);
            this.customer_id_TextBox.Name = "customer_id_TextBox";
            this.customer_id_TextBox.Size = new System.Drawing.Size(645, 27);
            this.customer_id_TextBox.TabIndex = 2;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_button.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(944, 43);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(194, 48);
            this.search_button.TabIndex = 3;
            this.search_button.Text = " Search Customer";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(154, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 197);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F);
            this.label1.Location = new System.Drawing.Point(66, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Name :";
            // 
            // customer_name
            // 
            this.customer_name.BackColor = System.Drawing.SystemColors.Control;
            this.customer_name.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.Location = new System.Drawing.Point(248, 364);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(456, 27);
            this.customer_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F);
            this.label3.Location = new System.Drawing.Point(66, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Phone :";
            // 
            // customer_phone
            // 
            this.customer_phone.BackColor = System.Drawing.SystemColors.Control;
            this.customer_phone.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_phone.Location = new System.Drawing.Point(248, 416);
            this.customer_phone.Name = "customer_phone";
            this.customer_phone.Size = new System.Drawing.Size(456, 27);
            this.customer_phone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customer Address :";
            // 
            // customer_address
            // 
            this.customer_address.BackColor = System.Drawing.SystemColors.Control;
            this.customer_address.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_address.Location = new System.Drawing.Point(248, 469);
            this.customer_address.Name = "customer_address";
            this.customer_address.Size = new System.Drawing.Size(456, 27);
            this.customer_address.TabIndex = 10;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(873, 364);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(194, 48);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_customer_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_button.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(873, 427);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(194, 48);
            this.update_button.TabIndex = 13;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_click);
            this.update_button.MouseEnter += new System.EventHandler(this.mouse_enter);
            this.update_button.MouseLeave += new System.EventHandler(this.mouse_leave);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear_button.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(873, 490);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(194, 48);
            this.clear_button.TabIndex = 14;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(988, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 26);
            this.button6.TabIndex = 18;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.refresh_click);
            // 
            // update_details_display
            // 
            this.update_details_display.AutoSize = true;
            this.update_details_display.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_details_display.Location = new System.Drawing.Point(244, 515);
            this.update_details_display.Name = "update_details_display";
            this.update_details_display.Size = new System.Drawing.Size(357, 23);
            this.update_details_display.TabIndex = 19;
            this.update_details_display.Text = "Only Phone No/Address can be Updated.";
            this.update_details_display.Visible = false;
            // 
            // Customer_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.update_details_display);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.customer_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customer_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.customer_id_TextBox);
            this.Controls.Add(this.label2);
            this.Name = "Customer_User_Control";
            this.Size = new System.Drawing.Size(1226, 608);
            this.Load += new System.EventHandler(this.Customer_User_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customer_id_TextBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customer_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customer_address;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label update_details_display;
    }
}
