using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankTrans
{

    public class Account
    {
        public string user_name { get; set; }
        public string pass { get; set; }
        public int pin { get; set; }
        public long ballance { get; set; }
        public string hash { get; set; }
        public string phone { get; set; }

        public Account() { }

        public Account(string user, string pass, int pin, long ball, string hash , string phone)
        {
            this.user_name = user;
            this.pass = pass;
            this.pin = pin;
            this.ballance = ball;
            this.hash = hash;
            this.phone = phone;
        }


        public void createAccount()
        {
            string username = "admin";
            string password = "admin";
            string pin = "1234";
            string phone = "+1234567890";
            string hash = username.GetHashCode().ToString() + password.GetHashCode().ToString();
            string passEncripted = Cripting.Encrypt(password, hash);
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP ; Initial Catalog = bankAccounts ; Integrated Security=True");

            connection.Open();
            string comm = "Insert into Users values ('" + username + "', '" + passEncripted + "', " + pin + ", 0, '" + hash + "', '" + phone + "')";
            SqlCommand commandCreate = new SqlCommand(comm, connection);
            commandCreate.ExecuteNonQuery();
            connection.Close();
        }
    }


}
