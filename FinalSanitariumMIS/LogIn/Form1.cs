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
//using FinalSanitariumMIS;

namespace LogIn
{
    public partial class Form1 : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public Form1()
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
                int staffNum = 0;
                //this.Visible = false;
                //new MedDirMainMenu().Visible = true;

                while (rs.Read())
                {
                    staffNum = Convert.ToInt32(rs["STAFF_NUMBER"].ToString());
                }

                obj.setStaffNum(staffNum);

                MessageBox.Show("Success: " + obj.getStaffNum());
            
                
  
            }
            else 
            {
                MessageBox.Show("Incorrect Login Credentials!");
            }
        }
    }
}
