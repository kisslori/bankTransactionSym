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
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace bankTrans
{
    public partial class Form1 : Form
    {
        public static int isLoggedIn = 0;//0 not 1 is logged in
        public Account acc = new Account();
        public SqlConnection connection = new SqlConnection("Data Source = DESKTOP-OMJQU7F ; Initial Catalog = bankAccounts ; Integrated Security=True");

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

            connection.Open();
            string cmd = "select _username, _password, _pin, _ballance, _hash, _phoneNr from Users where _username=@user";
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
                acc.hash = reader["_hash"].ToString();
                acc.phone = reader["_phoneNr"].ToString();
            }
            reader.Close();
            connection.Close();

           


            if (acc.user_name != null)
            {
                string passDecripted = Cripting.Decrypt(acc.pass, acc.hash);
                if (passDecripted == pass)
                {
                    isLoggedIn = 1;
                    if (checkPhoneverification(acc.phone, Cripting.GetRandomAlphanumericString(4))){

                        status_label.Text = " Login successful";
                        Form2 f2 = new Form2(acc);
                        f2.Show();
                        this.Hide();
                    }
                }
                else
                {
                    status_label.Text = "username or password incorrect";
                }
            }         
        }

        public bool checkPhoneverification(string phone, string rand)
        {
            const string account_ssid = "AC7e6ec2790317d6fecdb9b7859bd855a9";
            const string authToken = "c703cd266655d7df17551f0f41eaaa68";

            TwilioClient.Init(account_ssid, authToken);


            MessageResource.Create(
                    to: new PhoneNumber(phone),
                    from: new PhoneNumber("+12566394823"),
                    body: "Your authentication code is: " + rand);


            string input = Microsoft.VisualBasic.Interaction.InputBox("Please insert the code you received through sms to complete authentication",
                       "Message code required", "", 0, 0);
           

            if(rand == input)
            {
                return true;
            }
            return false;

        }
    }
}

 