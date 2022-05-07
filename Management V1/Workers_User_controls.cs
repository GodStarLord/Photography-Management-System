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
    public partial class Workers_User_controls : UserControl
    {
        private static Workers_User_controls instance;

        public static Workers_User_controls Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Workers_User_controls();
                }
                return instance;
            }
        }

        public Workers_User_controls()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security = True");

        private void Workers_User_controls_Load(object sender, EventArgs e)
        {
            refresh_DataGrid_view();
            refresh_DataGrid_view2();
        }

        private void Add_Emp_details(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Add_Emp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("emp_name", emp_name_textbox.Text);
            cmd.Parameters.AddWithValue("emp_phone", emp_phone_textbox.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
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
                SqlCommand cmd = new SqlCommand("Show_EMp", con);
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
                    MessageBox.Show("    <<<<< INVALID SQL OPERATION >>>>>>   " + ex);
                }
                con.Close();

                dataGridView1.DataSource = dataSet.Tables[0];

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Add_orderEmp(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Add_WorksOn_Procedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("emp_id", emp_id_textbox.Text);
            cmd.Parameters.AddWithValue("order_id", order_id_textbox.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("       <<<<< INVALID SQL QUERY OCCURED >>>>> " + ex);
            }
            con.Close();

            refresh_DataGrid_view2();
        }

        public void refresh_DataGrid_view2()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Show_Workson", con);
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
                    MessageBox.Show("    <<<<< INVALID SQL OPERATION >>>>>>   " + ex);
                }
                con.Close();

                dataGridView2.DataSource = dataSet.Tables[0];

                this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void refresh_click(object sender, EventArgs e)
        {
            refresh_DataGrid_view();
            refresh_DataGrid_view2();
        }
    }
}
