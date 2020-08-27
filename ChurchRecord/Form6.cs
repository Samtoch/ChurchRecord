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
    public partial class Form6 : Form
    {
        string querySel;
        decimal amountVal;
        decimal totAmt;
        decimal balAmt;
        string paymentVal;
        string periodVal;
        string selectedPayment = "ALL";
        string selectedPeriod = "ALL";

        DataTable dbDataset;
        

        public Form6()
        {
            InitializeComponent();
            PopulatePeriodCombo();
            PopulatePaymentCombo();

            autoCompleteSearchnameTxt();
        }

        void PopulatePaymentCombo()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.static_data where payment is not null;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    paymentVal = myReader.GetString("payment");
                    cmbPayment.Items.Add(paymentVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void PopulatePeriodCombo()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.static_data where period is not null;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    periodVal = myReader.GetString("period");
                    cmbPeriod.Items.Add(periodVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            btnUploadTable_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.church_payables where serial_no = '" + this.txtSerialNo.Text + "' ;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string surnameVal = myReader.GetString("SURNAME");
                    string othernamesVal = myReader.GetString("OTHER_NAMES");
                    string paymentVal = myReader.GetString("PAYMENT");
                    string periodVal = myReader.GetString("PERIOD");
                    decimal amtVal = myReader.GetDecimal("AMOUNT");
                    decimal totalAmtVal = myReader.GetDecimal("TOTAL_AMOUNT");
                    string createdByVal = myReader.GetString("CREATED_BY");
                    string dateCreatedVal = myReader.GetString("DATE_CREATED");
                    string modifiedByVal = myReader.GetString("MODIFIED_BY");
                    string dateModifiedVal = myReader.GetString("DATE_MODIFIED");

                    txtName.Text = surnameVal;
                    txtPaymentFor.Text = paymentVal;
                    //txtOtherNames = othernamesVal;
                    txtPeriod.Text = periodVal;
                    txtAmtPaid.Text = amtVal.ToString();
                    decimal bal = totalAmtVal - amtVal;
                    txtBalance.Text = bal.ToString();
                    txtCreatedBy.Text = createdByVal;
                    txtDatePaid.Text = dateCreatedVal;
                    

                    //DateTime bDate = DateTime.Parse(strAgeVal);
                    //DateTime todayDate = DateTime.Today;
                    //calcAge = todayDate.Year - bDate.Year;
                    //txtAge.Text = calcAge.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {
                txtSerialNo.Focus();
            }
        }

        private void txtSerialNo_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("Prints if the Enter Key works");
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.church_payables where serial_no = '" + this.txtSerialNo.Text + "' ;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string serialNo = myReader.GetString("serial_no");
                    if (serialNo == "")
                    {
                        MessageBox.Show("Please Enter a Valid Serial No.!");
                    }
                    string surnameVal = myReader.GetString("SURNAME");
                    string othernamesVal = myReader.GetString("OTHER_NAMES");
                    string paymentVal = myReader.GetString("PAYMENT");
                    string periodVal = myReader.GetString("PERIOD");
                    decimal amtVal = myReader.GetDecimal("AMOUNT");
                    decimal totalAmtVal = myReader.GetDecimal("TOTAL_AMOUNT");
                    string createdByVal = myReader.GetString("CREATED_BY");
                    string dateCreatedVal = myReader.GetString("DATE_CREATED");
                    string modifiedByVal = myReader.GetString("MODIFIED_BY");
                    string dateModifiedVal = myReader.GetString("DATE_MODIFIED");

                    txtName.Text = surnameVal;
                    txtPaymentFor.Text = paymentVal;
                    //txtOtherNames = othernamesVal;
                    txtPeriod.Text = periodVal;
                    txtAmtPaid.Text = amtVal.ToString();
                    decimal bal = totalAmtVal - amtVal;
                    txtBalance.Text = bal.ToString();
                    txtCreatedBy.Text = createdByVal;
                    txtDatePaid.Text = dateCreatedVal;


                    //DateTime bDate = DateTime.Parse(strAgeVal);
                    //DateTime todayDate = DateTime.Today;
                    //calcAge = todayDate.Year - bDate.Year;
                    //txtAge.Text = calcAge.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSerialNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ageChar = e.KeyChar;
            if (ageChar == 13)
            {
                //MessageBox.Show("You have pressed Enter");
                txtSerialNo_Enter(sender,e);
            }
        }

        private void btnUploadTable_Click(object sender, EventArgs e)
        {
            amountVal = 0;
            totAmt = 0;
            balAmt = 0;

            if (this.cmbPeriod.Text == "ALL" && this.cmbPayment.Text == "ALL")
            {
                querySel = "select * from cpcdb.church_payables;";
            }
            else if (this.cmbPayment.Text == "ALL" && this.cmbPeriod.Text != "ALL")
            {
                querySel = "select * from cpcdb.church_payables where period = '" + this.cmbPeriod.Text + "';";
            }
            else if (this.cmbPeriod.Text == "ALL" && this.cmbPayment.Text != "ALL")
            {
                querySel = "select * from cpcdb.church_payables where payment = '" + this.cmbPayment.Text + "';";
            }

            else 
            {
                querySel = "select * from cpcdb.church_payables where period = '" + this.cmbPeriod.Text +"' and payment = '"+ this.cmbPayment.Text +"';";
            }
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand dbCommand = new MySqlCommand(querySel, myConn);

            try
            {
                MySqlDataAdapter sqlDataAdapt = new MySqlDataAdapter();
                sqlDataAdapt.SelectCommand = dbCommand;
                //DataTable dbDataset = new DataTable();
                dbDataset = new DataTable();
                sqlDataAdapt.Fill(dbDataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataset;
                dgvUploadTable.DataSource = bSource;
                //sqlDataAdapt.Update(dbDataset);
                
                MySqlDataReader myReader;
                myConn.Open();
                myReader = dbCommand.ExecuteReader();
                //myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    amountVal += myReader.GetDecimal("AMOUNT");
                    totAmt += myReader.GetDecimal("TOTAL_AMOUNT");
                }
                txtTotalPaid.Text = amountVal.ToString();
                txtTotalPayable.Text = totAmt.ToString();
                balAmt = totAmt - amountVal;
                txtBalance2.Text = balAmt.ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUdateRecord_Click(object sender, EventArgs e)
        {
            try
            {
                    string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                    MySqlConnection myConn = new MySqlConnection(myConnection);

                    string query = "UPDATE cpcdb.church_payables SET PAYMENT = '" + this.txtPaymentFor.Text + "', PERIOD = '" + this.txtPeriod.Text + "', AMOUNT = '" + this.txtAmtPaid.Text + "' where serial_no = '" + this.txtSerialNo.Text + "' ;";

                    MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                    MySqlDataReader myReader;
                    myConn.Open();

                    MessageBox.Show(query);
                    myReader = SelectCommand.ExecuteReader();

                    MessageBox.Show("Successfully Updated");
                    myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDefaullters_Click(object sender, EventArgs e)
        {
            amountVal = 0;
            totAmt = 0;
            balAmt = 0;

            if (this.cmbPeriod.Text == "ALL" && this.cmbPayment.Text == "ALL")
            {
                querySel = "select * from cpcdb.church_payables where (total_amount - amount) > 0;";
            }
            else if (this.cmbPayment.Text == "ALL" && this.cmbPeriod.Text != "ALL")
            {
                querySel = "select * from cpcdb.church_payables where period = '" + this.cmbPeriod.Text + "' and (total_amount - amount) > 0;";
            }
            else if (this.cmbPeriod.Text == "ALL" && this.cmbPayment.Text != "ALL")
            {
                querySel = "select * from cpcdb.church_payables where payment = '" + this.cmbPayment.Text + "' and (total_amount - amount) > 0;";
            }

            else
            {
                querySel = "select * from cpcdb.church_payables where period = '" + this.cmbPeriod.Text + "' and payment = '" + this.cmbPayment.Text + "' and (total_amount - amount) > 0;";
            }
            string myConnection = "datasource=localhost;port=3306;username=root;password=password";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            //string query = "select * from cpcdb.church_payables;";
            MySqlCommand dbCommand = new MySqlCommand(querySel, myConn);

            //MySqlCommand dbCommand = new MySqlCommand("select * from cpcdb.church_payables where (total_amount - amount) > 0;", myConn);

            try
            {
                MySqlDataAdapter sqlDataAdapt = new MySqlDataAdapter();
                sqlDataAdapt.SelectCommand = dbCommand;
                DataTable dbDataset = new DataTable();
                sqlDataAdapt.Fill(dbDataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataset;
                dgvUploadTable.DataSource = bSource;

                MySqlDataReader myReader;
                myConn.Open();
                myReader = dbCommand.ExecuteReader();

                while (myReader.Read())
                {
                    amountVal += myReader.GetDecimal("AMOUNT");
                    totAmt += myReader.GetDecimal("TOTAL_AMOUNT");
                }
                txtTotalPaid.Text = amountVal.ToString();
                txtTotalPayable.Text = totAmt.ToString();
                balAmt = totAmt - amountVal;
                txtBalance2.Text = balAmt.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            amountVal = 0;
            totAmt = 0;
            balAmt = 0;

            if (this.cmbPeriod.Text == "ALL" && this.cmbPayment.Text == "ALL")
            {
                querySel = "select * from cpcdb.church_payables where (total_amount - amount) = 0;";
            }
            else if (this.cmbPayment.Text == "ALL" && this.cmbPeriod.Text != "ALL")
            {
                querySel = "select * from cpcdb.church_payables where period = '" + this.cmbPeriod.Text + "' and (total_amount - amount) = 0;";
            }
            else if (this.cmbPeriod.Text == "ALL" && this.cmbPayment.Text != "ALL")
            {
                querySel = "select * from cpcdb.church_payables where payment = '" + this.cmbPayment.Text + "' and (total_amount - amount) = 0;";
            }

            else
            {
                querySel = "select * from cpcdb.church_payables where period = '" + this.cmbPeriod.Text + "' and payment = '" + this.cmbPayment.Text + "' and (total_amount - amount) = 0;";
            }
            string myConnection = "datasource=localhost;port=3306;username=root;password=password";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand dbCommand = new MySqlCommand(querySel, myConn);

            //MySqlCommand dbCommand = new MySqlCommand("select * from cpcdb.church_payables where (total_amount - amount) = 0;", myConn);

            try
            {
                MySqlDataAdapter sqlDataAdapt = new MySqlDataAdapter();
                sqlDataAdapt.SelectCommand = dbCommand;
                DataTable dbDataset = new DataTable();
                sqlDataAdapt.Fill(dbDataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataset;
                dgvUploadTable.DataSource = bSource;
                MySqlDataReader myReader;
                myConn.Open();
                myReader = dbCommand.ExecuteReader();
               
                while (myReader.Read())
                {
                    amountVal += myReader.GetDecimal("AMOUNT");
                    totAmt += myReader.GetDecimal("TOTAL_AMOUNT");
                }
                txtTotalPaid.Text = amountVal.ToString();
                txtTotalPayable.Text = totAmt.ToString();
                balAmt = totAmt - amountVal;
                txtBalance2.Text = balAmt.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUploadTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow tableRow = this.dgvUploadTable.Rows[e.RowIndex];

                txtSerialNo.Text = tableRow.Cells["serial_no"].Value.ToString();
                txtName.Text = tableRow.Cells["SURNAME"].Value.ToString();
                txtPaymentFor.Text = tableRow.Cells["PAYMENT"].Value.ToString();
                txtPeriod.Text = tableRow.Cells["PERIOD"].Value.ToString();
                txtAmtPaid.Text = tableRow.Cells["AMOUNT"].Value.ToString();
                string amt = tableRow.Cells["AMOUNT"].Value.ToString();
                string totAmt = tableRow.Cells["TOTAL_AMOUNT"].Value.ToString();
                decimal bal = Decimal.Parse(totAmt) - Decimal.Parse(amt);
                txtBalance.Text = bal.ToString();

                txtCreatedBy.Text = tableRow.Cells["CREATED_BY"].Value.ToString();
                txtDatePaid.Text = tableRow.Cells["DATE_CREATED"].Value.ToString();

                //
            }
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPayment = cmbPayment.Text;
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPeriod = cmbPayment.Text;
        }

        void autoCompleteSearchnameTxt()
        {
            txtSearchBySurname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchBySurname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.church_payables;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string strSurname = myReader.GetString("SURNAME");
                    coll.Add(strSurname);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtSearchBySurname.AutoCompleteCustomSource = coll;
        }

        private void txtSearchBySurname_TextChanged(object sender, EventArgs e)
        {
            DataView dView = new DataView(dbDataset);
            dView.RowFilter = string.Format("SURNAME LIKE '%{0}%'", txtSearchBySurname.Text);
            dgvUploadTable.DataSource = dView;
        }

        private void txtSerialNo_TextChanged(object sender, EventArgs e)
        {

        }

 
        
    }
}
