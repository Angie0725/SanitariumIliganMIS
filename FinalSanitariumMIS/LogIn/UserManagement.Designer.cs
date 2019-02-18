namespace LogIn
{
    partial class UserManagement
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtstaffnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblstaffname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbaccttype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgusers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncreateacct = new System.Windows.Forms.Button();
            this.btnupdateacct = new System.Windows.Forms.Button();
            this.btnremoveacct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgusers)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Management Information System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "SANITARIUM HOSPITAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 100);
            this.panel1.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 71);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 14);
            this.label15.TabIndex = 56;
            this.label15.Text = "STAFF NUMBER:";
            // 
            // txtstaffnum
            // 
            this.txtstaffnum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstaffnum.Location = new System.Drawing.Point(144, 68);
            this.txtstaffnum.Margin = new System.Windows.Forms.Padding(4);
            this.txtstaffnum.Name = "txtstaffnum";
            this.txtstaffnum.Size = new System.Drawing.Size(160, 22);
            this.txtstaffnum.TabIndex = 2;
            this.txtstaffnum.TextChanged += new System.EventHandler(this.txtstaffnum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 59;
            this.label1.Text = "User ID:";
            // 
            // txtuserid
            // 
            this.txtuserid.Enabled = false;
            this.txtuserid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserid.Location = new System.Drawing.Point(144, 34);
            this.txtuserid.Margin = new System.Windows.Forms.Padding(4);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(160, 22);
            this.txtuserid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 14);
            this.label7.TabIndex = 79;
            this.label7.Text = "USERNAME:";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.PaleGreen;
            this.txtusername.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(144, 124);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(160, 22);
            this.txtusername.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 85;
            this.label6.Text = "PASSWORD:";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.PaleGreen;
            this.txtpassword.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(144, 154);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(160, 22);
            this.txtpassword.TabIndex = 5;
            // 
            // lblstaffname
            // 
            this.lblstaffname.AutoSize = true;
            this.lblstaffname.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstaffname.Location = new System.Drawing.Point(141, 94);
            this.lblstaffname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstaffname.Name = "lblstaffname";
            this.lblstaffname.Size = new System.Drawing.Size(107, 14);
            this.lblstaffname.TabIndex = 96;
            this.lblstaffname.Text = "STAFF FULL NAME...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbaccttype);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblstaffname);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtusername);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtuserid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtstaffnum);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 230);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USER INFORMATION";
            // 
            // cbaccttype
            // 
            this.cbaccttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbaccttype.FormattingEnabled = true;
            this.cbaccttype.Location = new System.Drawing.Point(144, 189);
            this.cbaccttype.Name = "cbaccttype";
            this.cbaccttype.Size = new System.Drawing.Size(160, 23);
            this.cbaccttype.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 14);
            this.label5.TabIndex = 97;
            this.label5.Text = "ACCOUNT TYPE:";
            // 
            // dgusers
            // 
            this.dgusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgusers.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgusers.Location = new System.Drawing.Point(347, 144);
            this.dgusers.Name = "dgusers";
            this.dgusers.RowHeadersVisible = false;
            this.dgusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgusers.Size = new System.Drawing.Size(430, 203);
            this.dgusers.TabIndex = 93;
            this.dgusers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgusers_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "UserID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "StaffNumber";
            this.Column2.Name = "Column2";
            this.Column2.Width = 91;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Username";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Password";
            this.Column4.Name = "Column4";
            this.Column4.Width = 78;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "AccountType";
            this.Column5.Name = "Column5";
            this.Column5.Width = 96;
            // 
            // btncreateacct
            // 
            this.btncreateacct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btncreateacct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncreateacct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateacct.Location = new System.Drawing.Point(21, 353);
            this.btncreateacct.Name = "btncreateacct";
            this.btncreateacct.Size = new System.Drawing.Size(320, 35);
            this.btncreateacct.TabIndex = 94;
            this.btncreateacct.Text = "CREATE ACCOUNT";
            this.btncreateacct.UseVisualStyleBackColor = false;
            this.btncreateacct.Click += new System.EventHandler(this.btncreateacct_Click);
            // 
            // btnupdateacct
            // 
            this.btnupdateacct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnupdateacct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdateacct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateacct.Location = new System.Drawing.Point(347, 353);
            this.btnupdateacct.Name = "btnupdateacct";
            this.btnupdateacct.Size = new System.Drawing.Size(212, 35);
            this.btnupdateacct.TabIndex = 95;
            this.btnupdateacct.Text = "UPDATE ACCOUNT";
            this.btnupdateacct.UseVisualStyleBackColor = false;
            this.btnupdateacct.Click += new System.EventHandler(this.btnupdateacct_Click);
            // 
            // btnremoveacct
            // 
            this.btnremoveacct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnremoveacct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremoveacct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveacct.Location = new System.Drawing.Point(565, 353);
            this.btnremoveacct.Name = "btnremoveacct";
            this.btnremoveacct.Size = new System.Drawing.Size(212, 35);
            this.btnremoveacct.TabIndex = 96;
            this.btnremoveacct.Text = "REMOVE ACCOUNT";
            this.btnremoveacct.UseVisualStyleBackColor = false;
            this.btnremoveacct.Click += new System.EventHandler(this.btnremoveacct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 97;
            this.label2.Text = "USER ACCOUNTS:";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnremoveacct);
            this.Controls.Add(this.btnupdateacct);
            this.Controls.Add(this.btncreateacct);
            this.Controls.Add(this.dgusers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "UserManagement";
            this.Text = "USER MANAGEMENT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMgt_FormClosing);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtstaffnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblstaffname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgusers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btncreateacct;
        private System.Windows.Forms.Button btnupdateacct;
        private System.Windows.Forms.Button btnremoveacct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cbaccttype;
    }
}