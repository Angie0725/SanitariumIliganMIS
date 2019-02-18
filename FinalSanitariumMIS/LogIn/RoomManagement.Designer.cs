namespace LogIn
{
    partial class RoomManagement
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
            this.linkback = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbeddesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnudpatebed = new System.Windows.Forms.Button();
            this.cblocward = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbavailability = new System.Windows.Forms.ComboBox();
            this.dgvbeds = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbednum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnaddbed = new System.Windows.Forms.Button();
            this.dgvwards = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnupdateward = new System.Windows.Forms.Button();
            this.txtwarddesc = new System.Windows.Forms.TextBox();
            this.btnaddward = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtwardname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtwardnum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwards)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.linkback);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 100);
            this.panel1.TabIndex = 91;
            // 
            // linkback
            // 
            this.linkback.AutoSize = true;
            this.linkback.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkback.Location = new System.Drawing.Point(608, 68);
            this.linkback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkback.Name = "linkback";
            this.linkback.Size = new System.Drawing.Size(189, 23);
            this.linkback.TabIndex = 106;
            this.linkback.Text = "Go back to Main Menu";
            this.linkback.Click += new System.EventHandler(this.linkback_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbeddesc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnudpatebed);
            this.groupBox2.Controls.Add(this.cblocward);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbavailability);
            this.groupBox2.Controls.Add(this.dgvbeds);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtbednum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnaddbed);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 476);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BED DETAILS";
            // 
            // txtbeddesc
            // 
            this.txtbeddesc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbeddesc.Location = new System.Drawing.Point(169, 129);
            this.txtbeddesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtbeddesc.Multiline = true;
            this.txtbeddesc.Name = "txtbeddesc";
            this.txtbeddesc.Size = new System.Drawing.Size(159, 43);
            this.txtbeddesc.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 14);
            this.label9.TabIndex = 100;
            this.label9.Text = "DESCRIPTION:";
            // 
            // btnudpatebed
            // 
            this.btnudpatebed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnudpatebed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnudpatebed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnudpatebed.Location = new System.Drawing.Point(176, 184);
            this.btnudpatebed.Name = "btnudpatebed";
            this.btnudpatebed.Size = new System.Drawing.Size(152, 35);
            this.btnudpatebed.TabIndex = 94;
            this.btnudpatebed.Text = "UPDATE BED";
            this.btnudpatebed.UseVisualStyleBackColor = false;
            this.btnudpatebed.Click += new System.EventHandler(this.btnudpatebed_Click);
            // 
            // cblocward
            // 
            this.cblocward.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblocward.FormattingEnabled = true;
            this.cblocward.Location = new System.Drawing.Point(168, 68);
            this.cblocward.Name = "cblocward";
            this.cblocward.Size = new System.Drawing.Size(160, 22);
            this.cblocward.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 95;
            this.label2.Text = "BED LIST:";
            // 
            // cbavailability
            // 
            this.cbavailability.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbavailability.FormattingEnabled = true;
            this.cbavailability.Location = new System.Drawing.Point(168, 100);
            this.cbavailability.Name = "cbavailability";
            this.cbavailability.Size = new System.Drawing.Size(160, 22);
            this.cbavailability.TabIndex = 86;
            // 
            // dgvbeds
            // 
            this.dgvbeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvbeds.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvbeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7});
            this.dgvbeds.Location = new System.Drawing.Point(16, 253);
            this.dgvbeds.Name = "dgvbeds";
            this.dgvbeds.RowHeadersVisible = false;
            this.dgvbeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbeds.Size = new System.Drawing.Size(310, 207);
            this.dgvbeds.TabIndex = 94;
            this.dgvbeds.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbeds_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BED_NUM";
            this.Column1.Name = "Column1";
            this.Column1.Width = 106;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "AVAILABILITY";
            this.Column2.Name = "Column2";
            this.Column2.Width = 131;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "LOCATION";
            this.Column3.Name = "Column3";
            this.Column3.Width = 108;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DESCRIPTION";
            this.Column7.Name = "Column7";
            this.Column7.Width = 135;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 14);
            this.label10.TabIndex = 87;
            this.label10.Text = "AVAILABILITY:";
            // 
            // txtbednum
            // 
            this.txtbednum.Enabled = false;
            this.txtbednum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbednum.Location = new System.Drawing.Point(168, 34);
            this.txtbednum.Margin = new System.Windows.Forms.Padding(4);
            this.txtbednum.Name = "txtbednum";
            this.txtbednum.Size = new System.Drawing.Size(160, 22);
            this.txtbednum.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 59;
            this.label1.Text = "BED NUMBER:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 71);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 14);
            this.label15.TabIndex = 56;
            this.label15.Text = "LOCATION (WARD):";
            // 
            // btnaddbed
            // 
            this.btnaddbed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddbed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddbed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbed.Location = new System.Drawing.Point(18, 184);
            this.btnaddbed.Name = "btnaddbed";
            this.btnaddbed.Size = new System.Drawing.Size(152, 35);
            this.btnaddbed.TabIndex = 93;
            this.btnaddbed.Text = "ADD BED";
            this.btnaddbed.UseVisualStyleBackColor = false;
            this.btnaddbed.Click += new System.EventHandler(this.btnaddbed_Click);
            // 
            // dgvwards
            // 
            this.dgvwards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvwards.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvwards.Location = new System.Drawing.Point(34, 253);
            this.dgvwards.Name = "dgvwards";
            this.dgvwards.RowHeadersVisible = false;
            this.dgvwards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwards.Size = new System.Drawing.Size(326, 207);
            this.dgvwards.TabIndex = 99;
            this.dgvwards.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwards_CellContentDoubleClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "WARD_NUM";
            this.Column4.Name = "Column4";
            this.Column4.Width = 121;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NAME";
            this.Column5.Name = "Column5";
            this.Column5.Width = 76;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DESCRIPTION";
            this.Column6.Name = "Column6";
            this.Column6.Width = 135;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnupdateward);
            this.groupBox4.Controls.Add(this.dgvwards);
            this.groupBox4.Controls.Add(this.txtwarddesc);
            this.groupBox4.Controls.Add(this.btnaddward);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtwardname);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtwardnum);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(380, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 476);
            this.groupBox4.TabIndex = 99;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "WARD DETAILS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 96;
            this.label8.Text = "WARD LIST:";
            // 
            // btnupdateward
            // 
            this.btnupdateward.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnupdateward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdateward.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateward.Location = new System.Drawing.Point(198, 184);
            this.btnupdateward.Name = "btnupdateward";
            this.btnupdateward.Size = new System.Drawing.Size(158, 35);
            this.btnupdateward.TabIndex = 98;
            this.btnupdateward.Text = "UPDATE WARD";
            this.btnupdateward.UseVisualStyleBackColor = false;
            this.btnupdateward.Click += new System.EventHandler(this.btnupdateward_Click);
            // 
            // txtwarddesc
            // 
            this.txtwarddesc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwarddesc.Location = new System.Drawing.Point(187, 98);
            this.txtwarddesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtwarddesc.Multiline = true;
            this.txtwarddesc.Name = "txtwarddesc";
            this.txtwarddesc.Size = new System.Drawing.Size(173, 43);
            this.txtwarddesc.TabIndex = 89;
            // 
            // btnaddward
            // 
            this.btnaddward.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddward.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddward.Location = new System.Drawing.Point(34, 184);
            this.btnaddward.Name = "btnaddward";
            this.btnaddward.Size = new System.Drawing.Size(158, 35);
            this.btnaddward.TabIndex = 97;
            this.btnaddward.Text = "ADD WARD";
            this.btnaddward.UseVisualStyleBackColor = false;
            this.btnaddward.Click += new System.EventHandler(this.btnaddward_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 14);
            this.label7.TabIndex = 56;
            this.label7.Text = "WARD NAME:";
            // 
            // txtwardname
            // 
            this.txtwardname.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwardname.Location = new System.Drawing.Point(187, 68);
            this.txtwardname.Margin = new System.Windows.Forms.Padding(4);
            this.txtwardname.Name = "txtwardname";
            this.txtwardname.Size = new System.Drawing.Size(173, 22);
            this.txtwardname.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 59;
            this.label6.Text = "WARD NUMBER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 87;
            this.label5.Text = "DESCRIPTION:";
            // 
            // txtwardnum
            // 
            this.txtwardnum.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwardnum.Location = new System.Drawing.Point(187, 34);
            this.txtwardnum.Margin = new System.Windows.Forms.Padding(4);
            this.txtwardnum.Name = "txtwardnum";
            this.txtwardnum.Size = new System.Drawing.Size(173, 22);
            this.txtwardnum.TabIndex = 60;
            // 
            // RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "RoomManagement";
            this.Text = "ROOM MANAGEMENT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomManagement_FormClosing);
            this.Load += new System.EventHandler(this.RoomManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwards)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cblocward;
        private System.Windows.Forms.ComboBox cbavailability;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbednum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnaddbed;
        private System.Windows.Forms.DataGridView dgvbeds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvwards;
        private System.Windows.Forms.Label linkback;
        private System.Windows.Forms.Button btnudpatebed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtwarddesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtwardname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtwardnum;
        private System.Windows.Forms.Button btnaddward;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnupdateward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtbeddesc;
        private System.Windows.Forms.Label label9;
    }
}