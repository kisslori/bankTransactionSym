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
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = DESKTOP-OMJQU7F ; Initial Catalog = bankAccounts ; Integrated Security=True");
        public Account acc;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2( Account acc)
        {
            this.acc = acc;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ballance_amount_label.Text = acc.ballance.ToString();
            welc_user_label.Text = acc.user_name;

        }

        private void minus_button_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
            }
            else
            {  
                int amount;
                int.TryParse(textBox1.Text, out amount);
                if(amount == 0) // if 0 there is no need for a transaction
                {
                    return;
                }
                long newBallance = acc.ballance - amount;

                if (newBallance < 0)
                {
                    status_label.ForeColor = Color.Red;
                    status_label.Text = "insuficient funds";
                    return;
                }
                // pin check
                if (acceptTrans())
                {
                    updateBallance(acc.user_name, newBallance);   //updates balllance in db                 
                }else
                {
                    status_label.Text = "something went wrong, check pin is correct";
                }
            }
        }
 
        //pin check method
        public bool acceptTrans()
        {   
            //this creates a prompt that asks for the pin
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please insert your pin to check authenticity",
                     "PIN Required",  "",   0,   0);
            int i;
            int.TryParse(input, out i);
            if (i == acc.pin)
            {
                return true;
            }
            return false;
        }

        //resets the UI with the new values
        public void resetBallance()
        {
            connection.Open();
            string cmd = "select _ballance from Users where _username=@user";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("@user", acc.user_name);
            SqlDataReader reader = command.ExecuteReader();
            
            if (reader.Read())
            {
                long b;
                long.TryParse(reader["_ballance"].ToString(), out b);
                acc.ballance = b;
            }

            connection.Close();

            ballance_amount_label.Text = acc.ballance.ToString();
            textBox1.Text = "";

        }

        //method that updates the ballance in the db
        public void updateBallance( string user, long newBallance)
        {
            connection.Open();
            string cmd = "update Users set _ballance=@ball where _username=@user ";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("@ball", newBallance);
            command.Parameters.AddWithValue("@user", user);
            command.ExecuteNonQuery();
            connection.Close();

            resetBallance();
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            int amount;
            int.TryParse(textBox1.Text, out amount);
            if (amount == 0) // if 0 there is no need for a transaction
            {
                return;
            }
            long newBallance = acc.ballance + amount;

            if (acceptTrans())
            {
                updateBallance(acc.user_name, newBallance);
            }
            else
            {
                status_label.Text = "something went wrong, check pin is correct";
            }
        }
    }
}
