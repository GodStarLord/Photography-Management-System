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
    public partial class Customer_User_Control : UserControl
    {
        private static Customer_User_Control instance;

        public static Customer_User_Control Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Customer_User_Control();
                }
                return instance;
            }
        }

        public Customer_User_Control()
        {
            InitializeComponent();
            refresh_DataGrid_view();
        }

        

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security = True");

        private void Customer_User_Control_Load(object sender, EventArgs e)
        {

        }

        private void add_customer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Customer_Add_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("c_name", customer_name.Text);
            cmd.Parameters.AddWithValue("c_phone", customer_phone.Text);
            cmd.Parameters.AddWithValue("c_address", customer_address.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("       <<<<< INVALID SQL QUERY OCCURED >>>>> " + ex);
            }
            con.Close();

            refresh_DataGrid_view();
        }

        public void refresh_DataGrid_view()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Show_Customer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("    <<<<< INVALID SQL OPERATION >>>>>>   " + ex);
                }
                con.Close();

                dataGridView1.DataSource = dataSet.Tables[0];

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void clear_click(object sender, EventArgs e)
        {
            customer_id_TextBox.Text = "";
            customer_name.Text = "";
            customer_phone.Text = "";
            customer_address.Text = "";
        }

        private void search_click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Search_Customer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@c_id", customer_id_TextBox.Text);

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
                    MessageBox.Show("    <<<<< INVALID SQL OPERATION >>>>>>   " + ex);
                }
                con.Close();

                dataGridView1.DataSource = dataSet.Tables[0];

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid Customer ID");
            }
        }

        private void refresh_click(object sender, EventArgs e)
        {
            refresh_DataGrid_view();
        }

        private void update_click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update_Customers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@c_id", customer_id_TextBox.Text);
                cmd.Parameters.AddWithValue("@c_phone", customer_phone.Text);
                cmd.Parameters.AddWithValue("@c_address", customer_address.Text);

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
                    MessageBox.Show("    <<<<< INVALID SQL OPERATION >>>>>>   " + ex);
                }
                con.Close();

                refresh_DataGrid_view();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid Customer ID");
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
