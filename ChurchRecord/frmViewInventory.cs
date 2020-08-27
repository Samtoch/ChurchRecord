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
    public partial class frmViewInventory : Form
    {
        DataTable dbDataset;

        public frmViewInventory()
        {
            InitializeComponent();
        }

        private void frmViewInventory_Load(object sender, EventArgs e)
        {
            //querySel = "select * from cpcdb.church_payables where period = '" + this.cmbPeriod.Text +"' and payment = '"+ this.cmbPayment.Text +"';";
            string querySel = "select * from cpcdb.church_inventory;";
            
            string myConnection = "datasource=localhost;port=3306;username=root;password=password";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand dbCommand = new MySqlCommand(querySel, myConn);
            try
            {
                MySqlDataAdapter sqlDataAdapt = new MySqlDataAdapter();
                sqlDataAdapt.SelectCommand = dbCommand;
                
                dbDataset = new DataTable();
                sqlDataAdapt.Fill(dbDataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataset;
                dgvUploadTable.DataSource = bSource;

                MySqlDataReader myReader;
                myConn.Open();
                myReader = dbCommand.ExecuteReader();

                //while (myReader.Read())
                //{
                //    amountVal += myReader.GetDecimal("AMOUNT");
                //    totAmt += myReader.GetDecimal("TOTAL_AMOUNT");
                //}
                //txtTotalPaid.Text = amountVal.ToString();
                //txtTotalPayable.Text = totAmt.ToString();
                //balAmt = totAmt - amountVal;
                //txtBalance2.Text = balAmt.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvUploadTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dateVal;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow tableRow = this.dgvUploadTable.Rows[e.RowIndex];

                txtSerialNo.Text = tableRow.Cells["SERIAL_NO"].Value.ToString();
                txtItem.Text = tableRow.Cells["PROPERTY"].Value.ToString();
                txtQuantity.Text = tableRow.Cells["QUANTITY"].Value.ToString();
                txtStatus.Text = tableRow.Cells["STATUS"].Value.ToString();
                string amt = tableRow.Cells["COST_PER_ITEM"].Value.ToString();
                decimal amtVal = Decimal.Parse(amt);
                txtCostofItem.Text = amtVal.ToString();
                txtDatePurchased.Text = tableRow.Cells["DATE_PURCHASED"].Value.ToString();
                //string date = tableRow.Cells["DATE_PURCHASED"].Value.ToString();
                //string silva = date.Replace("/","-");
                //string newVal = date.
                //MessageBox.Show(silva);
                //txtDatePurchased.Text = dateVal.ToString("yyyy-MM-dd");
                txtDateRegistered.Text = tableRow.Cells["DATE_REGISTERED"].Value.ToString();
                txtRegisteredBy.Text = tableRow.Cells["REGISTERED_BY"].Value.ToString();
            }
        }

        private void txtSearchByItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dView = new DataView(dbDataset);
            dView.RowFilter = string.Format("PROPERTY LIKE '%{0}%'", txtSearchByItem.Text);
            dgvUploadTable.DataSource = dView;
        }

        private void txtSearchByItem_TextChanged(object sender, EventArgs e)
        {
            //DataView dView = new DataView(dbDataset);
            //dView.RowFilter = string.Format("SURNAME LIKE '%{0}%'", txtSearchBySurname.Text);
            //dgvUploadTable.DataSource = dView;
        }

        private void btnUdateRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "UPDATE cpcdb.church_inventory SET PROPERTY = '" + this.txtItem.Text + "', QUANTITY = '" + this.txtQuantity.Text + "', STATUS = '" + this.txtStatus.Text + "', COST_PER_ITEM = '" + this.txtCostofItem.Text + "', DATE_PURCHASED = '" + this.txtDatePurchased.Text + "', REGISTERED_BY = '" + this.txtRegisteredBy.Text + "' where SERIAL_NO = '" + this.txtSerialNo.Text + "' ;"; 

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();

                //MessageBox.Show(query);
                myReader = SelectCommand.ExecuteReader();

                MessageBox.Show("Successfully Updated");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmViewInventory_Load(sender, e);
        }
    }
}
