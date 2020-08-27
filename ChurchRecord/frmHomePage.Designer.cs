namespace ChurchRecord
{
    partial class frmHomePage
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
            this.btnMembReg = new System.Windows.Forms.Button();
            this.btnFinReg = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnViewFinances = new System.Windows.Forms.Button();
            this.btnViewReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMembReg
            // 
            this.btnMembReg.Location = new System.Drawing.Point(132, 66);
            this.btnMembReg.Name = "btnMembReg";
            this.btnMembReg.Size = new System.Drawing.Size(182, 166);
            this.btnMembReg.TabIndex = 0;
            this.btnMembReg.Text = "Member Registration";
            this.btnMembReg.UseVisualStyleBackColor = true;
            this.btnMembReg.Click += new System.EventHandler(this.btnMembReg_Click);
            // 
            // btnFinReg
            // 
            this.btnFinReg.Location = new System.Drawing.Point(320, 66);
            this.btnFinReg.Name = "btnFinReg";
            this.btnFinReg.Size = new System.Drawing.Size(182, 166);
            this.btnFinReg.TabIndex = 1;
            this.btnFinReg.Text = "Finance Registration";
            this.btnFinReg.UseVisualStyleBackColor = true;
            this.btnFinReg.Click += new System.EventHandler(this.btnFinReg_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(508, 66);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(182, 166);
            this.btnMaintenance.TabIndex = 2;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnViewFinances
            // 
            this.btnViewFinances.Location = new System.Drawing.Point(405, 238);
            this.btnViewFinances.Name = "btnViewFinances";
            this.btnViewFinances.Size = new System.Drawing.Size(182, 166);
            this.btnViewFinances.TabIndex = 3;
            this.btnViewFinances.Text = "View Finances";
            this.btnViewFinances.UseVisualStyleBackColor = true;
            // 
            // btnViewReg
            // 
            this.btnViewReg.Location = new System.Drawing.Point(217, 238);
            this.btnViewReg.Name = "btnViewReg";
            this.btnViewReg.Size = new System.Drawing.Size(182, 166);
            this.btnViewReg.TabIndex = 4;
            this.btnViewReg.Text = "View Registrations";
            this.btnViewReg.UseVisualStyleBackColor = true;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 454);
            this.Controls.Add(this.btnViewReg);
            this.Controls.Add(this.btnViewFinances);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnFinReg);
            this.Controls.Add(this.btnMembReg);
            this.Name = "frmHomePage";
            this.Text = "Church Manager - Home Page";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHomePage_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHomePage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMembReg;
        private System.Windows.Forms.Button btnFinReg;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnViewFinances;
        private System.Windows.Forms.Button btnViewReg;


    }
}