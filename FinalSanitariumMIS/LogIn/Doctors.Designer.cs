namespace LogIn
{
    partial class Doctors
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
            this.dgv_masterlist = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_tel_no = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_clinic_number = new System.Windows.Forms.ComboBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_doctor_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_reigster = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_masterlist)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 100);
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
            // dgv_masterlist
            // 
            this.dgv_masterlist.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgv_masterlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_masterlist.Location = new System.Drawing.Point(397, 139);
            this.dgv_masterlist.Name = "dgv_masterlist";
            this.dgv_masterlist.Size = new System.Drawing.Size(548, 309);
            this.dgv_masterlist.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 19);
            this.label10.TabIndex = 80;
            this.label10.Text = "DOCTORS MASTERLIST:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_tel_no);
            this.groupBox2.Controls.Add(this.tb_lastname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cb_clinic_number);
            this.groupBox2.Controls.Add(this.tb_address);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_doctor_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_firstname);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 286);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERSONAL INFORMATION";
            // 
            // tb_tel_no
            // 
            this.tb_tel_no.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tel_no.Location = new System.Drawing.Point(166, 214);
            this.tb_tel_no.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tel_no.Name = "tb_tel_no";
            this.tb_tel_no.Size = new System.Drawing.Size(160, 22);
            this.tb_tel_no.TabIndex = 82;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lastname.Location = new System.Drawing.Point(166, 93);
            this.tb_lastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(160, 22);
            this.tb_lastname.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 80;
            this.label2.Text = "LAST NAME:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 14);
            this.label7.TabIndex = 79;
            this.label7.Text = "TELEPHONE NUMBER:";
            // 
            // cb_clinic_number
            // 
            this.cb_clinic_number.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_clinic_number.FormattingEnabled = true;
            this.cb_clinic_number.Location = new System.Drawing.Point(204, 122);
            this.cb_clinic_number.Name = "cb_clinic_number";
            this.cb_clinic_number.Size = new System.Drawing.Size(122, 22);
            this.cb_clinic_number.TabIndex = 74;
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(166, 151);
            this.tb_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(160, 55);
            this.tb_address.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 67;
            this.label5.Text = "ADDRESS:";
            // 
            // tb_doctor_id
            // 
            this.tb_doctor_id.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_doctor_id.Location = new System.Drawing.Point(166, 34);
            this.tb_doctor_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_doctor_id.Name = "tb_doctor_id";
            this.tb_doctor_id.Size = new System.Drawing.Size(160, 22);
            this.tb_doctor_id.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 59;
            this.label1.Text = "DOCTOR ID:";
            // 
            // tb_firstname
            // 
            this.tb_firstname.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_firstname.Location = new System.Drawing.Point(166, 68);
            this.tb_firstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(160, 22);
            this.tb_firstname.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 71);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 14);
            this.label15.TabIndex = 56;
            this.label15.Text = "FIRST NAME:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 14);
            this.label11.TabIndex = 20;
            this.label11.Text = "CLINIC NUMBER:";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(197, 413);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(171, 35);
            this.btn_update.TabIndex = 83;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_reigster
            // 
            this.btn_reigster.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_reigster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reigster.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reigster.Location = new System.Drawing.Point(19, 413);
            this.btn_reigster.Name = "btn_reigster";
            this.btn_reigster.Size = new System.Drawing.Size(170, 35);
            this.btn_reigster.TabIndex = 82;
            this.btn_reigster.Text = "REGISTER";
            this.btn_reigster.UseVisualStyleBackColor = false;
            this.btn_reigster.Click += new System.EventHandler(this.btn_reigster_Click);
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 475);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_reigster);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_masterlist);
            this.Controls.Add(this.panel1);
            this.Name = "Doctors";
            this.Text = "HOSPITAL DOCTORS";
            this.Load += new System.EventHandler(this.Doctors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_masterlist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_masterlist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_clinic_number;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_doctor_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tel_no;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_reigster;
    }
}