namespace ChurchRecord
{
    partial class frmHomePage2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTstripRegisterMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFinancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.createUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1323, 107);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTstripRegisterMembers,
            this.viewMembersToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripDropDownButton1.Image = global::ChurchRecord.Properties.Resources.member_regICON;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(113, 104);
            this.toolStripDropDownButton1.Text = "Registration";
            this.toolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTstripRegisterMembers
            // 
            this.btnTstripRegisterMembers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTstripRegisterMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnTstripRegisterMembers.Image")));
            this.btnTstripRegisterMembers.Name = "btnTstripRegisterMembers";
            this.btnTstripRegisterMembers.Size = new System.Drawing.Size(169, 22);
            this.btnTstripRegisterMembers.Text = "Register Members";
            this.btnTstripRegisterMembers.Click += new System.EventHandler(this.btnTstripRegisterMembers_Click);
            // 
            // viewMembersToolStripMenuItem
            // 
            this.viewMembersToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.viewMembersToolStripMenuItem.Name = "viewMembersToolStripMenuItem";
            this.viewMembersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewMembersToolStripMenuItem.Text = "View Members";
            this.viewMembersToolStripMenuItem.Click += new System.EventHandler(this.viewMembersToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.financeToolStripMenuItem,
            this.viewFinancesToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::ChurchRecord.Properties.Resources.Fina_Image22;
            this.toolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(113, 104);
            this.toolStripDropDownButton2.Text = "Financial Record";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.financeToolStripMenuItem.Text = "Create Fin. Record";
            this.financeToolStripMenuItem.Click += new System.EventHandler(this.financeToolStripMenuItem_Click);
            // 
            // viewFinancesToolStripMenuItem
            // 
            this.viewFinancesToolStripMenuItem.Name = "viewFinancesToolStripMenuItem";
            this.viewFinancesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.viewFinancesToolStripMenuItem.Text = "View Finances";
            this.viewFinancesToolStripMenuItem.Click += new System.EventHandler(this.viewFinancesToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUsersToolStripMenuItem,
            this.resetUsersToolStripMenuItem,
            this.manageUsersToolStripMenuItem1});
            this.toolStripDropDownButton3.Image = global::ChurchRecord.Properties.Resources.user_management_main;
            this.toolStripDropDownButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(133, 104);
            this.toolStripDropDownButton3.Text = "User Management";
            // 
            // createUsersToolStripMenuItem
            // 
            this.createUsersToolStripMenuItem.Name = "createUsersToolStripMenuItem";
            this.createUsersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.createUsersToolStripMenuItem.Text = "Create Users";
            this.createUsersToolStripMenuItem.Click += new System.EventHandler(this.createUsersToolStripMenuItem_Click);
            // 
            // resetUsersToolStripMenuItem
            // 
            this.resetUsersToolStripMenuItem.Name = "resetUsersToolStripMenuItem";
            this.resetUsersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.resetUsersToolStripMenuItem.Text = "Reset Users";
            this.resetUsersToolStripMenuItem.Click += new System.EventHandler(this.resetUsersToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem1
            // 
            this.manageUsersToolStripMenuItem1.Name = "manageUsersToolStripMenuItem1";
            this.manageUsersToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.manageUsersToolStripMenuItem1.Text = "Manage Users";
            this.manageUsersToolStripMenuItem1.Click += new System.EventHandler(this.manageUsersToolStripMenuItem1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.DarkBlue;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Lime;
            this.lblUsername.Location = new System.Drawing.Point(1177, 79);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 24);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelLeft.BackgroundImage = global::ChurchRecord.Properties.Resources.blueSportedColor;
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 107);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(119, 332);
            this.panelLeft.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BackgroundImage = global::ChurchRecord.Properties.Resources.blueSportedColor;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 332);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChurchRecord.Properties.Resources.welcome_icon100x1001;
            this.pictureBox1.Location = new System.Drawing.Point(1211, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmHomePage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 439);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmHomePage2";
            this.Text = "Home - Church Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHomePage2_Load);
            this.SizeChanged += new System.EventHandler(this.frmHomePage2_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHomePage2_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnTstripRegisterMembers;
        private System.Windows.Forms.ToolStripMenuItem viewMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFinancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem createUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
    }
}