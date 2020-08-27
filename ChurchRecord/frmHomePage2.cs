using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchRecord
{
    public partial class frmHomePage2 : Form
    {
        public frmHomePage2(string user)
        //int x = 1232;
        //int y = -12;
        
        //this.toolStrip1.Size = new System.Drawing.Size(1323, 107);

        //public frmHomePage2()
        {
            //string user = "Samtech";
            InitializeComponent();
            //int Fy = this.Height;
            //int Fx = this.Width;
            //int ty = this.toolStrip1.Size.Height;
            //int tx = this.toolStrip1.Size.Width;
            //MessageBox.Show("The values of height and width are "+ Fy +" and "+ Fx);

            


            lblUsername.Text = "Welcome " + user;
        }

        private void frmHomePage2_Load(object sender, EventArgs e)
        {

        }

        private void btnTstripRegisterMembers_Click(object sender, EventArgs e)
        {
            Form1 memberReg = new Form1();
            memberReg.MdiParent = this;
            memberReg.Show();
        }

        private void frmHomePage2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Close Application?", "Close!!!", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 viewMemberReg = new Form3();
            viewMemberReg.MdiParent = this;
            viewMemberReg.Show();
        }

        private void viewFinancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 viewPayment = new Form6();
            viewPayment.MdiParent = this;
            viewPayment.Show();
        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 creatPaymentFrm = new Form5();
            creatPaymentFrm.MdiParent = this;
            creatPaymentFrm.Show();
        }

        private void createUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userCreationMain frmUserCreation = new userCreationMain();
            frmUserCreation.MdiParent = this;
            frmUserCreation.Show();
        }

        private void resetUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordReset frmPasswordRst = new passwordReset();
            frmPasswordRst.MdiParent = this;
            frmPasswordRst.Show();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmHomePage2_SizeChanged(object sender, EventArgs e)
        {
            int Fy = this.Height;
            int Fx = this.Width;

            //MessageBox.Show("The values of height and width are " + Fy + " and " + Fx);

            this.pictureBox1.Location = new System.Drawing.Point(Fx - 150, -12);
            this.lblUsername.Location = new System.Drawing.Point(Fx -180, 79);
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void manageUsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManageUsers manageUser = new frmManageUsers();
            manageUser.MdiParent = this;
            manageUser.Show();
        }

    }
}
