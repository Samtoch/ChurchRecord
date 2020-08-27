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
    public partial class Form1 : Form
    {
        string genderSelected;
        string maritalsStatVal;
        string dayGrpVal;

        public Form1()
        {
            InitializeComponent();
            PopulateMaritSatCombo();
            PopulateSoceityCombo();
            PopulateDayGrpCombo();
            
        }

        void PopulateSoceityCombo()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.static_data where SOCIETY != '" + "" + "';";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string soceityVal = myReader.GetString("SOCIETY");
                    cmbSociety.Items.Add(soceityVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void PopulateDayGrpCombo()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.static_data where DAY_GROUP != '" + "" + "';";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string dayGrpVal = myReader.GetString("DAY_GROUP");
                    cmbDayGrp.Items.Add(dayGrpVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void PopulateMaritSatCombo()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.static_data where MARITAL_STATUS != '"+""+"';";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                 {
                    string maritStatVal = myReader.GetString("MARITAL_STATUS");
                    cmbMaritStatus.Items.Add(maritStatVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //myConn.Close();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            byte[] imageByte = null;
            FileStream fStream = new FileStream(this.textBox1.Text, FileMode.Open, FileAccess.Read);
            BinaryReader binReader = new BinaryReader(fStream);
            imageByte = binReader.ReadBytes((int)fStream.Length);

            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                //string query = "select * from cpcdb.member_details;";

                string query2 = "INSERT INTO cpcdb.member_details (SURNAME,OTHER_NAMES,RESIDENTIAL_ADDR, "+
                    "NATIONALITY,REGION,SOCIETY,GENDER,MARITAL_STATUS,DAY_GROUP,PHONE_NO,OCCUPATION,IMAGE,DATE_OF_BIRTH,EMAIL_ADDR) " +
                    " values  ('" + this.txtSurname.Text + "', '" + this.txtOtherNames.Text + "', '" + this.txtResidAddr.Text + "', "+
                    " '" + this.txtNationalty.Text + "', '" + this.txtRegionState.Text + "'" + "," + "'" + cmbSociety.Text + "', "+
                    " '" + genderSelected + "', '" + maritalsStatVal + "', '" + cmbDayGrp.Text + "', '" + txtPhoneNo.Text + "', "+
                    " '" + txtOccupation.Text + "', @IMG, '"+this.dtpDateOfBirth.Text+"', '"+this.txtEmailAddr.Text+"');"; 

                MySqlCommand SelectCommand = new MySqlCommand(query2, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                SelectCommand.Parameters.Add(new MySqlParameter("@IMG", imageByte));

                MessageBox.Show(query2);
                myReader = SelectCommand.ExecuteReader();
                if (txtSurname.Text == "")
                {
                    MessageBox.Show("The Surname field is Empty!");
                    //Form1 f1 = new Form1();
                    //f1.ShowDialog();
                    //MessageBox.Show("Kindly close to continue");
                }
                MessageBox.Show("Successfully Uploaded");
                myConn.Close();

            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message);
            }
         }

        private void cmbMaritStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.static_data where MARITAL_STATUS = '" + cmbMaritStatus.Text + "'  ;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    maritalsStatVal = myReader.GetString("MARITAL_STATUS");
                    cmbMaritStatus.Text = maritalsStatVal;
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSociety_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.static_data where SOCIETY = '" + cmbSociety.Text + "' ;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                /*while (myReader.Read())
                {
                    dayGrpVal = myReader.GetString("DAY_GROUP");
                    cmbDayGrp.Text = dayGrpVal;
                }*/
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //dlg.Filter = "JPG Files(*.jpg)|*.jpg |PNG Files(*.png)|*.png |All Files(*.*)|*.*";
            dlg.Filter = "All Files |*.*|Jpeg|*.jpg|Bitmaps|*.bmp|Gifs|*.gif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string pixPath = dlg.FileName.ToString();
                textBox1.Text = pixPath;
                pictureBox1.ImageLocation = pixPath;
            }
        }

        private void cmbDayGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.static_data where DAY_GROUP = '" + cmbDayGrp.Text + "' ;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    dayGrpVal = myReader.GetString("DAY_GROUP");
                    cmbDayGrp.Text = dayGrpVal;
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radGenger_CheckedChanged(object sender, EventArgs e)
        {
            genderSelected = "Female";
        }

        private void radGender2_CheckedChanged(object sender, EventArgs e)
        {
            genderSelected = "Male";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Exit (Form1)?", "Exit", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                this.Hide();
                frmHomePage homepg = new frmHomePage();
                homepg.ShowDialog();

            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
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
