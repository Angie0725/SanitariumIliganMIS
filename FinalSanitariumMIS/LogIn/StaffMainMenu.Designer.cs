namespace LogIn
{
    partial class StaffMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnpatientreg = new System.Windows.Forms.Button();
            this.btnrequisitions = new System.Windows.Forms.Button();
            this.btnappointments = new System.Windows.Forms.Button();
            this.btnadmitpatient = new System.Windows.Forms.Button();
            this.btndischargepatient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 100);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 33);
            this.label4.TabIndex = 7;
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
            this.label3.TabIndex = 6;
            this.label3.Text = "SANITARIUM HOSPITAL";
            // 
            // btnpatientreg
            // 
            this.btnpatientreg.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnpatientreg.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnpatientreg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpatientreg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpatientreg.Image = ((System.Drawing.Image)(resources.GetObject("btnpatientreg.Image")));
            this.btnpatientreg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnpatientreg.Location = new System.Drawing.Point(30, 129);
            this.btnpatientreg.Name = "btnpatientreg";
            this.btnpatientreg.Size = new System.Drawing.Size(302, 121);
            this.btnpatientreg.TabIndex = 40;
            this.btnpatientreg.Text = "Patient Registration";
            this.btnpatientreg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnpatientreg.UseVisualStyleBackColor = false;
            this.btnpatientreg.Click += new System.EventHandler(this.btnpatientreg_Click);
            // 
            // btnrequisitions
            // 
            this.btnrequisitions.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnrequisitions.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnrequisitions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrequisitions.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrequisitions.Image = ((System.Drawing.Image)(resources.GetObject("btnrequisitions.Image")));
            this.btnrequisitions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnrequisitions.Location = new System.Drawing.Point(384, 256);
            this.btnrequisitions.Name = "btnrequisitions";
            this.btnrequisitions.Size = new System.Drawing.Size(148, 121);
            this.btnrequisitions.TabIndex = 41;
            this.btnrequisitions.Text = "Ward Requisitions";
            this.btnrequisitions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrequisitions.UseVisualStyleBackColor = false;
            this.btnrequisitions.Click += new System.EventHandler(this.btnrequisitions_Click);
            // 
            // btnappointments
            // 
            this.btnappointments.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnappointments.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnappointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnappointments.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappointments.Image = ((System.Drawing.Image)(resources.GetObject("btnappointments.Image")));
            this.btnappointments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnappointments.Location = new System.Drawing.Point(384, 129);
            this.btnappointments.Name = "btnappointments";
            this.btnappointments.Size = new System.Drawing.Size(148, 121);
            this.btnappointments.TabIndex = 42;
            this.btnappointments.Text = "Set Appointments";
            this.btnappointments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnappointments.UseVisualStyleBackColor = false;
            this.btnappointments.Click += new System.EventHandler(this.btnappointments_Click);
            // 
            // btnadmitpatient
            // 
            this.btnadmitpatient.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnadmitpatient.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnadmitpatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadmitpatient.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmitpatient.Image = ((System.Drawing.Image)(resources.GetObject("btnadmitpatient.Image")));
            this.btnadmitpatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnadmitpatient.Location = new System.Drawing.Point(30, 256);
            this.btnadmitpatient.Name = "btnadmitpatient";
            this.btnadmitpatient.Size = new System.Drawing.Size(148, 121);
            this.btnadmitpatient.TabIndex = 43;
            this.btnadmitpatient.Text = "Admit Patient (In-Patients)";
            this.btnadmitpatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadmitpatient.UseVisualStyleBackColor = false;
            this.btnadmitpatient.Click += new System.EventHandler(this.btnadmitpatient_Click);
            // 
            // btndischargepatient
            // 
            this.btndischargepatient.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btndischargepatient.Cursor = System.Windows.Forms.Cursors.Default;
            this.btndischargepatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndischargepatient.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndischargepatient.Image = ((System.Drawing.Image)(resources.GetObject("btndischargepatient.Image")));
            this.btndischargepatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndischargepatient.Location = new System.Drawing.Point(184, 256);
            this.btndischargepatient.Name = "btndischargepatient";
            this.btndischargepatient.Size = new System.Drawing.Size(148, 121);
            this.btndischargepatient.TabIndex = 44;
            this.btndischargepatient.Text = "Discharge Patient";
            this.btndischargepatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndischargepatient.UseVisualStyleBackColor = false;
            this.btndischargepatient.Click += new System.EventHandler(this.btndischargepatient_Click);
            // 
            // StaffMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(563, 405);
            this.Controls.Add(this.btndischargepatient);
            this.Controls.Add(this.btnadmitpatient);
            this.Controls.Add(this.btnappointments);
            this.Controls.Add(this.btnrequisitions);
            this.Controls.Add(this.btnpatientreg);
            this.Controls.Add(this.panel1);
            this.Name = "StaffMainMenu";
            this.Text = "STAFF - MAIN MENU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Staff_FormClosing);
            this.Load += new System.EventHandler(this.StaffMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnpatientreg;
        private System.Windows.Forms.Button btnrequisitions;
        private System.Windows.Forms.Button btnappointments;
        private System.Windows.Forms.Button btnadmitpatient;
        private System.Windows.Forms.Button btndischargepatient;
    }
}