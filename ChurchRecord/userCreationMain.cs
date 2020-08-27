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
    public partial class userCreationMain : Form
    {
        string usernameVal = "";
        DateTime todayDate = DateTime.Now;
        string date1;
        

        public userCreationMain()
        {
            InitializeComponent();
        }

        commonFunctionsClass commFcn = new commonFunctionsClass();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string usernam1 = txtUsername.Text;

            date1 = todayDate.ToShortDateString();
            //MessageBox.Show("The datetime is: " + date1);

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username", "Input Error");
            }
            else
            {
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
                        MessageBox.Show("User Already Exists");
                    }
                    else if (txtPassword.Text != txtPasswordConf.Text)
                    {
                        MessageBox.Show("Password did not match");
                    }
                    else
                    {
                        string encryptedPass = commFcn.Encrypt(txtPassword.Text, "123456");

                        myConn.Close();
                        string query22 = "insert into cpcdb.app_users (USERNAME,PASSWORD,CREATED_BY,ROLE) values('" + txtUsername.Text + "','" + encryptedPass + "','Mr.Toch','maker');";
                        MySqlCommand SelectCommand2 = new MySqlCommand(query22, myConn);
                        //MySqlDataReader myReader;
                        myConn.Open();
                        myReader = SelectCommand2.ExecuteReader();
                        myConn.Close();
                        MessageBox.Show("User has been created Successfully!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtPasswordConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void userCreationMain_Load(object sender, EventArgs e)
        {

        }

        private void userCreationMain_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
