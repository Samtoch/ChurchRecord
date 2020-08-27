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
    public partial class frmInventory : Form
    {
        string itemStatVal;

        public frmInventory()
        {
            InitializeComponent();
            PopulateStatusCombo();
        }

        void PopulateStatusCombo()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.static_data where item_status is not null;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    itemStatVal = myReader.GetString("item_status");
                    cmbSatus.Items.Add(itemStatVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbSatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProperty.Text == "")
                {
                    MessageBox.Show("The Item field is Empty!");
                    txtProperty.Focus();
                }
                else
                {
                    string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                    MySqlConnection myConn = new MySqlConnection(myConnection);
          
                    string query = "INSERT INTO cpcdb.church_inventory (PROPERTY, QUANTITY, DATE_PURCHASED, STATUS, REGISTERED_BY, DATE_REGISTERED, COST_PER_ITEM) " +
                        " values  ('" + this.txtProperty.Text + "', '" + this.txtQuantity.Text + "', '" + this.dtpDatePurchased.Text + "', " +
                        " '" + this.cmbSatus.Text + "', '" + this.txtRegistered.Text + "', '" + this.dtpDateRegistered.Text + "', '" + this.txtCostOfItem.Text + "');";

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
