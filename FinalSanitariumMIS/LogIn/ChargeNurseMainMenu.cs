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
    public partial class ChargeNurseMainMenu : Form
    {
        public ChargeNurseMainMenu()
        {
            InitializeComponent();
        }

        private void ChargeNurseMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void ChargeNurse_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnwardalloc_Click(object sender, EventArgs e)
        {
            StaffWardAllocation frmWardAlloc = new StaffWardAllocation();
            frmWardAlloc.Show();
            this.Dispose();
        }

        private void btnroommgt_Click(object sender, EventArgs e)
        {
            RoomManagement frmRoomMgt = new RoomManagement();
            frmRoomMgt.Show();
            this.Dispose();
        }

        private void btnapprovedacq_Click(object sender, EventArgs e)
        {
            ApproveRequisition frmApprovedReq = new ApproveRequisition();
            frmApprovedReq.Show();
            this.Dispose();
        }
    }
}
