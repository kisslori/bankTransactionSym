using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankTrans
{
    public partial class Form1 : Form
    {
        public static int isLoggedIn = 0;//0 not 1 is logged in
        public Account acc = new Account();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pass_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-OMJQU7F ; Initial Catalog = bankAccounts ; Integrated Security=True");
            connection.Open();
            string cmd = "select _username, _password, _pin, _ballance from Users where _username=@user";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("@user", user);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                acc.user_name = reader["_username"].ToString();
                acc.pass = reader["_password"].ToString();
                int p;
                int.TryParse(reader["_pin"].ToString(), out p);
                acc.pin = p;
                long b;
                long.TryParse(reader["_ballance"].ToString(), out b);
                acc.ballance = b;
            }

            if (acc.pass == pass)
            {
                isLoggedIn = 1;
                status_label.Text = " Login successful";
                Form2 f2 = new Form2(acc);
                f2.Show();
                this.Hide();
            }
            else
            {
                status_label.Text = "username or password incorrect";
            }            
        }
    }
}

 