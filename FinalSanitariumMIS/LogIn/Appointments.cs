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
    public partial class Appointments : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;
        public Appointments()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        private void linkback_Click(object sender, EventArgs e)
        {
            MedDirMainMenu frmMD = new MedDirMainMenu();
            frmMD.Show();
            this.Hide();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            pnlOPD.Visible = false;
            pnlpatientlist.Visible = false;
            pnldoctors.Visible = false;

            cbapptime.Items.Add("8:00-8:30AM");
            cbapptime.Items.Add("8:30-9:00AM");
            cbapptime.Items.Add("9:00-9:30AM");
            cbapptime.Items.Add("9:30-10:00AM");
            cbapptime.Items.Add("10:00-10:30AM");
            cbapptime.Items.Add("10:30-11:00AM");
            cbapptime.Items.Add("11:00-11:30AM");
            cbapptime.Items.Add("11:30-12:00NN");

            cbapptime.Items.Add("1:00-1:30PM");
            cbapptime.Items.Add("1:30-2:00PM");
            cbapptime.Items.Add("2:00-2:30PM");
            cbapptime.Items.Add("2:30-3:00PM");
            cbapptime.Items.Add("3:00-3:30PM");
            cbapptime.Items.Add("3:30-4:00PM");
            cbapptime.Items.Add("4:00-4:30PM");
            cbapptime.Items.Add("4:30-5:00PM");

            dgappointments.Rows.Clear();
            loadAppointments();
            
        }

        private void dtpappdate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpappdate.Value < DateTime.Today)
            {
                MessageBox.Show("Appointment Date should be from Today and onwards.");
                dtpappdate.Value = DateTime.Today;
            }
        }

        private void loadPatientList()
        {
            string[] pats = new string[8];
            DB2ResultSet rspats = DB.QueryWithResultSet("SELECT * FROM PATIENT");
            while (rspats.Read())
            {
                pats[0] = rspats["PATIENT_NUMBER"].ToString();
                pats[1] = rspats["FIRSTNAME"].ToString();
                pats[2] = rspats["LASTNAME"].ToString();
                pats[3] = rspats["ADDRESS"].ToString();
                pats[4] = rspats["TELNUMBER"].ToString();
                pats[5] = rspats["BIRTHDATE"].ToString();
                pats[6] = rspats["SEX"].ToString();
                pats[7] = rspats["MARITAL_STATUS"].ToString();

                dgpatientlist.Rows.Add(pats);
            }
        }

        private void btnpickpatient_Click(object sender, EventArgs e)
        {
            dgpatientlist.Rows.Clear();
            loadPatientList();
            pnlpatientlist.Visible = true;

        }

        private void loadDoctorsList()
        {
            string[] docs = new string[8];

            DB2ResultSet rspos = DB.QueryWithResultSet("SELECT * FROM POSITIONHELD WHERE POSITION_ID = 4");
            while (rspos.Read())
            {

                DB2ResultSet rsdocs = DB.QueryWithResultSet("SELECT * FROM STAFF WHERE STAFF_NUMBER = " + Convert.ToInt32(rspos["STAFF_NUMBER"]));
                while (rsdocs.Read())
                {
                    docs[0] = rsdocs["STAFF_NUMBER"].ToString();
                    docs[1] = rsdocs["FIRSTNAME"].ToString();
                    docs[2] = rsdocs["LASTNAME"].ToString();
                    docs[3] = rsdocs["ADDRESS"].ToString();
                    docs[4] = rsdocs["TELNUMBER"].ToString();
                    docs[5] = rsdocs["BIRTHDATE"].ToString();
                    docs[6] = rsdocs["SEX"].ToString();
                    docs[7] = rsdocs["NIN"].ToString();

                    dgdoctors.Rows.Add(docs);
                }
            }
        }

        private void btnpickdoctor_Click(object sender, EventArgs e)
        {
            dgdoctors.Rows.Clear();
            loadDoctorsList();
            pnldoctors.Visible = true;
        }

        private void lblcloseOPD_Click(object sender, EventArgs e)
        {
            pnlOPD.Visible = false;
        }

        private void lblclosepatient_Click(object sender, EventArgs e)
        {
            pnlpatientlist.Visible = false;
        }

        private void lblclosedoctor_Click(object sender, EventArgs e)
        {
            pnldoctors.Visible = false;
        }

        private void loadOPD()
        {
            string[] opd = new string[4];

            DB2ResultSet rsopd = DB.QueryWithResultSet("SELECT * FROM OUTPATIENTRECORD");
            while (rsopd.Read())
            {
                opd[0] = rsopd["OUTPATIENT_ID"].ToString();
                opd[1] = rsopd["PATIENT_NUMBER"].ToString();

                DB2ResultSet rspat = DB.QueryWithResultSet("SELECT * FROM PATIENT WHERE PATIENT_NUMBER = " + Convert.ToInt32(rsopd["PATIENT_NUMBER"]));
                while (rspat.Read())
                { 
                    opd[2] = rspat["FIRSTNAME"].ToString() + " " + rspat["LASTNAME"].ToString();
 
                }

                opd[3] = rsopd["LAST_APPOINTMENT"].ToString();

                dgOPD.Rows.Add(opd);
            }
        }

        private void btnviewOPD_Click(object sender, EventArgs e)
        {
            dgOPD.Rows.Clear();
            loadOPD();
            pnlOPD.Visible = true;
        }

        private void loadAppointments()
        {
            string[] apps = new string[9];

            DB2ResultSet rsapps = DB.QueryWithResultSet("SELECT * FROM APPOINTMENT");
            while (rsapps.Read())
            {
                apps[0] = rsapps["APPOINTMENT_NUMBER"].ToString();
                apps[1] = rsapps["OUTPATIENT_ID"].ToString();

                DB2ResultSet rsop = DB.QueryWithResultSet("SELECT PATIENT_NUMBER FROM OUTPATIENTRECORD WHERE OUTPATIENT_ID = " + Convert.ToInt32(rsapps["OUTPATIENT_ID"]));
                while (rsop.Read())
                {
                    apps[2] = rsop["PATIENT_NUMBER"].ToString();

                    DB2ResultSet rspatz = DB.QueryWithResultSet("SELECT FIRSTNAME, LASTNAME FROM PATIENT WHERE PATIENT_NUMBER = " + Convert.ToInt32(rsop["PATIENT_NUMBER"]));
                    while (rspatz.Read())
                    {
                        apps[3] = rspatz["FIRSTNAME"].ToString() + " " + rspatz["LASTNAME"].ToString();
                    }

                }

                apps[4] = rsapps["APPOINTMENT_DATE"].ToString();
                apps[5] = rsapps["APPOINTMENT_TIME"].ToString();
                apps[6] = rsapps["DOCTOR_ID"].ToString();

                DB2ResultSet rsdocz = DB.QueryWithResultSet("SELECT FIRSTNAME, LASTNAME FROM STAFF WHERE STAFF_NUMBER = " + Convert.ToInt32(rsapps["DOCTOR_ID"]));
                while (rsdocz.Read())
                {
                    apps[7] = rsdocz["FIRSTNAME"].ToString() + " " + rsdocz["LASTNAME"].ToString();
                }

                apps[8] = rsapps["DATE_PROCESSED"].ToString();

                dgappointments.Rows.Add(apps);
            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            int opdID = 0;

            if (!txtdoctorID.Text.Equals("") && !txtpatientnum.Text.Equals(""))
            {
                
                DB.Query("INSERT INTO OUTPATIENTRECORD (PATIENT_NUMBER, LAST_APPOINTMENT) VALUES("
                            + Convert.ToInt32(txtpatientnum.Text) + ",'"
                            + dtpappdate.Value.ToString("yyyy-MM-dd") + "'" +
                            ")");

                DB2ResultSet rsopdid = DB.QueryWithResultSet("SELECT OUTPATIENT_ID FROM OUTPATIENTRECORD WHERE PATIENT_NUMBER = " + Convert.ToInt32(txtpatientnum.Text) + " AND LAST_APPOINTMENT = '" + dtpappdate.Value.ToString("yyyy-MM-dd") + "'");
                while (rsopdid.Read())
                {
                    opdID = Convert.ToInt32(rsopdid["OUTPATIENT_ID"]);
                }

                    DB.Query("INSERT INTO APPOINTMENT (OUTPATIENT_ID, APPOINTMENT_DATE, APPOINTMENT_TIME, DOCTOR_ID, DATE_PROCESSED) VALUES("
                            + opdID + ",'"
                            + dtpappdate.Value.ToString("yyyy-MM-dd") + "','" 
                            + cbapptime.SelectedItem.ToString() + "'," +
                            + Convert.ToInt32(txtdoctorID.Text) + ",'"
                            + dtpprocessed.Value.ToString("yyyy-MM-dd") + "'" +
                            ")");

                MessageBox.Show("Appointment successfully saved.");

                dgappointments.Rows.Clear();
                loadAppointments();
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void dgpatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            txtpatientnum.Text = dgpatientlist.Rows[rownum].Cells[0].Value.ToString();

            pnlpatientlist.Visible = false;
        }

        private void dgdoctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            txtdoctorID.Text = dgdoctors.Rows[rownum].Cells[0].Value.ToString();

            pnldoctors.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(!txtAppNum.Text.Equals("") && !txtopdID.Text.Equals("") && !txtdoctorID.Text.Equals("") && !txtpatientnum.Text.Equals(""))
            {
                DB.Query("UPDATE APPOINTMENT SET " +
                            "APPOINTMENT_DATE = '" + dtpappdate.Value.ToString("yyyy-MM-dd") + "'," +
                            "APPOINTMENT_TIME = '" + cbapptime.SelectedItem.ToString() + "'," +
                            "DOCTOR_ID = " + Convert.ToInt32(txtdoctorID.Text) + "," +
                            "DATE_PROCESSED = '" + dtpprocessed.Value.ToString("yyyy-MM-dd") + "' " +
                            "WHERE APPOINTMENT_NUMBER = " + Convert.ToInt32(txtAppNum.Text));

                DB.Query("UPDATE OUTPATIENTRECORD SET " +
                            "LAST_APPOINTMENT = '" + dtpappdate.Value.ToString("yyyy-MM-dd") + "' " +
                            "WHERE OUTPATIENT_ID = " + Convert.ToInt32(txtopdID.Text));


                MessageBox.Show("Appointment record has been successfully updated!");
                dgappointments.Rows.Clear();
                loadAppointments();
            }
            else
            {
                MessageBox.Show("Please select an existing appointment record and fill out all fields.");
            }
        }

        private void dgappointment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            txtAppNum.Text = dgappointments.Rows[rownum].Cells[0].Value.ToString();
            txtopdID.Text = dgappointments.Rows[rownum].Cells[1].Value.ToString();
            txtpatientnum.Text = dgappointments.Rows[rownum].Cells[2].Value.ToString();
            dtpappdate.Value = Convert.ToDateTime(dgappointments.Rows[rownum].Cells[4].Value.ToString());
            cbapptime.SelectedItem = dgappointments.Rows[rownum].Cells[5].Value.ToString();
        }

        private void txtpatientnum_TextChanged(object sender, EventArgs e)
        {
            if (!txtpatientnum.Text.Equals(""))
            {
                DB2ResultSet rspatt = DB.QueryWithResultSet("SELECT * FROM PATIENT WHERE PATIENT_NUMBER = " + Convert.ToInt32(txtpatientnum.Text));
                while (rspatt.Read())
                {
                    lblpatientname.Text = rspatt["FIRSTNAME"].ToString() + " " + rspatt["LASTNAME"].ToString();
                }
            }
            else
            {
                lblpatientname.Text = "PATIENT NAME HERE...";
            }
        }

        private void txtdoctorID_TextChanged(object sender, EventArgs e)
        {
            if (!txtdoctorID.Text.Equals(""))
            {
                DB2ResultSet rsdooc = DB.QueryWithResultSet("SELECT * FROM STAFF WHERE STAFF_NUMBER = " + Convert.ToInt32(txtdoctorID.Text));
                while (rsdooc.Read())
                {
                    lbldoctorname.Text = rsdooc["FIRSTNAME"].ToString() + " " + rsdooc["LASTNAME"].ToString();
                }
            }
            else
            {
                lbldoctorname.Text = "DOCTOR NAME HERE...";
            }
        }

        private void Appointments_FormClosing(object sender, FormClosingEventArgs e)
        {
            StaffMainMenu frmStaff = new StaffMainMenu();
            frmStaff.Show();
            this.Dispose();
        }
    }
}
