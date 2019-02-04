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
    public partial class InPatients : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public InPatients()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        private void loadAdmittedPatients()
        {
            string[] inpatients = new string[6];
            DB2ResultSet rspatient = DB.QueryWithResultSet("SELECT * FROM INPATIENTRECORD");
            while (rspatient.Read())
            {
                inpatients[0] = rspatient["INPATIENT_ID"].ToString();
                inpatients[1] = rspatient["PATIENT_NUMBER"].ToString();
                inpatients[2] = rspatient["BED_ID"].ToString();
                inpatients[3] = rspatient["DATE_ARRIVED"].ToString();
                inpatients[4] = rspatient["DATE_INWARD"].ToString();
                inpatients[5] = rspatient["EXPECTED_DURATION"].ToString();
               

                dginpatients.Rows.Add(inpatients);
            }
        }

        private void loadWaitList()
        {
            dgwaitlist.Rows.Clear();

            string[] waitlist = new string[3];
            DB2ResultSet rswait = DB.QueryWithResultSet("SELECT * FROM WAITLIST ORDER BY ORDERNUM");
            while (rswait.Read())
            {
                waitlist[0] = rswait["ORDERNUM"].ToString();
                waitlist[1] = rswait["PATIENT_NUMBER"].ToString();
                waitlist[2] = rswait["DATE_ARRIVED"].ToString();

                dgwaitlist.Rows.Add(waitlist);
            }
        }

        private void InPatients_Load(object sender, EventArgs e)
        {
            pnlwaitlist.Visible = false;
            pnlpatientlist.Visible = false;

            DB2ResultSet rsbeds = DB.QueryWithResultSet("SELECT * FROM BED WHERE AVAILABILITY = 'AVAILABLE'");
            
                while (rsbeds.Read())
                {
                    cbbeds.Items.Add(rsbeds["BED_ID"].ToString() + " - " + rsbeds["WARD_NUMBER"].ToString());
                }

            DB2ResultSet checkbeds = DB.QueryWithResultSet("SELECT * FROM BED WHERE AVAILABILITY = 'AVAILABLE'");
            if (!checkbeds.Read())
            {
                DialogResult wait = MessageBox.Show("There are no beds available at the moment.\nWould you like to sign up patient for the waiting list?", "NO VACANT BEDS", MessageBoxButtons.YesNo);

                if (wait == DialogResult.Yes)
                {
                    loadWaitList();
                    pnlwaitlist.Visible = true;

                }
                else
                {
                    this.Dispose();
                }

            }


            dginpatients.Rows.Clear();
            loadAdmittedPatients();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnwaitlist_Click(object sender, EventArgs e)
        {
            pnlwaitlist.Visible = true;
        }

        private void btnaddtowait_Click(object sender, EventArgs e)
        {
            if (!txtwaitpatient.Text.Equals(""))
            {
                DateTime dateArrived = DateTime.Today;

                DB.Query("INSERT INTO WAITLIST (PATIENT_NUMBER, DATE_ARRIVED) VALUES("
                                + Convert.ToInt32(txtwaitpatient.Text) + ", '"
                                + dateArrived.ToString("yyyy-MM-dd")
                                + "')");

                loadWaitList();
            }
            else
            {
                MessageBox.Show("Please enter a Patient's Number.");
                txtwaitpatient.Focus();
            }
        }

        private void btnadmitpatient_Click(object sender, EventArgs e)
        {
            if (!txtpatientnum.Text.Equals("") && !lblPatientName.Text.Equals("PATIENT FULL NAME...")
                && !cbbeds.SelectedItem.Equals("") && !txtduration.Text.Equals(""))
            {
                int hypEnd = cbbeds.SelectedItem.ToString().IndexOf("-");
                int bedID = Convert.ToInt32(cbbeds.SelectedItem.ToString().Substring(0, (hypEnd - 1)));

                DB.Query("INSERT INTO INPATIENTRECORD (PATIENT_NUMBER, BED_ID, DATE_ARRIVED, DATE_INWARD, EXPECTED_DURATION) VALUES("
                + Convert.ToInt32(txtpatientnum.Text) + ","
                + bedID + ",'"
                + dtpdatearrived.Value.ToString("yyyy-MM-dd") + "','"
                + dtpinward.Value.ToString("yyyy-MM-dd") + "',"
                + Convert.ToInt32(txtduration.Text) 
                + ")");

                dginpatients.Rows.Clear();
                loadAdmittedPatients();

                MessageBox.Show("Patient has been successfully admitted!");

            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void txtpatientnum_TextChanged(object sender, EventArgs e)
        {
            if (!txtpatientnum.Text.Equals(""))
            {
                DB2ResultSet rspname = DB.QueryWithResultSet("SELECT * FROM PATIENT WHERE PATIENT_NUMBER = " + Convert.ToInt32(txtpatientnum.Text));
                if (rspname.Read())
                {
                    lblPatientName.Text = rspname["FIRSTNAME"].ToString() + " " + rspname["LASTNAME"].ToString();
                }
                else
                {
                    lblPatientName.Text = "PATIENT FULL NAME...";
                }
            }
            else
            {
                lblPatientName.Text = "PATIENT FULL NAME...";
            }
        }

        private void btnclosepatients_Click(object sender, EventArgs e)
        {
            pnlpatientlist.Visible = false;
        }

        private void loadPatientList()
        {
            string[] patients = new string[8];
            DB2ResultSet rspatient = DB.QueryWithResultSet("SELECT * FROM PATIENT");
            while (rspatient.Read())
            {
                patients[0] = rspatient["PATIENT_NUMBER"].ToString();
                patients[1] = rspatient["FIRSTNAME"].ToString();
                patients[2] = rspatient["LASTNAME"].ToString();
                patients[3] = rspatient["ADDRESS"].ToString();
                patients[4] = rspatient["TELNUMBER"].ToString();
                patients[5] = rspatient["BIRTHDATE"].ToString();
                patients[6] = rspatient["SEX"].ToString();
                patients[7] = rspatient["MARITAL_STATUS"].ToString();

                dgpatientlist.Rows.Add(patients);
            }
        }
        private void btnviewpatients_Click(object sender, EventArgs e)
        {
            dgpatientlist.Rows.Clear();
            loadPatientList();
            pnlpatientlist.Visible = true;
        }

        private void dgpatientlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            txtpatientnum.Text = dgpatientlist.Rows[rownum].Cells[0].Value.ToString();

            pnlpatientlist.Visible = false;

        }
    }
}
