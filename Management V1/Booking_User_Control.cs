using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Management_V1
{
    public partial class Booking_User_Control : UserControl
    {
        private static Booking_User_Control instance;

        public static Booking_User_Control Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Booking_User_Control();
                }
                return instance;
            }
        }

        public Booking_User_Control()
        {
            InitializeComponent();
            refresh_DataGrid_view();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security = True");

        private void Booking_User_Control_Load(object sender, EventArgs e)
        {

        }

        private void Add_Booking_click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Booking_Add_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("customer_id",customer_id.Text);
            cmd.Parameters.AddWithValue("booking_date",booking_date.Text);
            cmd.Parameters.AddWithValue("order_date", order_date.Text);
            cmd.Parameters.AddWithValue("amount", amount.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("       <<<<< INVALID SQL QUERY OCCURED >>>>>      " + ex);
            }
            con.Close();

            refresh_DataGrid_view();
        }

        public void refresh_DataGrid_view()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Show_Bookings", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("    <<<<< INVALID SQL OPERATION >>>>>>    " + ex);
                }
                con.Close();

                dataGridView1.DataSource = dataSet.Tables[0];

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void date_format_display(object sender, EventArgs e)
        {
            dateformat_label.Show();
        }

        private void date_format_hide(object sender, EventArgs e)
        {
            dateformat_label.Hide();
        }

        private void delete_button(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Delete_Booking", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@order_id", Booking_id_textbox.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("    <<<<< INVALID SQL OPERATION >>>>>>    " + ex);
                }
                con.Close();

                refresh_DataGrid_view();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Search_order_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order_id", Booking_id_textbox.Text);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("    <<<<< INVALID SQL OPERATION >>>>>>    " + ex);
                }
                con.Close();

                dataGridView1.DataSource = dataSet.Tables[0];

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a Valid Value");
            }
        }

        private void refresh_click(object sender, EventArgs e)
        {
            refresh_DataGrid_view();
        }

        private void clear_click(object sender, EventArgs e)
        {
            Booking_id_textbox.Text = "";
            customer_id.Text = "";
            booking_date.Text = "";
            order_date.Text = "";
            amount.Text = "";
        }

        private void update_click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update_Bookings", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order_id", Booking_id_textbox.Text);
                cmd.Parameters.AddWithValue("@order_date", order_date.Text);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("    <<<<< INVALID SQL OPERATION >>>>>>    " + ex);
                }
                con.Close();

                refresh_DataGrid_view();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a Valid Value");
            }
        }

        private void mouse_enter(object sender, EventArgs e)
        {
            update_details_display.Show();
        }

        private void mouse_leave(object sender, EventArgs e)
        {
            update_details_display.Hide();
        }
    }
}
