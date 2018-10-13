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
    public partial class StaffManagement : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;
        private int selectedQuali = -1;
        private int selectedWE = -1;
        public static string staffID = "";

        public StaffManagement()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "ANGELIE BUEN", "sanita");
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            pnlEmployeeBG.Hide();

            cbsex.Items.Add("MALE");
            cbsex.Items.Add("FEMALE");

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM STAFF");
            string []ds = new string[8];

            while (rs.Read())
            {
                ds[0] = rs["STAFF_NUMBER"].ToString();
                ds[1] = rs["FIRSTNAME"].ToString();
                ds[2] = rs["LASTNAME"].ToString();
                ds[3] = rs["ADDRESS"].ToString();
                ds[4] = rs["TELNUMBER"].ToString();
                ds[5] = rs["BIRTHDATE"].ToString();
                ds[6] = rs["SEX"].ToString();
                ds[7] = rs["NIN"].ToString();

                dgvStaffList.Rows.Add(ds);

                
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!txtstaffnumber.Text.Equals("") && !txtfirstname.Text.Equals("") && !txtlastname.Text.Equals("") 
                && !txtaddress.Text.Equals("") && !txttelnumber.Text.Equals("") && !txtNIN.Text.Equals(""))
            {
                DB.Query("UPDATE STAFF SET " +
                    " FIRSTNAME = '" + txtfirstname.Text + 
                    "', LASTNAME = '" + txtlastname.Text +
                    "', ADDRESS = '" + txtaddress.Text +
                    "', TELNUMBER = '" + txttelnumber.Text +
                    "', BIRTHDATE = '" + dpbirthdate.Value.ToString("yyyy-MM-dd") +
                    "', SEX = '" + cbsex.Text +
                    "', NIN = '" + txtNIN.Text + 
                    "' WHERE STAFF_NUMBER = " + Convert.ToInt32(txtstaffnumber.Text));

                emptyAllInputFields();
                MessageBox.Show("Record successfully update!");
            }
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
            
        }

        private void dgvStaffList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex;

            txtstaffnumber.Text = dgvStaffList.Rows[rowid].Cells[0].Value.ToString();
            txtfirstname.Text = dgvStaffList.Rows[rowid].Cells[1].Value.ToString();
            txtlastname.Text = dgvStaffList.Rows[rowid].Cells[2].Value.ToString();
            txtaddress.Text = dgvStaffList.Rows[rowid].Cells[3].Value.ToString();
            txttelnumber.Text = dgvStaffList.Rows[rowid].Cells[4].Value.ToString();
            dpbirthdate.Value = Convert.ToDateTime(dgvStaffList.Rows[rowid].Cells[5].Value);
            cbsex.SelectedItem = dgvStaffList.Rows[rowid].Cells[6].Value.ToString();
            txtNIN.Text = dgvStaffList.Rows[rowid].Cells[7].Value.ToString();
        }

        private void btnPromoteDemote_Click(object sender, EventArgs e)
        {
            StaffPositionManagement frmPosMgt = new StaffPositionManagement();
            staffID = txtstaffnumber.Text;
            frmPosMgt.Show();
            this.Hide();
        }

        private void btnemployeebg_Click(object sender, EventArgs e)
        {
            pnlEmployeeBG.Show();

        }

        private void pnlEmployeeBG_Paint(object sender, PaintEventArgs e)
        {
           
            lblEmpName.Text = txtstaffnumber.Text + " - " + txtfirstname.Text + " " + txtlastname.Text;

            loadQualificationList();
            loadWorkExperiencesList();

            
        }

        private void loadQualificationList()
        {
            DB2ResultSet quali = DB.QueryWithResultSet("SELECT * FROM QUALIFICATION WHERE STAFF_NUMBER = " + Convert.ToInt32(txtstaffnumber.Text));
            string[] qtb = new string[2];

            while (quali.Read())
            {
                qtb[0] = quali["QUALIFICATION_ID"].ToString();
                qtb[1] = quali["DESCRIPTION"].ToString();

                dgvqualifications.Rows.Add(qtb);
            }
        }

        private void loadWorkExperiencesList()
        {
            DB2ResultSet we = DB.QueryWithResultSet("SELECT * FROM WORKEXPERIENCE WHERE STAFF_NUMBER = " + Convert.ToInt32(txtstaffnumber.Text));
            string[] wtb = new string[5];

            while (we.Read())
            {
                wtb[0] = we["WORKEXPERIENCE_ID"].ToString();
                wtb[1] = we["POSITION"].ToString();
                wtb[2] = we["ORGANIZATION"].ToString();
                wtb[3] = we["START_DATE"].ToString();
                wtb[4] = we["END_DATE"].ToString();

                dgvworkexperiences.Rows.Add(wtb);
            }
        }

        private void dgvqualification_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex;

            selectedQuali = Convert.ToInt32(dgvqualifications.Rows[rowid].Cells[0].Value);
            txtQualification.Text = dgvqualifications.Rows[rowid].Cells[1].Value.ToString();
        }

        private void dgvworkexperiences_CellContenDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex;

            selectedWE = Convert.ToInt32(dgvworkexperiences.Rows[rowid].Cells[0].Value);
            txtPosition.Text = dgvworkexperiences.Rows[rowid].Cells[1].Value.ToString();
            txtOrganization.Text = dgvworkexperiences.Rows[rowid].Cells[2].Value.ToString();
            dtp_work_experrience_start.Value = Convert.ToDateTime(dgvworkexperiences.Rows[rowid].Cells[3].Value.ToString());
            dtp_work_experrience_finish.Value = Convert.ToDateTime(dgvworkexperiences.Rows[rowid].Cells[4].Value.ToString());
        }

        private void btnaddQuali_Click(object sender, EventArgs e)
        {
            if (!txtQualification.Text.Equals(""))
            {
                DB2ResultSet last_qid = DB.QueryWithResultSet("SELECT MAX(QUALIFICATION_ID) as MAXID FROM QUALIFICATION");
                int id = 0;

                while (last_qid.Read())
                {
                    try
                    {
                        id = Convert.ToInt32(last_qid["MAXID"]) + 1;
                    }
                    catch (Exception er)
                    {
                        id = 1;
                    }
                }

                DB.Query("INSERT INTO QUALIFICATION VALUES(" + id + ", " + Convert.ToInt32(txtstaffnumber.Text) + ", '" + txtQualification.Text + "')");
                MessageBox.Show("A new Qualification for " + txtfirstname.Text + " " + txtlastname.Text + " has been added!");
                dgvqualifications.Rows.Clear();
                loadQualificationList();
            }
            else
            {
                MessageBox.Show("Please fill in the qualification description.");
                txtQualification.Focus();
            }
        }

        private void btnaddWE_Click(object sender, EventArgs e)
        {
            if (!txtOrganization.Text.Equals("") && !txtPosition.Text.Equals(""))
            {
                DB2ResultSet last_wid = DB.QueryWithResultSet("SELECT MAX(WORKEXPERIENCE_ID) as MAXID FROM WORKEXPERIENCE");
                int id = 0;

                while (last_wid.Read())
                {
                    try
                    {
                        id = Convert.ToInt32(last_wid["MAXID"]) + 1;
                    }
                    catch (Exception er)
                    {
                        id = 1;
                    }
                }

                DB.Query("INSERT INTO WORKEXPERIENCE VALUES(" + id + ", " + Convert.ToInt32(txtstaffnumber.Text) 
                    + ", '" + txtPosition.Text + "', '" 
                    + txtOrganization.Text + "', '" 
                    + dtp_work_experrience_start.Value.ToString("yyyy-MM-dd") + "', '"
                    + dtp_work_experrience_finish.Value.ToString("yyyy-MM-dd") + "')");

                MessageBox.Show("A new Work Experience for " + txtfirstname.Text + " " + txtlastname.Text + " has been added!");
                dgvworkexperiences.Rows.Clear();
                loadWorkExperiencesList();
            }
            else
            {
                MessageBox.Show("Please fill in all details for the work experience.");
                txtOrganization.Focus();
            }
        }

        private void btnchangeQuali_Click(object sender, EventArgs e)
        {

            DB.Query("UPDATE QUALIFICATION SET DESCRIPTION = '" + txtQualification.Text + "' WHERE QUALIFICATION_ID = " + selectedQuali);

            MessageBox.Show("A Qualification record for " + txtfirstname.Text + " " + txtlastname.Text + " has been updated!");
            dgvqualifications.Rows.Clear();
            loadQualificationList();
        }

        private void btnchangeWE_Click(object sender, EventArgs e)
        {

            DB.Query("UPDATE WORKEXPERIENCE SET POSITION = '" + txtPosition.Text 
                + "', ORGANIZATION = '" + txtOrganization.Text 
                + "', START_DATE = '" + dtp_work_experrience_start.Value.ToString("yyyy-MM-dd") 
                + "', END_DATE = '" + dtp_work_experrience_finish.Value.ToString("yyyy-MM-dd")
                + "' WHERE WORKEXPERIENCE_ID = " + selectedWE);

            MessageBox.Show("A Work Experience record for " + txtfirstname.Text + " " + txtlastname.Text + " has been updated!");
            dgvworkexperiences.Rows.Clear();
            loadWorkExperiencesList();
        }

        private void btnremoveQuali_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Selected Record will be permanently deleted.\n Do you wish to proceed?", "Confirm Deletion", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {
                int selID = Convert.ToInt32(dgvqualifications.CurrentRow.Cells[0].Value);

                DB.Query("DELETE FROM QUALIFICATION WHERE QUALIFICATION_ID = " + selID);

                MessageBox.Show("A Qualification record for " + txtfirstname.Text + " " + txtlastname.Text + " has been PERMANENTLY REMOVED!");
                dgvqualifications.Rows.Clear();
                loadQualificationList();
            }
        }

        private void btnremoveWE_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Selected Record will be permanently deleted.\n Do you wish to proceed?", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                int selID = Convert.ToInt32(dgvworkexperiences.CurrentRow.Cells[0].Value);

                DB.Query("DELETE FROM WORKEXPERIENCE WHERE WORKEXPERIENCE_ID = " + selID);

                MessageBox.Show("A Work Experience record for " + txtfirstname.Text + " " + txtlastname.Text + " has been PERMANENTLY REMOVED!");
                dgvworkexperiences.Rows.Clear();
                loadWorkExperiencesList();
            }
        }
    }
}
