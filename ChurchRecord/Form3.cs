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
    public partial class Form3 : Form
    {
        string maritalsStatVal;
        string dayGrpVal;

        public Form3()
        {
            InitializeComponent();
            PopulateNameCombo();
        }

        void PopulateNameCombo() 
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.member_details;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string surnameVal = myReader.GetString("SURNAME");
                    cmbSurNameSearch.Items.Add(surnameVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cmbSurNameSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=password";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                string query = "select * from cpcdb.member_details where SURNAME = '"+ cmbSurNameSearch.Text +"' ;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string genderVal = myReader.GetString("GENDER");
                    string surnameVal = myReader.GetString("SURNAME");
                    string othernamesVal = myReader.GetString("OTHER_NAMES");
                    string maritalStatVal = myReader.GetString("MARITAL_STATUS");
                    string dayGrpVal = myReader.GetString("DAY_GROUP");
                    string societyVal = myReader.GetString("SOCIETY");
                    string regionVal = myReader.GetString("REGION");
                    string hometownVal = myReader.GetString("HOME_TOWN");
                    string residAddrVal = myReader.GetString("RESIDENTIAL_ADDR");
                    string emailAddVal = myReader.GetString("EMAIL_ADDR");
                    string phoneNoVal = myReader.GetString("PHONE_NO");
                    string occupationVal = myReader.GetString("OCCUPATION");
                    string dateCreatedVal = myReader.GetString("DATE_CREATED");
                    string statusVal = myReader.GetString("STATUS");
                    string posInChurchVal = myReader.GetString("POSITION");
                    string ageVal = myReader.GetString("AGE");
                    string nationVal = myReader.GetString("NATIONALITY");
                    txtGender.Text = genderVal;
                    txtSurname.Text = surnameVal;
                    txtOtherNames.Text = othernamesVal;
                    txtMaritStatus.Text = maritalStatVal;
                    txtDayBonGrp.Text = dayGrpVal;
                    txtSociety.Text = societyVal;
                    txtRegionState.Text = regionVal;
                    txtHomeTown.Text = hometownVal;
                    txtResidAddr.Text = residAddrVal;
                    txtEmailAddr.Text = emailAddVal;
                    txtPhoneNo.Text = phoneNoVal;
                    txtOccupation.Text = occupationVal;
                    txtPosition.Text = posInChurchVal;
                    txtDateCreated.Text = dateCreatedVal;
                    txtStatus.Text = statusVal;
                    txtNationalty.Text = nationVal;

                    byte[] imageVal = (byte[])(myReader["IMAGE"]);
                    if (imageVal == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream memStream = new MemoryStream(imageVal);

                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image = System.Drawing.Image.FromStream(memStream);
                        //PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Exit","Exit", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                this.Hide();
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
