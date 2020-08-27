namespace ChurchRecord
{
    partial class frmViewInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchByItem = new System.Windows.Forms.TextBox();
            this.btnUdateRecord = new System.Windows.Forms.Button();
            this.dgvUploadTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisteredBy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDateRegistered = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatePurchased = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCostofItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUploadTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(351, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 19);
            this.label12.TabIndex = 198;
            this.label12.Text = "ITEM:";
            // 
            // txtSearchByItem
            // 
            this.txtSearchByItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByItem.Location = new System.Drawing.Point(414, 21);
            this.txtSearchByItem.Name = "txtSearchByItem";
            this.txtSearchByItem.Size = new System.Drawing.Size(172, 26);
            this.txtSearchByItem.TabIndex = 197;
            this.txtSearchByItem.TextChanged += new System.EventHandler(this.txtSearchByItem_TextChanged);
            this.txtSearchByItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByItem_KeyPress);
            // 
            // btnUdateRecord
            // 
            this.btnUdateRecord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUdateRecord.Location = new System.Drawing.Point(157, 381);
            this.btnUdateRecord.Name = "btnUdateRecord";
            this.btnUdateRecord.Size = new System.Drawing.Size(73, 31);
            this.btnUdateRecord.TabIndex = 188;
            this.btnUdateRecord.Text = "Update";
            this.btnUdateRecord.UseVisualStyleBackColor = true;
            this.btnUdateRecord.Click += new System.EventHandler(this.btnUdateRecord_Click);
            // 
            // dgvUploadTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUploadTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUploadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUploadTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUploadTable.Location = new System.Drawing.Point(352, 51);
            this.dgvUploadTable.Name = "dgvUploadTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUploadTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUploadTable.Size = new System.Drawing.Size(826, 361);
            this.dgvUploadTable.TabIndex = 186;
            this.dgvUploadTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUploadTable_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 185;
            this.label3.Text = "Registered by:";
            // 
            // txtRegisteredBy
            // 
            this.txtRegisteredBy.Location = new System.Drawing.Point(157, 335);
            this.txtRegisteredBy.Name = "txtRegisteredBy";
            this.txtRegisteredBy.Size = new System.Drawing.Size(159, 20);
            this.txtRegisteredBy.TabIndex = 184;
            this.txtRegisteredBy.Tag = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 183;
            this.label8.Text = "Date Registered:";
            // 
            // txtDateRegistered
            // 
            this.txtDateRegistered.Location = new System.Drawing.Point(157, 294);
            this.txtDateRegistered.Name = "txtDateRegistered";
            this.txtDateRegistered.Size = new System.Drawing.Size(159, 20);
            this.txtDateRegistered.TabIndex = 182;
            this.txtDateRegistered.Tag = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 181;
            this.label6.Text = "Date Purchased:";
            // 
            // txtDatePurchased
            // 
            this.txtDatePurchased.Location = new System.Drawing.Point(157, 252);
            this.txtDatePurchased.Name = "txtDatePurchased";
            this.txtDatePurchased.Size = new System.Drawing.Size(159, 20);
            this.txtDatePurchased.TabIndex = 180;
            this.txtDatePurchased.Tag = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 179;
            this.label7.Text = "Per Item Cost :";
            // 
            // txtCostofItem
            // 
            this.txtCostofItem.Location = new System.Drawing.Point(157, 210);
            this.txtCostofItem.Name = "txtCostofItem";
            this.txtCostofItem.Size = new System.Drawing.Size(159, 20);
            this.txtCostofItem.TabIndex = 178;
            this.txtCostofItem.Tag = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 176;
            this.label5.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(157, 170);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(159, 20);
            this.txtStatus.TabIndex = 175;
            this.txtStatus.Tag = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 174;
            this.label4.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(157, 127);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(159, 20);
            this.txtQuantity.TabIndex = 173;
            this.txtQuantity.Tag = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 170;
            this.label1.Text = "Item:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(157, 90);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(159, 20);
            this.txtItem.TabIndex = 169;
            this.txtItem.Tag = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 200;
            this.label2.Text = "Serial No:";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(157, 50);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(159, 20);
            this.txtSerialNo.TabIndex = 199;
            this.txtSerialNo.Tag = " ";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(236, 381);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(80, 31);
            this.btnReload.TabIndex = 201;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmViewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 517);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSearchByItem);
            this.Controls.Add(this.btnUdateRecord);
            this.Controls.Add(this.dgvUploadTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegisteredBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDateRegistered);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDatePurchased);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCostofItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItem);
            this.Name = "frmViewInventory";
            this.Text = "View Inventory - Church Manager";
            this.Load += new System.EventHandler(this.frmViewInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUploadTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchByItem;
        private System.Windows.Forms.Button btnUdateRecord;
        private System.Windows.Forms.DataGridView dgvUploadTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegisteredBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDateRegistered;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDatePurchased;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCostofItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Button btnReload;
    }
}