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
using FinalSanitariumMIS;

namespace LogIn
{
    public partial class Form1 : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM users WHERE username = '" + txtusername.Text + "' AND pass = '" + txtpassword.Text + "'");

            if(rs.Read())
            {
                Models.SessionMeta session = new Models.SessionMeta();

                this.Visible = false;

                if(session.usertype == 1)
                {
                    new HRMainMenu().Visible = true;
                }
                else if(session.usertype == 2)
                {
                    new StaffMainMenu().Visible = true;
                }
                else if(session.usertype == 3)
                {
                    new ChargeNurseMainMenu().Visible = true;
                }
                else if(session.usertype == 4)
                {
                    new MedDirMainMenu().Visible = true;
                }

            }
            else 
            {
                MessageBox.Show("Incorrect Login Credentials!");
            }
        }
    }
}
