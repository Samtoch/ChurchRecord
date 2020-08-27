namespace ChurchRecord
{
    partial class frmInventory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateRegistered = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCostOfItem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegistered = new System.Windows.Forms.TextBox();
            this.dtpDatePurchased = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbSatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProperty = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDateRegistered);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCostOfItem);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRegistered);
            this.groupBox1.Controls.Add(this.dtpDatePurchased);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cmbSatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProperty);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(375, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 414);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Details";
            // 
            // dtpDateRegistered
            // 
            this.dtpDateRegistered.CustomFormat = "yyyy-MM-dd";
            this.dtpDateRegistered.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateRegistered.Location = new System.Drawing.Point(247, 254);
            this.dtpDateRegistered.Name = "dtpDateRegistered";
            this.dtpDateRegistered.Size = new System.Drawing.Size(140, 26);
            this.dtpDateRegistered.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 19);
            this.label7.TabIndex = 125;
            this.label7.Text = "Cost Per Item(GHC):";
            // 
            // txtCostOfItem
            // 
            this.txtCostOfItem.Location = new System.Drawing.Point(247, 168);
            this.txtCostOfItem.Name = "txtCostOfItem";
            this.txtCostOfItem.Size = new System.Drawing.Size(140, 26);
            this.txtCostOfItem.TabIndex = 3;
            this.txtCostOfItem.Tag = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 130;
            this.label8.Text = "Registered By:";
            // 
            // txtRegistered
            // 
            this.txtRegistered.Location = new System.Drawing.Point(247, 294);
            this.txtRegistered.Name = "txtRegistered";
            this.txtRegistered.Size = new System.Drawing.Size(140, 26);
            this.txtRegistered.TabIndex = 6;
            this.txtRegistered.Tag = " ";
            // 
            // dtpDatePurchased
            // 
            this.dtpDatePurchased.CustomFormat = "yyyy-MM-dd";
            this.dtpDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePurchased.Location = new System.Drawing.Point(247, 210);
            this.dtpDatePurchased.Name = "dtpDatePurchased";
            this.dtpDatePurchased.Size = new System.Drawing.Size(140, 26);
            this.dtpDatePurchased.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 127;
            this.label6.Text = "Date Registered";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 31);
            this.button1.TabIndex = 123;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(89, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSatus
            // 
            this.cmbSatus.FormattingEnabled = true;
            this.cmbSatus.Location = new System.Drawing.Point(247, 125);
            this.cmbSatus.Name = "cmbSatus";
            this.cmbSatus.Size = new System.Drawing.Size(140, 27);
            this.cmbSatus.TabIndex = 2;
            this.cmbSatus.SelectedIndexChanged += new System.EventHandler(this.cmbSatus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "Date Purchased:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(247, 79);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(140, 26);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Tag = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Property:";
            // 
            // txtProperty
            // 
            this.txtProperty.Location = new System.Drawing.Point(247, 39);
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.Size = new System.Drawing.Size(140, 26);
            this.txtProperty.TabIndex = 0;
            this.txtProperty.Tag = " ";
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 555);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInventory";
            this.Text = "Inventory - Church Manager";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDatePurchased;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCostOfItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbSatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProperty;
        private System.Windows.Forms.DateTimePicker dtpDateRegistered;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRegistered;
    }
}