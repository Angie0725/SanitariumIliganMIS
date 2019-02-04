namespace LogIn
{
    partial class DischargePatient
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
            this.dginpatients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btndischarge = new System.Windows.Forms.Button();
            this.btnviewdischarged = new System.Windows.Forms.Button();
            this.pnldischarged = new System.Windows.Forms.Panel();
            this.btnclosedsch = new System.Windows.Forms.Button();
            this.dgdscharged = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginpatients)).BeginInit();
            this.pnldischarged.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdscharged)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 54);
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
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "SANITARIUM HOSPITAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 100);
            this.panel1.TabIndex = 10;
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
            this.Column6,
            this.Column7});
            this.dginpatients.Location = new System.Drawing.Point(19, 158);
            this.dginpatients.Name = "dginpatients";
            this.dginpatients.RowHeadersVisible = false;
            this.dginpatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dginpatients.Size = new System.Drawing.Size(755, 266);
            this.dginpatients.TabIndex = 79;
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
            // Column7
            // 
            this.Column7.HeaderText = "DATE_LEFT";
            this.Column7.Name = "Column7";
            this.Column7.Width = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 80;
            this.label10.Text = "INPATIENTS LIST:";
            // 
            // btndischarge
            // 
            this.btndischarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndischarge.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btndischarge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndischarge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndischarge.Location = new System.Drawing.Point(19, 430);
            this.btndischarge.Name = "btndischarge";
            this.btndischarge.Size = new System.Drawing.Size(376, 35);
            this.btndischarge.TabIndex = 95;
            this.btndischarge.Text = "DISCHARGE PATIENT";
            this.btndischarge.UseVisualStyleBackColor = false;
            this.btndischarge.Click += new System.EventHandler(this.btndischarge_Click);
            // 
            // btnviewdischarged
            // 
            this.btnviewdischarged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnviewdischarged.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnviewdischarged.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnviewdischarged.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewdischarged.Location = new System.Drawing.Point(398, 430);
            this.btnviewdischarged.Name = "btnviewdischarged";
            this.btnviewdischarged.Size = new System.Drawing.Size(376, 35);
            this.btnviewdischarged.TabIndex = 96;
            this.btnviewdischarged.Text = "VIEW DISCHARGED PATIENTS";
            this.btnviewdischarged.UseVisualStyleBackColor = false;
            this.btnviewdischarged.Click += new System.EventHandler(this.btnviewdischarged_Click);
            // 
            // pnldischarged
            // 
            this.pnldischarged.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnldischarged.Controls.Add(this.btnclosedsch);
            this.pnldischarged.Controls.Add(this.dgdscharged);
            this.pnldischarged.Controls.Add(this.label13);
            this.pnldischarged.Location = new System.Drawing.Point(177, 106);
            this.pnldischarged.Name = "pnldischarged";
            this.pnldischarged.Size = new System.Drawing.Size(492, 359);
            this.pnldischarged.TabIndex = 97;
            // 
            // btnclosedsch
            // 
            this.btnclosedsch.BackColor = System.Drawing.Color.Pink;
            this.btnclosedsch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclosedsch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosedsch.Location = new System.Drawing.Point(423, 9);
            this.btnclosedsch.Name = "btnclosedsch";
            this.btnclosedsch.Size = new System.Drawing.Size(47, 31);
            this.btnclosedsch.TabIndex = 85;
            this.btnclosedsch.Text = "X";
            this.btnclosedsch.UseVisualStyleBackColor = false;
            this.btnclosedsch.Click += new System.EventHandler(this.btnclosedsch_Click);
            // 
            // dgdscharged
            // 
            this.dgdscharged.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdscharged.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgdscharged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdscharged.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgdscharged.Location = new System.Drawing.Point(24, 64);
            this.dgdscharged.Name = "dgdscharged";
            this.dgdscharged.RowHeadersVisible = false;
            this.dgdscharged.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdscharged.Size = new System.Drawing.Size(446, 277);
            this.dgdscharged.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 42);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 19);
            this.label13.TabIndex = 83;
            this.label13.Text = "DISCHARGED PARENTS:";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "DPID";
            this.Column8.Name = "Column8";
            this.Column8.Width = 58;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "PATIENT_NUMBER";
            this.Column9.Name = "Column9";
            this.Column9.Width = 131;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "PATIENT_NAME";
            this.Column10.Name = "Column10";
            this.Column10.Width = 115;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "DATE_DISCHARGED";
            this.Column11.Name = "Column11";
            this.Column11.Width = 138;
            // 
            // DischargePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 478);
            this.Controls.Add(this.pnldischarged);
            this.Controls.Add(this.btnviewdischarged);
            this.Controls.Add(this.btndischarge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dginpatients);
            this.Controls.Add(this.panel1);
            this.Name = "DischargePatient";
            this.Text = "DISCHARGE PATIENT";
            this.Load += new System.EventHandler(this.DischargePatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginpatients)).EndInit();
            this.pnldischarged.ResumeLayout(false);
            this.pnldischarged.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdscharged)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dginpatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btndischarge;
        private System.Windows.Forms.Button btnviewdischarged;
        private System.Windows.Forms.Panel pnldischarged;
        private System.Windows.Forms.Button btnclosedsch;
        private System.Windows.Forms.DataGridView dgdscharged;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label13;
    }
}