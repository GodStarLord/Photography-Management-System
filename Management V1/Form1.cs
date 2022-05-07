using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Management_V1
{
    public partial class Login_Screen : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\DataBase.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dataReader;

        private String getusername()
        {
            // gets the username from the data base...
            con.Open();
            String syntax = "SELECT UserName FROM LoginTable where UserName = 'admin'";
            cmd = new SqlCommand(syntax, con);
            dataReader = cmd.ExecuteReader();
            dataReader.Read();  // all the values will be stored as 2D array.
            String temp = dataReader[0].ToString();
            con.Close();
            return temp;
        }

        private String getpassword()
        {
            // gets the password from the data base...
            con.Open();
            String syntax = "SELECT Password FROM LoginTable where UserName = 'admin'";
            cmd = new SqlCommand(syntax, con);
            dataReader = cmd.ExecuteReader();
            dataReader.Read();  // all the values will be stored as 2D array.
            String temp = dataReader[0].ToString();
            con.Close();
            return temp;
        }

        public Login_Screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            String usrname = getusername();
            String passwrd = getpassword();

            if ((username == usrname) && (password == passwrd))  // login Success
            {
                //MessageBox.Show("Login Success...!", "Success");
                Home obj = new Home();
                this.Hide();        // Transits to Next Page
                obj.Show();
            }
            else    // Login Failure
            {
                label1.Show();
            }
        }
    }
}
