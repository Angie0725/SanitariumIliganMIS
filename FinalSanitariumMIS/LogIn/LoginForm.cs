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
                
                staffNum = Convert.ToInt32(rs["STAFF_NUMBER"].ToString());

                obj.setStaffNum(staffNum);
                

                Requisitions frmReq = new Requisitions();
                frmReq.Show();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect Login Credentials!");
            }
        }
    }
}
