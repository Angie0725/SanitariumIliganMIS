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
    public partial class MedDirMainMenu : Form
    {
        public MedDirMainMenu()
        {
            InitializeComponent();
        }

        private void btnhumanresource_Click(object sender, EventArgs e)
        {
            HRMainMenu frmHR = new HRMainMenu();
            frmHR.Show();
            this.Dispose();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            InventoryManagement frmIM = new InventoryManagement();
            frmIM.Show();
            this.Dispose();
        }

        private void MedDirMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo);

            if(logout == DialogResult.Yes)
            {
                LoginForm frmlogin = new LoginForm();
                frmlogin.Show();
                this.Dispose();
            }
            
        }

        private void MedDirMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnusermgt_Click(object sender, EventArgs e)
        {
            UserManagement frmUserMgt = new UserManagement();
            frmUserMgt.Show();
            this.Dispose();
        }

        private void btnchargenurse_Click(object sender, EventArgs e)
        {
            ChargeNurseMainMenu frmChargeNurse = new ChargeNurseMainMenu();
            frmChargeNurse.Show();
            this.Dispose();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            StaffMainMenu frmStaff = new StaffMainMenu();
            frmStaff.Show();
            this.Dispose();
        }
    }
}
