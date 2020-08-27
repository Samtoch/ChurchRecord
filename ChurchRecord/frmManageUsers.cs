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
    public partial class frmManageUsers : Form
    {
        string cmbSelUsername;
        string userStatVal;

        public frmManageUsers()
        {
            InitializeComponent();
            populateUsernameCombo();
            populateStatusCombo();
            populateComboRole();
        }

        void populateComboRole()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "SELECT * FROM cpcdb.static_data where USER_ROLE is not null;"; 

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string userRoleVal = myReader.GetString("USER_ROLE");
                    cmbRole.Items.Add(userRoleVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void populateUsernameCombo()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.app_users;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string userNameVal = myReader.GetString("USERNAME");
                    cmbUsername.Items.Add(userNameVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void populateStatusCombo()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "SELECT * FROM cpcdb.static_data where USER_STATUS is not null;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string userStatusVal = myReader.GetString("USER_STATUS");
                    cmbStatus.Items.Add(userStatusVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)

        {

        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ckbDeactivate.Checked = false;
            cmbSelUsername = cmbUsername.Text;
            cmbRole.Text = "";

            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.app_users where USERNAME = '" + cmbSelUsername + "';";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string userStatVal = myReader.GetString("USER_STATUS");
                    string userRoleVal = myReader.GetString("ROLE");
                    cmbRole.Text = userRoleVal;

                    if (userStatVal == "D")
                    {
                        cmbStatus.Text = "DISABLED";
                    }
                    else
                    {
                        cmbStatus.Text = "ACTIVE";
                    }
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbUsername.Text == "")
            {
                MessageBox.Show("Please select a user!");
                cmbUsername.Focus();
            }
            else
            {
                try
                {
                    string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                    MySqlConnection myConn = new MySqlConnection(myConnection);

                    MySqlDataReader myReader;

                    if (cmbStatus.Text == "ENABLE")
                    {
                        MessageBox.Show("Please Confirm You Want to Enable: " + cmbSelUsername);
                        string queryA = "update cpcdb.app_users set USER_STATUS = 'A' where USERNAME = '" + cmbSelUsername + "';";
                        MySqlCommand SelectCommandA = new MySqlCommand(queryA, myConn);
                        myConn.Open();
                        myReader = SelectCommandA.ExecuteReader();
                        myConn.Close();

                    }
                    else if (cmbStatus.Text == "DISABLE")
                    {
                        MessageBox.Show("Please Confirm You Want to Disable: " + cmbSelUsername);
                        myConn.Open();
                        string queryD = "update cpcdb.app_users set USER_STATUS = 'D' where USERNAME = '" + cmbSelUsername + "';";
                        MySqlCommand SelectCommandD = new MySqlCommand(queryD, myConn);
                        myReader = SelectCommandD.ExecuteReader();
                        myConn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
