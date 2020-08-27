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
    public partial class frmIncome : Form
    {
        public frmIncome()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEvent.Text == "")
                {
                    MessageBox.Show("The Event field can not be Empty!");
                    txtEvent.Focus();
                    
                }
                else
                {
                    string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                    MySqlConnection myConn = new MySqlConnection(myConnection);

                    string query = "INSERT INTO cpcdb.all_income (EVENT, AMOUNT, DESCRIPTION, DATE_RECEIVED, CREATED_BY, DATE_CREATED) " +
                        " values  ('" + this.txtEvent.Text + "', '" + this.txtAmount.Text + "', '" + this.txtDescription.Text + "', " +
                        " '" + this.dtpDateReceived.Text + "', '" + this.txtCreatedby.Text + "', '" + this.dtpDateCreated.Text + "');";

                    MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                    MySqlDataReader myReader;
                    myConn.Open();

                    MessageBox.Show(query);
                    myReader = SelectCommand.ExecuteReader();

                    MessageBox.Show("Successfully Saved");
                    myConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEvent2.Text == "")
                {
                    MessageBox.Show("The Event field can not be Empty!");
                    txtEvent2.Focus();

                }
                else
                {
                    string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                    MySqlConnection myConn = new MySqlConnection(myConnection);

                    string query = "INSERT INTO cpcdb.all_expenses (EVENT, AMOUNT, DESCRIPTION, DATE_SPENT, CREATED_BY, DATE_CREATED, RECEIVED_BY) " +
                        " values  ('" + this.txtEvent2.Text + "', '" + this.txtAmount2.Text + "', '" + this.txtDescription2.Text + "', " +
                        " '" + this.dtpDateReceived2.Text + "', '" + this.txtCreatedBy2.Text + "', '" + this.dtpDateCreated2.Text + "', '" + this.txtReceivedBy.Text + "');"; 

                    MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                    MySqlDataReader myReader;
                    myConn.Open();

                    MessageBox.Show(query);
                    myReader = SelectCommand.ExecuteReader();

                    MessageBox.Show("Successfully Saved");
                    myConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
