namespace LogIn
{
    partial class InPatients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlpatientlist = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnclosepatients = new System.Windows.Forms.Button();
            this.dgpatientlist = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlwaitlist = new System.Windows.Forms.Panel();
            this.btnaddtowait = new System.Windows.Forms.Button();
            this.txtwaitpatient = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.dgwaitlist = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dginpatients = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnviewpatients = new System.Windows.Forms.Button();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpinward = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbeds = new System.Windows.Forms.ComboBox();
            this.dtpdatearrived = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpatientnum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnadmitpatient = new System.Windows.Forms.Button();
            this.btnwaitlist = new System.Windows.Forms.Button();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlpatientlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpatientlist)).BeginInit();
            this.pnlwaitlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwaitlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dginpatients)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 100);
            this.panel1.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 49);
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
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "SANITARIUM HOSPITAL";
            // 
            // pnlpatientlist
            // 
            this.pnlpatientlist.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlpatientlist.Controls.Add(this.label8);
            this.pnlpatientlist.Controls.Add(this.btnclosepatients);
            this.pnlpatientlist.Controls.Add(this.dgpatientlist);
            this.pnlpatientlist.Controls.Add(this.label13);
            this.pnlpatientlist.Location = new System.Drawing.Point(103, 106);
            this.pnlpatientlist.Name = "pnlpatientlist";
            this.pnlpatientlist.Size = new System.Drawing.Size(739, 399);
            this.pnlpatientlist.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 15);
            this.label8.TabIndex = 86;
            this.label8.Text = "*Double-Click a record to get Patient Information.";
            // 
            // btnclosepatients
            // 
            this.btnclosepatients.BackColor = System.Drawing.Color.Pink;
            this.btnclosepatients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclosepatients.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosepatients.Location = new System.Drawing.Point(689, 3);
            this.btnclosepatients.Name = "btnclosepatients";
            this.btnclosepatients.Size = new System.Drawing.Size(47, 31);
            this.btnclosepatients.TabIndex = 85;
            this.btnclosepatients.Text = "X";
            this.btnclosepatients.UseVisualStyleBackColor = false;
            this.btnclosepatients.Click += new System.EventHandler(this.btnclosepatients_Click);
            // 
            // dgpatientlist
            // 
            this.dgpatientlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgpatientlist.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgpatientlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpatientlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.dgpatientlist.Location = new System.Drawing.Point(24, 81);
            this.dgpatientlist.Name = "dgpatientlist";
            this.dgpatientlist.RowHeadersVisible = false;
            this.dgpatientlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgpatientlist.Size = new System.Drawing.Size(689, 296);
            this.dgpatientlist.TabIndex = 84;
            this.dgpatientlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgpatientlist_CellDoubleClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "PID";
            this.Column11.Name = "Column11";
            this.Column11.Width = 50;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "FIRSTNAME";
            this.Column12.Name = "Column12";
            this.Column12.Width = 94;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "LASTNAME";
            this.Column13.Name = "Column13";
            this.Column13.Width = 90;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "ADDRESS";
            this.Column14.Name = "Column14";
            this.Column14.Width = 84;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "TELNUMBER";
            this.Column15.Name = "Column15";
            this.Column15.Width = 99;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "BIRTHDATE";
            this.Column16.Name = "Column16";
            this.Column16.Width = 94;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "SEX";
            this.Column17.Name = "Column17";
            this.Column17.Width = 53;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "MARITALSTATUS";
            this.Column18.Name = "Column18";
            this.Column18.Width = 122;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 19);
            this.label13.TabIndex = 83;
            this.label13.Text = "PATIENT MASTERLIST:";
            // 
            // pnlwaitlist
            // 
            this.pnlwaitlist.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlwaitlist.Controls.Add(this.btnaddtowait);
            this.pnlwaitlist.Controls.Add(this.txtwaitpatient);
            this.pnlwaitlist.Controls.Add(this.label12);
            this.pnlwaitlist.Controls.Add(this.btnclose);
            this.pnlwaitlist.Controls.Add(this.dgwaitlist);
            this.pnlwaitlist.Controls.Add(this.label1);
            this.pnlwaitlist.Location = new System.Drawing.Point(206, 106);
            this.pnlwaitlist.Name = "pnlwaitlist";
            this.pnlwaitlist.Size = new System.Drawing.Size(524, 411);
            this.pnlwaitlist.TabIndex = 10;
            // 
            // btnaddtowait
            // 
            this.btnaddtowait.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddtowait.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddtowait.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtowait.Location = new System.Drawing.Point(296, 56);
            this.btnaddtowait.Name = "btnaddtowait";
            this.btnaddtowait.Size = new System.Drawing.Size(102, 22);
            this.btnaddtowait.TabIndex = 88;
            this.btnaddtowait.Text = "ADD TO WAITLIST";
            this.btnaddtowait.UseVisualStyleBackColor = false;
            this.btnaddtowait.Click += new System.EventHandler(this.btnaddtowait_Click);
            // 
            // txtwaitpatient
            // 
            this.txtwaitpatient.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwaitpatient.Location = new System.Drawing.Point(129, 56);
            this.txtwaitpatient.Margin = new System.Windows.Forms.Padding(4);
            this.txtwaitpatient.Name = "txtwaitpatient";
            this.txtwaitpatient.Size = new System.Drawing.Size(160, 22);
            this.txtwaitpatient.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 14);
            this.label12.TabIndex = 86;
            this.label12.Text = "PATIENT NUMBER:";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Pink;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(472, 5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(47, 31);
            this.btnclose.TabIndex = 85;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dgwaitlist
            // 
            this.dgwaitlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwaitlist.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgwaitlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwaitlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgwaitlist.Location = new System.Drawing.Point(24, 84);
            this.dgwaitlist.Name = "dgwaitlist";
            this.dgwaitlist.RowHeadersVisible = false;
            this.dgwaitlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwaitlist.Size = new System.Drawing.Size(472, 296);
            this.dgwaitlist.TabIndex = 84;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ORDERNUM";
            this.Column8.Name = "Column8";
            this.Column8.Width = 96;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "PATIENT_NUMBER";
            this.Column9.Name = "Column9";
            this.Column9.Width = 131;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "DATE_ARRIVED";
            this.Column10.Name = "Column10";
            this.Column10.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 83;
            this.label1.Text = "WAITLIST:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 19);
            this.label10.TabIndex = 77;
            this.label10.Text = "ADMITTED PATIENTS:";
            // 
            // dginpatients
            // 
            this.dginpatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dginpatients.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dginpatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginpatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dginpatients.Location = new System.Drawing.Point(393, 150);
            this.dginpatients.Name = "dginpatients";
            this.dginpatients.RowHeadersVisible = false;
            this.dginpatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dginpatients.Size = new System.Drawing.Size(548, 355);
            this.dginpatients.TabIndex = 78;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnviewpatients);
            this.groupBox2.Controls.Add(this.lblPatientName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpinward);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbeds);
            this.groupBox2.Controls.Add(this.dtpdatearrived);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtduration);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtpatientnum);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 348);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IN PATIENT INFORMATION";
            // 
            // btnviewpatients
            // 
            this.btnviewpatients.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnviewpatients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnviewpatients.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewpatients.Location = new System.Drawing.Point(218, 66);
            this.btnviewpatients.Name = "btnviewpatients";
            this.btnviewpatients.Size = new System.Drawing.Size(108, 29);
            this.btnviewpatients.TabIndex = 81;
            this.btnviewpatients.Text = "VIEW PATIENTS";
            this.btnviewpatients.UseVisualStyleBackColor = false;
            this.btnviewpatients.Click += new System.EventHandler(this.btnviewpatients_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(18, 74);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(117, 14);
            this.lblPatientName.TabIndex = 80;
            this.lblPatientName.Text = "PATIENT FULL NAME...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 79;
            this.label7.Text = "(IN DAYS)";
            // 
            // dtpinward
            // 
            this.dtpinward.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpinward.Location = new System.Drawing.Point(166, 203);
            this.dtpinward.Name = "dtpinward";
            this.dtpinward.Size = new System.Drawing.Size(160, 22);
            this.dtpinward.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 14);
            this.label2.TabIndex = 75;
            this.label2.Text = "DATE PLACED IN WARD:";
            // 
            // cbbeds
            // 
            this.cbbeds.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbeds.FormattingEnabled = true;
            this.cbbeds.Location = new System.Drawing.Point(166, 132);
            this.cbbeds.Name = "cbbeds";
            this.cbbeds.Size = new System.Drawing.Size(160, 22);
            this.cbbeds.TabIndex = 74;
            // 
            // dtpdatearrived
            // 
            this.dtpdatearrived.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdatearrived.Location = new System.Drawing.Point(166, 168);
            this.dtpdatearrived.Name = "dtpdatearrived";
            this.dtpdatearrived.Size = new System.Drawing.Size(160, 22);
            this.dtpdatearrived.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 14);
            this.label6.TabIndex = 69;
            this.label6.Text = "DATE ARRIVED:";
            // 
            // txtduration
            // 
            this.txtduration.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtduration.Location = new System.Drawing.Point(166, 239);
            this.txtduration.Margin = new System.Windows.Forms.Padding(4);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(160, 22);
            this.txtduration.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 14);
            this.label5.TabIndex = 67;
            this.label5.Text = "EXPECTED DURATION:";
            // 
            // txtpatientnum
            // 
            this.txtpatientnum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatientnum.Location = new System.Drawing.Point(166, 37);
            this.txtpatientnum.Margin = new System.Windows.Forms.Padding(4);
            this.txtpatientnum.Name = "txtpatientnum";
            this.txtpatientnum.Size = new System.Drawing.Size(160, 22);
            this.txtpatientnum.TabIndex = 58;
            this.txtpatientnum.TextChanged += new System.EventHandler(this.txtpatientnum_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 40);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 14);
            this.label15.TabIndex = 56;
            this.label15.Text = "PATIENT NUMBER:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 135);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 14);
            this.label11.TabIndex = 20;
            this.label11.Text = "BED NUMBER:";
            // 
            // btnadmitpatient
            // 
            this.btnadmitpatient.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnadmitpatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadmitpatient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmitpatient.Location = new System.Drawing.Point(21, 470);
            this.btnadmitpatient.Name = "btnadmitpatient";
            this.btnadmitpatient.Size = new System.Drawing.Size(348, 35);
            this.btnadmitpatient.TabIndex = 80;
            this.btnadmitpatient.Text = "ADMIT PATIENT";
            this.btnadmitpatient.UseVisualStyleBackColor = false;
            this.btnadmitpatient.Click += new System.EventHandler(this.btnadmitpatient_Click);
            // 
            // btnwaitlist
            // 
            this.btnwaitlist.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnwaitlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnwaitlist.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwaitlist.Location = new System.Drawing.Point(770, 113);
            this.btnwaitlist.Name = "btnwaitlist";
            this.btnwaitlist.Size = new System.Drawing.Size(171, 31);
            this.btnwaitlist.TabIndex = 82;
            this.btnwaitlist.Text = "CHECK WAITLIST";
            this.btnwaitlist.UseVisualStyleBackColor = false;
            this.btnwaitlist.Click += new System.EventHandler(this.btnwaitlist_Click);
            // 
            // cb_filter
            // 
            this.cb_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_filter.BackColor = System.Drawing.Color.White;
            this.cb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Location = new System.Drawing.Point(602, 118);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(162, 22);
            this.cb_filter.TabIndex = 97;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "INPATIENT_ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 106;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PATIENT_NUMBER";
            this.Column2.Name = "Column2";
            this.Column2.Width = 131;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BED_NUMBER";
            this.Column3.Name = "Column3";
            this.Column3.Width = 107;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DATE_ARRIVED";
            this.Column4.Name = "Column4";
            this.Column4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DATE_INWARD";
            this.Column5.Name = "Column5";
            this.Column5.Width = 112;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DURATION";
            this.Column6.Name = "Column6";
            this.Column6.Width = 89;
            // 
            // InPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 517);
            this.Controls.Add(this.pnlwaitlist);
            this.Controls.Add(this.pnlpatientlist);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.btnwaitlist);
            this.Controls.Add(this.btnadmitpatient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dginpatients);
            this.Controls.Add(this.panel1);
            this.Name = "InPatients";
            this.Text = "IN-PATIENTS ADMISSION";
            this.Load += new System.EventHandler(this.InPatients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlpatientlist.ResumeLayout(false);
            this.pnlpatientlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpatientlist)).EndInit();
            this.pnlwaitlist.ResumeLayout(false);
            this.pnlwaitlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwaitlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dginpatients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dginpatients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpdatearrived;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpatientnum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpinward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbeds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnadmitpatient;
        private System.Windows.Forms.Button btnviewpatients;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Button btnwaitlist;
        private System.Windows.Forms.Panel pnlwaitlist;
        private System.Windows.Forms.DataGridView dgwaitlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnaddtowait;
        private System.Windows.Forms.TextBox txtwaitpatient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlpatientlist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnclosepatients;
        private System.Windows.Forms.DataGridView dgpatientlist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}