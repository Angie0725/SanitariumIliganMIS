﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class MedDirMainMenu : Form
    {
        public MedDirMainMenu()
        {
            InitializeComponent();
        }

        private void btnpatientregistration_Click(object sender, EventArgs e)
        {
            PatientRegistration frmPR = new PatientRegistration();
            frmPR.Show();
            this.Dispose();
        }

        private void btnhumanresource_Click(object sender, EventArgs e)
        {
            HRMainMenu frmHR = new HRMainMenu();
            frmHR.Show();
            this.Dispose();
        }

        private void btnrequisitions_Click(object sender, EventArgs e)
        {
            Requisitions frmReq = new Requisitions();
            frmReq.Show();
            this.Dispose();
        }

        private void btnappointments_Click(object sender, EventArgs e)
        {
            Appointments frmAppoint = new Appointments();
            frmAppoint.Show();
            this.Dispose();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            InventoryManagement frmIM = new InventoryManagement();
            frmIM.Show();
            this.Dispose();
        }

        private void btnrooms_Click(object sender, EventArgs e)
        {
            RoomManagement frmRM = new RoomManagement();
            frmRM.Show();
            this.Dispose();
        }

        private void MedDirMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.LoginScreen.Show();
            this.Dispose();
        }
    }
}
