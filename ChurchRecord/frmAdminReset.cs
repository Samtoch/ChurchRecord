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
    public partial class frmAdminReset : Form
    {
        public frmAdminReset()
        {
            InitializeComponent();
        }

        commonFunctionsClass commFcn = new commonFunctionsClass();

        private void btnReset_Click(object sender, EventArgs e)
        {
            string usernam1 = txtUsername.Text;
            string encryptedPass = commFcn.Encrypt(txtUsername.Text, "123456");

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
                        myConn.Close();
                        string query2 = "update cpcdb.app_users set reset = 'Y', password = '" + encryptedPass + "' where username = '" + usernam1 + "';";
                        MySqlCommand SelectCommand2 = new MySqlCommand(query2, myConn);
                        //MySqlDataReader myReader;
                        myConn.Open();
                        myReader = SelectCommand2.ExecuteReader();
                        myConn.Close();
                        MessageBox.Show("User has been Reseted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("User does not Exist");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
