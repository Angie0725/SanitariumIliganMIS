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
    public partial class HRMainMenu : Form
    {
        
        
        public HRMainMenu()
        {
            InitializeComponent();
        }

        private void HR_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginDetails obj = new LoginDetails();
            int posnum = obj.getPOSnum();

            if(posnum == 0)
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

        private void HRMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnstaffmgt_Click(object sender, EventArgs e)
        {
            StaffManagement frmStaffMgt = new StaffManagement();
            frmStaffMgt.Show();
            this.Hide();
        }

        private void btnsalarymgt_Click(object sender, EventArgs e)
        {
            SalaryManagement frmSalaryMgt = new SalaryManagement();
            frmSalaryMgt.Show();
            this.Hide();
        }

        private void btnstaffreg_Click(object sender, EventArgs e)
        {
            StaffRegistration frmStaffreg = new StaffRegistration();
            frmStaffreg.Show();
            this.Hide();
        }

        private void btnposmaintenance_Click(object sender, EventArgs e)
        {
            PositionMaintenance frmPosMaintain = new PositionMaintenance();
            frmPosMaintain.Show();
            this.Hide();
        }
    }
}
