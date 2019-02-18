using System;
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
    public partial class StaffMainMenu : Form
    {
        public StaffMainMenu()
        {
            InitializeComponent();
        }

        private void btnpatientreg_Click(object sender, EventArgs e)
        {
            PatientRegistration frmPatientReg = new PatientRegistration();
            frmPatientReg.Show();
            this.Dispose();

        }

        private void btnadmitpatient_Click(object sender, EventArgs e)
        {
            InPatients frmAdmitPatient = new InPatients();
            frmAdmitPatient.Show();
            this.Dispose();

        }

        private void btndischargepatient_Click(object sender, EventArgs e)
        {
            DischargePatient frmDischarge = new DischargePatient();
            frmDischarge.Show();
            this.Dispose();

        }

        private void btnappointments_Click(object sender, EventArgs e)
        {
            Appointments frmAppointments = new Appointments();
            frmAppointments.Show();
            this.Dispose();
        }

        private void btnrequisitions_Click(object sender, EventArgs e)
        {
            Requisitions frmRequisitions = new Requisitions();
            frmRequisitions.Show();
            this.Dispose();
        }

        private void Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginDetails obj = new LoginDetails();
            int posnum = obj.getPOSnum();

            if (posnum == 0)
            {
                MedDirMainMenu frmMD = new MedDirMainMenu();
                frmMD.Show();
                this.Dispose();
            }
            else
            {
                DialogResult logout = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo);

                if (logout == DialogResult.Yes)
                {
                    LoginForm frmlogin = new LoginForm();
                    frmlogin.Show();
                    this.Dispose();
                }
            }
        }

        private void StaffMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
