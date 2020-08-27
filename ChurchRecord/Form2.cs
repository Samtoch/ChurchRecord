using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChurchRecord
{
    public partial class Form2 : Form
    {
        string role;
        string username;
        string password;

        

       
        DateTime todayDate = DateTime.Now;

        public Form2()
        {
            InitializeComponent();            
        }

        commonFunctionsClass commFcn = new commonFunctionsClass();
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DateTime dateVal = DateTime.Now;
            string strDate = dateVal.ToString();
            string day = dateVal.Day.ToString();
            string month = dateVal.ToString("MM");
            string year = dateVal.Year.ToString();
            //string hour = strDate.Substring(10,2);
            string hour = dateVal.Hour.ToString();
            string mins = dateVal.Minute.ToString();
            string secs = dateVal.Second.ToString();
            string dateToday = year + "-" + month + "-" + day + " " + hour + ":" + mins + ":" + secs;

            //MessageBox.Show("Today strDate is " + strDate);
            //MessageBox.Show("Today strHour is " + hour);
            //MessageBox.Show("Today NormHour is " + hour2);
            //MessageBox.Show("Today mins is " + mins);
            //MessageBox.Show("Today secs is " + secs);
            //MessageBox.Show("Today date is " + dateToday);

            string encryptedPass = commFcn.Encrypt(txtPassword.Text, "123456");

            timerLogin.Start();

            //progBarLogin.Value += 2;
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.app_users where username = 'Tochi' and password = 'dtX6R8fw99U+6C/+lKLEhQ==';";

                string query1 = "select * from cpcdb.app_users where username = '" + this.txtUsername.Text + "' and " +
                               " password = '" + encryptedPass + "';";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;

                while (myReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    username = myReader.GetString("username");
                    password = myReader.GetString("password");
                    role = myReader.GetString("role");
                    string resetVal = myReader.GetString("reset");

                    //MessageBox.Show("The username is: " + username);
                    //MessageBox.Show("And the Password is: " + password);
                    //MessageBox.Show("And the role is: " + role);

                    myConn.Close();

                    if (resetVal == "Y")
                    {
                        MessageBox.Show("Please Reset you password upon login", "Info!");
                        myConn.Open();
                        string updQuery = "UPDATE cpcdb.app_users SET LAST_LOGIN_TIME = '" + dateToday + "' where username = '" + username + "';";
                        MySqlCommand SelectCommand2 = new MySqlCommand(updQuery, myConn);
                        myReader = SelectCommand2.ExecuteReader();
                        myConn.Close();

                        frmHomePage2 home = new frmHomePage2(username);
                        //frmHomePage2 home = new frmHomePage2();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        myConn.Open();
                        string updQuery = "UPDATE cpcdb.app_users SET LAST_LOGIN_TIME = '" + dateToday + "' where username = '" + username + "';";
                        MessageBox.Show("Today date is " + dateToday);

                        MySqlCommand SelectCommand2 = new MySqlCommand(updQuery, myConn);
                        myReader = SelectCommand2.ExecuteReader();
                        myConn.Close();

                        //timerLogin.Start();

                        MessageBox.Show("Login is Successful");



                        frmHomePage2 home = new frmHomePage2(username);
                        //frmHomePage2 home = new frmHomePage2();
                        home.Show();
                        this.Hide();
                    }
                    

                }
                else if (count > 1)
                {
                    MessageBox.Show("Too many users with same Login ID");
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ageChar = e.KeyChar;
            if (ageChar == 13)
            {
                //MessageBox.Show("You have pressed Enter");
                btnLogin_Click(sender, e);
            }
        }

        private void progBarLogin_Click(object sender, EventArgs e)
        {

        }

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            progBarLogin.Increment(10);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
