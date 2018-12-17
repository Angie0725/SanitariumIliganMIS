namespace LogIn
{
    partial class StaffWardAllocation
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
            this.panelheader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlstafflist = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnselect = new System.Windows.Forms.Button();
            this.dgvstafflist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvwardallocation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearchstaff = new System.Windows.Forms.Button();
            this.lblfullname = new System.Windows.Forms.Label();
            this.dtpdateassigned = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbward = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtstaffnumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnchoosestaff = new System.Windows.Forms.Button();
            this.btnupdatedesig = new System.Windows.Forms.Button();
            this.panelheader.SuspendLayout();
            this.pnlstafflist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstafflist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwardallocation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelheader.Controls.Add(this.label4);
            this.panelheader.Controls.Add(this.label3);
            this.panelheader.Location = new System.Drawing.Point(-4, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1091, 100);
            this.panelheader.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 43);
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
            this.label3.Location = new System.Drawing.Point(14, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "SANITARIUM HOSPITAL";
            // 
            // pnlstafflist
            // 
            this.pnlstafflist.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlstafflist.Controls.Add(this.label5);
            this.pnlstafflist.Controls.Add(this.btnselect);
            this.pnlstafflist.Controls.Add(this.dgvstafflist);
            this.pnlstafflist.Location = new System.Drawing.Point(110, 112);
            this.pnlstafflist.Name = "pnlstafflist";
            this.pnlstafflist.Size = new System.Drawing.Size(863, 343);
            this.pnlstafflist.TabIndex = 10;
            this.pnlstafflist.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlstafflist_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "STAFF LIST";
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnselect.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.Location = new System.Drawing.Point(345, 303);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(173, 28);
            this.btnselect.TabIndex = 50;
            this.btnselect.Text = "SELECT STAFF";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // dgvstafflist
            // 
            this.dgvstafflist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvstafflist.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvstafflist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstafflist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.TELNUMBER,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvstafflist.Location = new System.Drawing.Point(39, 39);
            this.dgvstafflist.Name = "dgvstafflist";
            this.dgvstafflist.RowHeadersVisible = false;
            this.dgvstafflist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstafflist.Size = new System.Drawing.Size(785, 258);
            this.dgvstafflist.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STAFF_NUM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 96;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "FIRSTNAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 94;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "LASTNAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ADDRESS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 84;
            // 
            // TELNUMBER
            // 
            this.TELNUMBER.HeaderText = "TELNUMBER";
            this.TELNUMBER.Name = "TELNUMBER";
            this.TELNUMBER.Width = 99;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "BIRTHDATE";
            this.Column5.Name = "Column5";
            this.Column5.Width = 94;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SEX";
            this.Column6.Name = "Column6";
            this.Column6.Width = 53;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "NIN";
            this.Column7.Name = "Column7";
            this.Column7.Width = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(498, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "Staff Allocation List:";
            // 
            // dgvwardallocation
            // 
            this.dgvwardallocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvwardallocation.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvwardallocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwardallocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column4});
            this.dgvwardallocation.Location = new System.Drawing.Point(502, 150);
            this.dgvwardallocation.Name = "dgvwardallocation";
            this.dgvwardallocation.RowHeadersVisible = false;
            this.dgvwardallocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwardallocation.Size = new System.Drawing.Size(572, 287);
            this.dgvwardallocation.TabIndex = 41;
            this.dgvwardallocation.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwardallocation_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STAFF_NUM";
            this.Column1.Name = "Column1";
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "STAFF_NAME";
            this.Column2.Name = "Column2";
            this.Column2.Width = 102;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "WARD_NUM";
            this.Column8.Name = "Column8";
            this.Column8.Width = 97;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DESIGNATION";
            this.Column3.Name = "Column3";
            this.Column3.Width = 106;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DATE_ASSIGNED";
            this.Column4.Name = "Column4";
            this.Column4.Width = 122;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnsearchstaff);
            this.groupBox1.Controls.Add(this.lblfullname);
            this.groupBox1.Controls.Add(this.dtpdateassigned);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbward);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtstaffnumber);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 258);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STAFF INFORMATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 14);
            this.label1.TabIndex = 52;
            this.label1.Text = "*For new staff assignments, click the SEARCH button.";
            // 
            // btnsearchstaff
            // 
            this.btnsearchstaff.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsearchstaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearchstaff.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchstaff.Location = new System.Drawing.Point(380, 66);
            this.btnsearchstaff.Name = "btnsearchstaff";
            this.btnsearchstaff.Size = new System.Drawing.Size(70, 22);
            this.btnsearchstaff.TabIndex = 51;
            this.btnsearchstaff.Text = "SEARCH";
            this.btnsearchstaff.UseVisualStyleBackColor = false;
            this.btnsearchstaff.Click += new System.EventHandler(this.btnsearchstaff_Click);
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.Location = new System.Drawing.Point(227, 98);
            this.lblfullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(98, 14);
            this.lblfullname.TabIndex = 51;
            this.lblfullname.Text = "STAFF FULL NAME";
            // 
            // dtpdateassigned
            // 
            this.dtpdateassigned.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdateassigned.Location = new System.Drawing.Point(230, 177);
            this.dtpdateassigned.Name = "dtpdateassigned";
            this.dtpdateassigned.Size = new System.Drawing.Size(220, 22);
            this.dtpdateassigned.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 14);
            this.label8.TabIndex = 22;
            this.label8.Text = "DATE ASSIGNED:";
            // 
            // cbward
            // 
            this.cbward.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbward.FormattingEnabled = true;
            this.cbward.Location = new System.Drawing.Point(230, 134);
            this.cbward.Name = "cbward";
            this.cbward.Size = new System.Drawing.Size(220, 22);
            this.cbward.TabIndex = 21;
            this.cbward.SelectedIndexChanged += new System.EventHandler(this.cbward_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 136);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "CURRENT DESIGNATION:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 14);
            this.label14.TabIndex = 6;
            this.label14.Text = "STAFF FULL NAME:";
            // 
            // txtstaffnumber
            // 
            this.txtstaffnumber.Enabled = false;
            this.txtstaffnumber.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstaffnumber.Location = new System.Drawing.Point(230, 66);
            this.txtstaffnumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtstaffnumber.Name = "txtstaffnumber";
            this.txtstaffnumber.Size = new System.Drawing.Size(143, 22);
            this.txtstaffnumber.TabIndex = 5;
            this.txtstaffnumber.TextChanged += new System.EventHandler(this.txtstaffnumber_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 69);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 14);
            this.label15.TabIndex = 4;
            this.label15.Text = "STAFF NUMBER:";
            // 
            // btnchoosestaff
            // 
            this.btnchoosestaff.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnchoosestaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchoosestaff.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchoosestaff.Location = new System.Drawing.Point(17, 397);
            this.btnchoosestaff.Name = "btnchoosestaff";
            this.btnchoosestaff.Size = new System.Drawing.Size(232, 40);
            this.btnchoosestaff.TabIndex = 49;
            this.btnchoosestaff.Text = "ASSIGN A NEW STAFF";
            this.btnchoosestaff.UseVisualStyleBackColor = false;
            this.btnchoosestaff.Click += new System.EventHandler(this.btnchoosestaff_Click);
            // 
            // btnupdatedesig
            // 
            this.btnupdatedesig.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnupdatedesig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdatedesig.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatedesig.Location = new System.Drawing.Point(259, 397);
            this.btnupdatedesig.Name = "btnupdatedesig";
            this.btnupdatedesig.Size = new System.Drawing.Size(232, 40);
            this.btnupdatedesig.TabIndex = 50;
            this.btnupdatedesig.Text = "UPDATE DESIGNATION";
            this.btnupdatedesig.UseVisualStyleBackColor = false;
            this.btnupdatedesig.Click += new System.EventHandler(this.btnupdatedesig_Click);
            // 
            // StaffWardAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1086, 467);
            this.Controls.Add(this.pnlstafflist);
            this.Controls.Add(this.btnupdatedesig);
            this.Controls.Add(this.btnchoosestaff);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvwardallocation);
            this.Controls.Add(this.panelheader);
            this.Name = "StaffWardAllocation";
            this.Text = "STAFF-WARD ALLOCATION";
            this.Load += new System.EventHandler(this.StaffWardAllocation_Load);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.pnlstafflist.ResumeLayout(false);
            this.pnlstafflist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstafflist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwardallocation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvwardallocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbward;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtstaffnumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpdateassigned;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnchoosestaff;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Button btnsearchstaff;
        private System.Windows.Forms.Button btnupdatedesig;
        private System.Windows.Forms.Panel pnlstafflist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.DataGridView dgvstafflist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELNUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
    }
}