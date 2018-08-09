namespace LogIn
{
    partial class StaffRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_register = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvWorkExperience = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQualifications = new System.Windows.Forms.DataGridView();
            this.qualifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_work_experrience_finish = new System.Windows.Forms.DateTimePicker();
            this.dtp_work_experrience_start = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_add_experience = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNoHoursWorked = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOrganization = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnaddqualification = new System.Windows.Forms.Button();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_clear_exit = new System.Windows.Forms.Button();
            this.cbEmploymentType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNIN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbsex = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelnumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstaffnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpWorkStartDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifications)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_register.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(543, 684);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(365, 70);
            this.btn_register.TabIndex = 41;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(33, 281);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 18);
            this.label22.TabIndex = 33;
            this.label22.Text = "QUALIFICATIONS:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(317, 281);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 18);
            this.label21.TabIndex = 32;
            this.label21.Text = "WORK EXPERIENCE:";
            // 
            // dgvWorkExperience
            // 
            this.dgvWorkExperience.AllowUserToAddRows = false;
            this.dgvWorkExperience.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkExperience.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvWorkExperience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkExperience.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvWorkExperience.Location = new System.Drawing.Point(321, 302);
            this.dgvWorkExperience.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWorkExperience.Name = "dgvWorkExperience";
            this.dgvWorkExperience.ReadOnly = true;
            this.dgvWorkExperience.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvWorkExperience.RowHeadersVisible = false;
            this.dgvWorkExperience.Size = new System.Drawing.Size(411, 203);
            this.dgvWorkExperience.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Organization";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Position";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Start Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Finish Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dgvQualifications
            // 
            this.dgvQualifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQualifications.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvQualifications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQualifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qualifications});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQualifications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQualifications.Location = new System.Drawing.Point(37, 302);
            this.dgvQualifications.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQualifications.MultiSelect = false;
            this.dgvQualifications.Name = "dgvQualifications";
            this.dgvQualifications.ReadOnly = true;
            this.dgvQualifications.RowHeadersVisible = false;
            this.dgvQualifications.RowTemplate.ReadOnly = true;
            this.dgvQualifications.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQualifications.Size = new System.Drawing.Size(263, 203);
            this.dgvQualifications.TabIndex = 30;
            // 
            // qualifications
            // 
            this.qualifications.HeaderText = "List of Qualifications:";
            this.qualifications.Name = "qualifications";
            this.qualifications.ReadOnly = true;
            // 
            // dtp_work_experrience_finish
            // 
            this.dtp_work_experrience_finish.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_work_experrience_finish.Location = new System.Drawing.Point(436, 219);
            this.dtp_work_experrience_finish.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_work_experrience_finish.Name = "dtp_work_experrience_finish";
            this.dtp_work_experrience_finish.Size = new System.Drawing.Size(135, 26);
            this.dtp_work_experrience_finish.TabIndex = 29;
            // 
            // dtp_work_experrience_start
            // 
            this.dtp_work_experrience_start.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_work_experrience_start.Location = new System.Drawing.Point(164, 219);
            this.dtp_work_experrience_start.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_work_experrience_start.Name = "dtp_work_experrience_start";
            this.dtp_work_experrience_start.Size = new System.Drawing.Size(135, 26);
            this.dtp_work_experrience_start.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(333, 226);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 18);
            this.label20.TabIndex = 28;
            this.label20.Text = "FINISH DATE:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(33, 226);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 18);
            this.label19.TabIndex = 27;
            this.label19.Text = "START DATE:";
            // 
            // btn_add_experience
            // 
            this.btn_add_experience.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add_experience.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_experience.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_experience.Location = new System.Drawing.Point(581, 146);
            this.btn_add_experience.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_experience.Name = "btn_add_experience";
            this.btn_add_experience.Size = new System.Drawing.Size(151, 54);
            this.btn_add_experience.TabIndex = 26;
            this.btn_add_experience.Text = "ADD WORK EXPERIENCE";
            this.btn_add_experience.UseVisualStyleBackColor = false;
            this.btn_add_experience.Click += new System.EventHandler(this.btn_add_experience_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(164, 183);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(5);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(407, 26);
            this.txtPosition.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 121);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "(in a week)";
            // 
            // txtNoHoursWorked
            // 
            this.txtNoHoursWorked.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoHoursWorked.Location = new System.Drawing.Point(332, 100);
            this.txtNoHoursWorked.Margin = new System.Windows.Forms.Padding(5);
            this.txtNoHoursWorked.Name = "txtNoHoursWorked";
            this.txtNoHoursWorked.Size = new System.Drawing.Size(115, 26);
            this.txtNoHoursWorked.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.dgvWorkExperience);
            this.groupBox3.Controls.Add(this.dgvQualifications);
            this.groupBox3.Controls.Add(this.dtp_work_experrience_finish);
            this.groupBox3.Controls.Add(this.dtp_work_experrience_start);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.btn_add_experience);
            this.groupBox3.Controls.Add(this.txtPosition);
            this.groupBox3.Controls.Add(this.txtOrganization);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnaddqualification);
            this.groupBox3.Controls.Add(this.txtQualification);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(543, 149);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(755, 528);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QUALIFICATIONS AND WORK EXPERIENCE";
            // 
            // txtOrganization
            // 
            this.txtOrganization.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganization.Location = new System.Drawing.Point(164, 146);
            this.txtOrganization.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.Size = new System.Drawing.Size(407, 26);
            this.txtOrganization.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(33, 150);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 18);
            this.label18.TabIndex = 24;
            this.label18.Text = "ORGANIZATION:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(33, 187);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 18);
            this.label17.TabIndex = 23;
            this.label17.Text = "POSITION:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 108);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 23);
            this.label16.TabIndex = 22;
            this.label16.Text = "WORK EXPERIENCE:";
            // 
            // btnaddqualification
            // 
            this.btnaddqualification.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddqualification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddqualification.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddqualification.Location = new System.Drawing.Point(581, 32);
            this.btnaddqualification.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddqualification.Name = "btnaddqualification";
            this.btnaddqualification.Size = new System.Drawing.Size(151, 54);
            this.btnaddqualification.TabIndex = 21;
            this.btnaddqualification.Text = "ADD QUALIFICATION";
            this.btnaddqualification.UseVisualStyleBackColor = false;
            this.btnaddqualification.Click += new System.EventHandler(this.btnaddqualification_Click);
            // 
            // txtQualification
            // 
            this.txtQualification.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQualification.Location = new System.Drawing.Point(164, 32);
            this.txtQualification.Margin = new System.Windows.Forms.Padding(5);
            this.txtQualification.Multiline = true;
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(407, 53);
            this.txtQualification.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 32);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "QUALIFICATION:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = "NUMBER OF HOURS WORKED:";
            // 
            // btn_clear_exit
            // 
            this.btn_clear_exit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_clear_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear_exit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_exit.Location = new System.Drawing.Point(932, 684);
            this.btn_clear_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear_exit.Name = "btn_clear_exit";
            this.btn_clear_exit.Size = new System.Drawing.Size(365, 70);
            this.btn_clear_exit.TabIndex = 42;
            this.btn_clear_exit.Text = "CLEAR AND EXIT";
            this.btn_clear_exit.UseVisualStyleBackColor = false;
            this.btn_clear_exit.Click += new System.EventHandler(this.btn_clear_exit_Click);
            // 
            // cbEmploymentType
            // 
            this.cbEmploymentType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmploymentType.FormattingEnabled = true;
            this.cbEmploymentType.Location = new System.Drawing.Point(209, 64);
            this.cbEmploymentType.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmploymentType.Name = "cbEmploymentType";
            this.cbEmploymentType.Size = new System.Drawing.Size(237, 26);
            this.cbEmploymentType.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 123);
            this.panel1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Management Information System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 54);
            this.label3.TabIndex = 8;
            this.label3.Text = "SANITARIUM HOSPITAL";
            // 
            // txtNIN
            // 
            this.txtNIN.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIN.Location = new System.Drawing.Point(29, 369);
            this.txtNIN.Margin = new System.Windows.Forms.Padding(5);
            this.txtNIN.Name = "txtNIN";
            this.txtNIN.Size = new System.Drawing.Size(417, 26);
            this.txtNIN.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 347);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "NATIONAL INSURANCE NUMBER:";
            // 
            // cbsex
            // 
            this.cbsex.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsex.FormattingEnabled = true;
            this.cbsex.Location = new System.Drawing.Point(287, 308);
            this.cbsex.Margin = new System.Windows.Forms.Padding(4);
            this.cbsex.Name = "cbsex";
            this.cbsex.Size = new System.Drawing.Size(160, 26);
            this.cbsex.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 311);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "SEX:";
            // 
            // dpbirthdate
            // 
            this.dpbirthdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpbirthdate.Location = new System.Drawing.Point(209, 273);
            this.dpbirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.dpbirthdate.Name = "dpbirthdate";
            this.dpbirthdate.Size = new System.Drawing.Size(237, 26);
            this.dpbirthdate.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 281);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "BIRTH DATE:";
            // 
            // txttelnumber
            // 
            this.txttelnumber.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelnumber.Location = new System.Drawing.Point(209, 238);
            this.txttelnumber.Margin = new System.Windows.Forms.Padding(5);
            this.txttelnumber.Name = "txttelnumber";
            this.txttelnumber.Size = new System.Drawing.Size(237, 26);
            this.txttelnumber.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "TELEPHONE NUMBER:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNIN);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbsex);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dpbirthdate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttelnumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(this.txtfirstname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtstaffnumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 149);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(500, 414);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STAFF INFORMATION";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(209, 146);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(237, 80);
            this.txtaddress.TabIndex = 11;
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(209, 110);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(5);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(237, 26);
            this.txtlastname.TabIndex = 10;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(209, 79);
            this.txtfirstname.Margin = new System.Windows.Forms.Padding(5);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(237, 26);
            this.txtfirstname.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "ADDRESS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "LAST NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "FIRST NAME:";
            // 
            // txtstaffnumber
            // 
            this.txtstaffnumber.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstaffnumber.Location = new System.Drawing.Point(209, 36);
            this.txtstaffnumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtstaffnumber.Name = "txtstaffnumber";
            this.txtstaffnumber.Size = new System.Drawing.Size(237, 26);
            this.txtstaffnumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "STAFF NUMBER:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "POSITION:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpWorkStartDate);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtNoHoursWorked);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbEmploymentType);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbPosition);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 570);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(500, 185);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EMPLOYMENT DETAILS";
            // 
            // dtpWorkStartDate
            // 
            this.dtpWorkStartDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWorkStartDate.Location = new System.Drawing.Point(209, 145);
            this.dtpWorkStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpWorkStartDate.Name = "dtpWorkStartDate";
            this.dtpWorkStartDate.Size = new System.Drawing.Size(237, 26);
            this.dtpWorkStartDate.TabIndex = 34;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(28, 153);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 18);
            this.label23.TabIndex = 35;
            this.label23.Text = "START DATE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "TYPE OF EMPLOYMENT:";
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(209, 31);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(237, 26);
            this.cbPosition.TabIndex = 21;
            // 
            // StaffRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1327, 768);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_clear_exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffRegistration";
            this.Text = "STAFF REGISTRATION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffRegistration_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifications)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvWorkExperience;
        private System.Windows.Forms.DataGridView dgvQualifications;
        private System.Windows.Forms.DateTimePicker dtp_work_experrience_finish;
        private System.Windows.Forms.DateTimePicker dtp_work_experrience_start;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_add_experience;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNoHoursWorked;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOrganization;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnaddqualification;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_clear_exit;
        private System.Windows.Forms.ComboBox cbEmploymentType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNIN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbsex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpbirthdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttelnumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstaffnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.DateTimePicker dtpWorkStartDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}