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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            populatePaymentCombo();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        void populatePaymentCombo() 
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.static_data where PAYMENT is not null;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string paymentVal = myReader.GetString("PAYMENT");
                    cmbPayment.Items.Add(paymentVal);
                    
                    //if (paymentVal == "" || paymentVal == null)
                    //{
                    //    //MessageBox.Show(paymentVal);
                        
                    //    //break;
                    //}
                    //else 
                    //{
                    //    break;
                    //}
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSurname.Text == "")
                {
                    MessageBox.Show("The Surname field is Empty!");
                    txtSurname.Focus();
                    //Form1 f1 = new Form1();
                    //f1.ShowDialog();
                    //MessageBox.Show("Kindly close to continue");
                }
                else
                {
                    string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    //string query = "select * from cpcdb.member_details;";

                    string query = "INSERT INTO cpcdb.church_payables (SERIAL_NO,SURNAME,OTHER_NAMES,PAYMENT,PERIOD,AMOUNT,TOTAL_AMOUNT) " +
                        " values  ('" + this.txtSerialNo.Text + "', '" + this.txtSurname.Text + "', '" + this.txtOtherNames.Text + "', " +
                        " '" + this.cmbPayment.Text + "', '" + this.dtpPeriod.Text + "', '" + this.txtAmtPaid.Text + "', '" + this.txtTotalPayable.Text + "');";

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

        private bool IsFilled(string s)
        {
            if (s != "")
            { return true; }
            else
            { return false; }
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char surnameChar = e.KeyChar;
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Field cannot be number");
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want to Exit?","Exit",MessageBoxButtons.OKCancel);
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
