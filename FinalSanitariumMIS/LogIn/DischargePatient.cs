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
    public partial class DischargePatient : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;
        public DischargePatient()
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

        private void DischargePatient_Load(object sender, EventArgs e)
        {
            pnldischarged.Visible = false;

            dginpatients.Rows.Clear();
            loadAdmittedPatients();
        }

        private void btndischarge_Click(object sender, EventArgs e)
        {
            int selrow = dginpatients.CurrentRow.Index;

            DialogResult proceed = MessageBox.Show("You are about to discharge this patient.\nProceed?", "DISCHARGE PATIENT", MessageBoxButtons.YesNo);
            if(proceed == DialogResult.Yes)
            {
                DateTime dtToday = DateTime.Today;

                DB.Query("INSERT INTO DISCHARGEDPATIENTS (PATIENT_NUMBER, DATE_DISCHARGED) VALUES("
                            + Convert.ToInt32(dginpatients.Rows[selrow].Cells[0].Value) + ", '"
                            + dtToday.ToString("yyyy-MM-dd")
                            + "')");

                DB.Query("DELETE FROM INPATIENTRECORD WHERE INPATIENT_ID = " + Convert.ToInt32(dginpatients.Rows[selrow].Cells[0].Value));
                dginpatients.Rows.Clear();
                loadAdmittedPatients();
            }

            


        }

        private void loadDischarged()
        {
            string[] dischrgd = new string[4];
            DB2ResultSet rsdschgd = DB.QueryWithResultSet("SELECT * FROM DISCHARGEDPATIENTS");
            while (rsdschgd.Read())
            {
                dischrgd[0] = rsdschgd["DPID"].ToString();
                dischrgd[1] = rsdschgd["PATIENT_NUMBER"].ToString();

                DB2ResultSet rspatient = DB.QueryWithResultSet("SELECT * FROM PATIENT WHERE PATIENT_NUMBER = " + Convert.ToInt32(rsdschgd["PATIENT_NUMBER"]));
                while (rspatient.Read())
                {
                    dischrgd[2] = rspatient["FIRSTNAME"].ToString() + " " + rspatient["LASTNAME"].ToString();
                }

                dischrgd[3] = rspatient["DATE_DISCHARGED"].ToString();

                dgdscharged.Rows.Add(dischrgd);
            }
        }

        private void btnviewdischarged_Click(object sender, EventArgs e)
        {
            dgdscharged.Rows.Clear();
            loadDischarged();
            pnldischarged.Visible = true;
        }

        private void btnclosedsch_Click(object sender, EventArgs e)
        {
            dgdscharged.Rows.Clear();
            pnldischarged.Visible = false;
        }
    }
}
