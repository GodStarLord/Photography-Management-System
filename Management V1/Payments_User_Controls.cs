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
    public partial class Payments_User_Controls : UserControl
    {
        private static Payments_User_Controls instance;

        public static Payments_User_Controls Instance
        {
            get
            {
                if ( instance == null)
                {
                    instance = new Payments_User_Controls();
                }
                return instance;
            }
        }


        public Payments_User_Controls()
        {
            InitializeComponent();
        }

        public int amount, advance_amount, due_amount = 0;

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security = True");

        

        private void add_payments(object sender, EventArgs e)
        {
            try
            {
                advance_amount = Convert.ToInt32(advance_textbox.Text);
                amount = Convert.ToInt32(total_amount_textox.Text);
                due_amount = amount - advance_amount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the complete details");
            }


            SqlCommand cmd = new SqlCommand("Payments_Add", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("order_id", order_id_textbox.Text);
            cmd.Parameters.AddWithValue("advance", advance_textbox.Text);
            cmd.Parameters.AddWithValue("amount_due", due_amount);

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

        private void refresh_click(object sender, EventArgs e)
        {
            refresh_DataGrid_view();
        }

        private void Payments_User_Controls_Load(object sender, EventArgs e)
        {
            refresh_DataGrid_view();
        }

        public void refresh_DataGrid_view()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Payments_Show", con);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
