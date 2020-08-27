using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ChurchRecord
{
    public partial class passwordReset : Form
    {
        string password;

        public passwordReset()
        {
            InitializeComponent();
        }

        commonFunctionsClass commFcn = new commonFunctionsClass();

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dateVal = DateTime.Today;
            string day = dateVal.Day.ToString();
            string month = dateVal.ToString("MM");
            string year = dateVal.Year.ToString();

            string dateToday = year + "-" + month + "-" + day;
            //MessageBox.Show("Today is: " + dateToday);

            string usernam1 = txtUsername.Text;
            string encryptedPass = commFcn.Encrypt(txtOldPassword.Text, "123456");
            string encryptedPass2 = commFcn.Encrypt(txtNewPassword.Text, "123456");

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a Valid Username", "Input Error");
                txtUsername.Focus();
            }
            else if (txtOldPassword.Text.Trim() == "")
            {
                MessageBox.Show("You have not Entered Old Password", "Input Error");
                txtOldPassword.Focus();
            }
            else if (txtNewPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter your new Password", "Input Error");
                txtNewPassword.Focus();
            }
            else{
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.app_users where username = '" + usernam1 + "';";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        password = myReader.GetString("password");
                        
                    }
                    if (password == encryptedPass)
                    {
                        myConn.Close();
                        string query22 = "update cpcdb.app_users set PASSWORD = '" + encryptedPass2 + "' where USERNAME = '" + usernam1 + "';";
                        MySqlCommand SelectCommand2 = new MySqlCommand(query22, myConn);
                        //MySqlDataReader myReader;
                        myConn.Open();
                        myReader = SelectCommand2.ExecuteReader();
                        myConn.Close();
                        MessageBox.Show("Username has been Reseted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Password Entered Did Not Match Old Password", "Input Error");   

                        //DialogResult dialog = MessageBox.Show("Password Entered Did Not Match Old Password", "Input Error", MessageBoxButtons.RetryCancel);
                        //if (dialog == DialogResult.Retry)
                        //{ 
                        
                        //}
                        //else if (dialog == DialogResult.Cancel)
                        //{
                            
                        //}
                    }
                }
                    
                else 
                {
                    MessageBox.Show("Username Does Not Exist", "Input Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }}
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            char surnameChar = e.KeyChar;
            //if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ---- for number check...

            if (surnameChar == 32)
            {
                MessageBox.Show("Field cannot be number");
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void passwordReset_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Exit?", "Exit", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                this.Hide();
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void passwordReset_Load(object sender, EventArgs e)
        {

        }
    }
}
