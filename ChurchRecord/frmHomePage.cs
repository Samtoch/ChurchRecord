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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnMembReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnFinReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void frmHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want to Exit (XXXX Home Page)?", "Exit", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void frmHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult dialog = MessageBox.Show("Do You Really Want to Exit?", "Exit", MessageBoxButtons.OKCancel);
            //if (dialog == DialogResult.OK)
            //{
            //    Application.Exit();
            //}
            //else if (dialog == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {

        }

        
    }
}
