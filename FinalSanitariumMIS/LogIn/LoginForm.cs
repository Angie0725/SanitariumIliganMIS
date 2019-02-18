using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2;

namespace LogIn
{
    public partial class LoginForm : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;
        private int staffNum = 0;
        private int acctype = 0;

        public LoginForm()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM ACCOUNT WHERE USERNAME = '" + txtusername.Text + "' AND PASSCODE = '" + txtpassword.Text + "'");
            if(rs.Read())
            {
                LoginDetails obj = new LoginDetails();
                
                staffNum = Convert.ToInt32(rs["STAFF_NUMBER"]);
                acctype = Convert.ToInt32(rs["ACCOUNT_TYPE"]);

                obj.setStaffNum(staffNum);
                

                if(acctype == 1)
                {
                    obj.setPOSnum(0);
                    MedDirMainMenu frmMedDir = new MedDirMainMenu();
                    frmMedDir.Show();
                    this.Hide();
                }
                else if (acctype == 2)
                {
                    obj.setPOSnum(1);
                    HRMainMenu frmHR = new HRMainMenu();
                    frmHR.Show();
                    this.Hide();
                }
                else if (acctype == 3)
                {
                    obj.setPOSnum(1);
                    ChargeNurseMainMenu frmChargeNurse = new ChargeNurseMainMenu();
                    frmChargeNurse.Show();
                    this.Dispose();
                }
                else if (acctype == 5)
                {
                    obj.setPOSnum(1);
                    StaffMainMenu frmStaff = new StaffMainMenu();
                    frmStaff.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Incorrect Login Credentials!");
            }
        }
    }
}
