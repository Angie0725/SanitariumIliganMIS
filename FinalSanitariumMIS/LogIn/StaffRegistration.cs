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
    public partial class StaffRegistration : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public StaffRegistration()
        {
            InitializeComponent();
            emptyAllInputFields();
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Add Code For Input Constraint Implementation

            DB.Query("INSERT INTO STAFF VALUES("
                + Convert.ToInt32(txtstaffnumber.Text) + ",'"
                + txtfirstname.Text + "','"
                + txtlastname.Text + "','"
                + txtaddress.Text + "','"
                + txttelnumber.Text + "','"
                + dpbirthdate.Value.ToString("yyyy-MM-dd") + "','"
                + cbsex.Text +  "',"
                + Convert.ToInt32(txtNIN.Text) + 
            ")");


            DB2ResultSet max_posID = DB.QueryWithResultSet("SELECT MAX(POSITIONHELD_ID) as MAXID FROM POSITIONHELD");
            int posid = 0;

            while (max_posID.Read())
            {
                try
                {
                    posid = Convert.ToInt32(max_posID["MAXID"]) + 1;
                }
                catch (Exception er)
                {
                    posid = 1;
                }
            }

            DB.Query("INSERT INTO POSITIONHELD VALUES("
                + posid + ","
                + Convert.ToInt32(txtstaffnumber.Text) + ","
                + (cbPosition.SelectedIndex + 1) + ","
                + (cbworkshift.SelectedIndex + 1) + ","
                + (cbSalaryPaymnetType.SelectedIndex + 1) + ",'"
                + dtpWorkStartDate.Value.ToString("yyyy-MM-dd") + "',"
                + (cbEmploymentType.SelectedIndex + 1) + 
            ")");

            // positionheld table insert

            int qID = 0;
            int weID = 0;

            if (dgvQualifications.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in dgvQualifications.Rows)
                {

                    DB2ResultSet rsqualID = DB.QueryWithResultSet("SELECT MAX(QUALIFICATION_ID) as QUALMAX FROM QUALIFICATION");

                    while (rsqualID.Read())
                    {
                        try
                        {
                            qID = Convert.ToInt32(rsqualID["QUALMAX"]) + 1;
                        }
                        catch (Exception er)
                        {
                            qID = 1;
                        }
                    }
                    DB.Query("INSERT INTO QUALIFICATION VALUES(" + qID + "," + Convert.ToInt32(txtstaffnumber.Text) + ",'" + row.Cells[0].Value.ToString() + "')");
                }
            }
            
            if (dgvWorkExperience.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row2 in dgvWorkExperience.Rows)
                {
                    
                    DB2ResultSet rsweID = DB.QueryWithResultSet("SELECT MAX(WORKEXPERIENCE_ID) as WEMAX FROM WORKEXPERIENCE");

                    while (rsweID.Read())
                    {
                        try
                        {
                            weID = Convert.ToInt32(rsweID["WEMAX"]) + 1;
                        }
                        catch (Exception er)
                        {
                            weID = 1;
                        }
                    }
                    DB.Query("INSERT INTO WORKEXPERIENCE VALUES(" + weID + "," + Convert.ToInt32(txtstaffnumber.Text) + ",'" + row2.Cells[0].Value.ToString() + "', '" + row2.Cells[1].Value.ToString() + "', '" + row2.Cells[2].Value.ToString() + "', '" + row2.Cells[3].Value.ToString() + "')");
                }
            }
            
            
            dgvQualifications.Rows.Clear();
            dgvWorkExperience.Rows.Clear();
            emptyAllInputFields();

            MessageBox.Show("Record successfully saved!");

            DB2ResultSet max_staffID = DB.QueryWithResultSet("SELECT MAX(STAFF_NUMBER) as MAXID FROM STAFF");

            
            try
            {
                while (max_staffID.Read())
                {
                    txtstaffnumber.Text = (Convert.ToInt32(max_staffID["MAXID"]) + 1).ToString();
                }
            }
            catch (Exception er)
            {
                txtstaffnumber.Text = "10001";
            }
            

            
        }

        private void btnaddqualification_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtQualification.Text))
            {
                return;
            }
            else
            {
                Object[] d = new Object[1];

                d[0] = txtQualification.Text;

                dgvQualifications.Rows.Add(d);
                txtQualification.Text = "";
            }
        }

        private void btn_add_experience_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtOrganization.Text) || String.IsNullOrEmpty(txtPosition.Text) || String.IsNullOrEmpty(dtp_work_experrience_start.Text) || String.IsNullOrEmpty(dtp_work_experrience_finish.Text))
            {
                return;
            }
            else
            {
                Object[] d = new Object[4];

                d[0] = txtOrganization.Text;
                d[1] = txtPosition.Text;
                d[2] = dtp_work_experrience_start.Value.ToString("yyyy-MM-dd");
                d[3] = dtp_work_experrience_finish.Value.ToString("yyyy-MM-dd");

                dgvWorkExperience.Rows.Add(d);
                emptyExperienceInputFields();
            }
        }

        private void emptyExperienceInputFields()
        {
            txtOrganization.Text = "";
            txtPosition.Text = "";
            dtp_work_experrience_start.Text = "";
            dtp_work_experrience_finish.Text = "";
        }

        private void emptyAllInputFields()
        {
            txtstaffnumber.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtaddress.Text = "";
            txttelnumber.Text = "";
            dpbirthdate.Text = "";
            cbsex.SelectedIndex = -1;
            txtNIN.Text = "";
            cbPosition.SelectedIndex = -1;
            cbEmploymentType.SelectedIndex = -1;
            cbworkshift.SelectedIndex = -1;
            dtpWorkStartDate.Text = "";
            cbSalaryPaymnetType.SelectedIndex = -1;

            emptyExperienceInputFields();
        }

        private void btn_clear_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Close the Staff Registration Form","Confirm Action", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                emptyAllInputFields();
                Dispose();
            }
        }

        private void StaffRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(null, "Close the Staff Registration Form", "Confirm Action", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                emptyAllInputFields();
                e.Cancel = true;
            }
        }

        private void StaffRegistration_Load(object sender, EventArgs e)
        {
            cbsex.Items.Add("MALE");
            cbsex.Items.Add("FEMALE");

            DB2ResultSet rsposition = DB.QueryWithResultSet("SELECT POSITION_TITLE FROM POSITION");
            
            while (rsposition.Read())
            {
                cbPosition.Items.Add(rsposition["POSITION_TITLE"]);
            }

            DB2ResultSet rsemploy = DB.QueryWithResultSet("SELECT TYPE FROM EMPLOYMENTTYPE");

            while (rsemploy.Read())
            {
                cbEmploymentType.Items.Add(rsemploy["TYPE"]);
            }

            DB2ResultSet rssalary = DB.QueryWithResultSet("SELECT SALARY_ID, SALARY FROM SALARY");

            while (rssalary.Read())
            {
                cbSalaryPaymnetType.Items.Add(rssalary["SALARY_ID"] + " - Php" + rssalary["SALARY"]);
            }

            DB2ResultSet rsshift = DB.QueryWithResultSet("SELECT * FROM WORKSHIFTTYPE");

            while (rsshift.Read())
            {
                cbworkshift.Items.Add(rsshift["SHIFT"]);
            }

            DB2ResultSet max_staffID = DB.QueryWithResultSet("SELECT MAX(STAFF_NUMBER) as MAXID FROM STAFF");
            
            
            try
            {
                while (max_staffID.Read())
                {
                    txtstaffnumber.Text = (Convert.ToInt32(max_staffID["MAXID"]) + 1).ToString();
                }
            }
            catch(Exception er)
            {
                txtstaffnumber.Text = "10001";
            }
            

  
                
            
            

           
        }
    }
}
