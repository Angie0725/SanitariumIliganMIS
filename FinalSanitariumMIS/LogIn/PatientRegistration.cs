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
    public partial class PatientRegistration : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public PatientRegistration()
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

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            cbsex.Items.Add("MALE");
            cbsex.Items.Add("FEMALE");

            cbmaritalstat.Items.Add("SINGLE");
            cbmaritalstat.Items.Add("MARRIED");
            cbmaritalstat.Items.Add("SEPARATED/DIVORCED");

            generateNewNOKID();
            loadPatientList();
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

        private void generateNewNOKID()
        {
            DB2ResultSet max_nokID = DB.QueryWithResultSet("SELECT MAX(NEXTOFKIN_ID) as MAXID FROM NEXTOFKIN");

            while (max_nokID.Read())
            {
                try
                {
                    txtnoknum.Text = (Convert.ToInt32(max_nokID["MAXID"]) + 1).ToString();
                }
                catch (Exception er)
                {
                    txtnoknum.Text = "1";
                }
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (!txtpatientnum.Text.Equals("") && !txtpatientfname.Text.Equals("")
                && !txtpatientlname.Text.Equals("") && !txtpatientaddress.Text.Equals("")
                && !txtpatienttelnum.Text.Equals("") && !txtnokfname.Text.Equals("")
                && !txtnoklname.Text.Equals("") && !txtnokaddress.Text.Equals("")
                && !txtnoktelnum.Text.Equals("") && !txtrelationship.Text.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM PATIENT WHERE PATIENT_NUMBER = " + Convert.ToInt32(txtpatientnum.Text));
                if (check.Read())
                {
                    DialogResult res = MessageBox.Show("That Patient Number already exists! Let us give you a NEW Patient Number.", "Existing Patient Number", MessageBoxButtons.OKCancel);

                    if (res == DialogResult.OK)
                    {
                        DB2ResultSet max_salID = DB.QueryWithResultSet("SELECT MAX(PATIENT_NUMBER) as MAXID FROM PATIENT");

                        while (max_salID.Read())
                        {
                            try
                            {
                                txtpatientnum.Text = (Convert.ToInt32(max_salID["MAXID"]) + 1).ToString();
                            }
                            catch (Exception er)
                            {
                                txtpatientnum.Text = "1";
                            }
                        }

                        
                    }

                }
                else
                {
                    

                    DB.Query("INSERT INTO PATIENT VALUES("
                    + Convert.ToInt32(txtpatientnum.Text) + ",'"
                    + txtpatientfname.Text + "','"
                    + txtpatientlname.Text + "','"
                    + txtpatientaddress.Text + "',"
                    + Convert.ToInt32(txtpatienttelnum.Text) + ",'"
                    + dtpbirthdate.Value.ToString("yyyy-MM-dd") + "','"
                    + cbsex.SelectedItem.ToString() + "','"
                    + cbmaritalstat.SelectedItem.ToString() 
                    + "')");

                    dgpatientlist.Rows.Clear();
                    loadPatientList();

                    DB.Query("INSERT INTO NEXTOFKIN VALUES("
                    + Convert.ToInt32(txtnoknum.Text) + ","
                    + Convert.ToInt32(txtpatientnum.Text) + ",'"
                    + txtnokfname.Text + "','"
                    + txtnoklname.Text + "','"
                    + txtnokaddress.Text + "',"
                    + Convert.ToInt32(txtnoktelnum.Text) + ",'"
                    + txtrelationship.Text 
                    + "')");

                    MessageBox.Show("New Patient and Next-Of-Kin record have been saved!");
                    generateNewNOKID();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (!txtpatientnum.Text.Equals("") && !txtpatientfname.Text.Equals("")
                && !txtpatientlname.Text.Equals("") && !txtpatientaddress.Text.Equals("")
                && !txtpatienttelnum.Text.Equals("") && !txtnokfname.Text.Equals("")
                && !txtnoklname.Text.Equals("") && !txtnokaddress.Text.Equals("")
                && !txtnoktelnum.Text.Equals("") && !txtrelationship.Text.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM PATIENT WHERE PATIENT_NUMBER = " + Convert.ToInt32(txtpatientnum.Text));
                if (check.Read())
                {
                    DB.Query("UPDATE PATIENT SET " +
                    " FIRSTNAME = '" + txtpatientfname.Text +
                    "', LASTNAME = '" + txtpatientlname.Text +
                    "', ADDRESS = '" + txtpatientaddress.Text +
                    "', TELNUMBER = " + Convert.ToInt32(txtpatienttelnum.Text) +
                    ", BIRTHDATE = '" + dtpbirthdate.Value.ToString("yyyy-MM-dd") +
                    "', SEX = '" + cbsex.SelectedItem.ToString() +
                    "', MARITAL_STATUS = '" + cbmaritalstat.SelectedItem.ToString() +
                    "' WHERE PATIENT_NUMBER = " + Convert.ToInt32(txtpatientnum.Text));

                    txtpatientnum.Clear();
                    txtpatientfname.Clear();
                    txtpatientlname.Clear();
                    txtpatientaddress.Clear();
                    txtpatienttelnum.Clear();
                    cbsex.SelectedIndex = -1;
                    cbmaritalstat.SelectedIndex = -1;

                    DB.Query("UPDATE NEXTOFKIN SET " +
                    " FIRSTNAME = '" + txtnokfname.Text +
                    "', LASTNAME = '" + txtnoklname.Text +
                    "', ADDRESS = '" + txtnokaddress.Text +
                    "', TELNUMBER = " + Convert.ToInt32(txtnoktelnum.Text) +
                    ", RELATIONSHIP = '" + txtrelationship.Text +
                    "' WHERE NEXTOFKIN_ID  = " + Convert.ToInt32(txtnoknum.Text));

                    generateNewNOKID();
                    txtnokfname.Clear();
                    txtnoklname.Clear();
                    txtnokaddress.Clear();
                    txtnoktelnum.Clear();
                    txtrelationship.Clear();
                    MessageBox.Show("Record successfully updated!");
                    dgpatientlist.Rows.Clear();
                    loadPatientList();
                }
                else
                {
                    MessageBox.Show("That Patient Number does not exist. Please select from the Patient List on the right.");
                }
            }
            else
            {
                MessageBox.Show("Please select (DOUBLE-CLICK) an existing record from the Patient List on the right.");
            }
        }

        private void dgpatientlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            txtpatientnum.Text = dgpatientlist.Rows[rownum].Cells[0].Value.ToString();
            txtpatientfname.Text = dgpatientlist.Rows[rownum].Cells[1].Value.ToString();
            txtpatientlname.Text = dgpatientlist.Rows[rownum].Cells[2].Value.ToString();
            txtpatientaddress.Text = dgpatientlist.Rows[rownum].Cells[3].Value.ToString();
            txtpatienttelnum.Text = dgpatientlist.Rows[rownum].Cells[4].Value.ToString();
            dtpbirthdate.Value = Convert.ToDateTime(dgpatientlist.Rows[rownum].Cells[5].Value);
            cbsex.SelectedItem = dgpatientlist.Rows[rownum].Cells[6].Value.ToString();
            cbmaritalstat.SelectedItem = dgpatientlist.Rows[rownum].Cells[7].Value.ToString();

            DB2ResultSet rsnok = DB.QueryWithResultSet("SELECT * FROM NEXTOFKIN WHERE PATIENT_NUMBER = " + Convert.ToInt32(dgpatientlist.Rows[rownum].Cells[0].Value.ToString()));
            while(rsnok.Read())
            {
                txtnoknum.Text = rsnok["NEXTOFKIN_ID"].ToString();
                txtnokfname.Text = rsnok["FIRSTNAME"].ToString();
                txtnoklname.Text = rsnok["LASTNAME"].ToString();
                txtnokaddress.Text = rsnok["ADDRESS"].ToString();
                txtnoktelnum.Text = rsnok["TELNUMBER"].ToString();
                txtrelationship.Text = rsnok["RELATIONSHIP"].ToString();
            }
        }

        private void PatientReg_FormClosing(object sender, FormClosingEventArgs e)
        {
            StaffMainMenu frmStaff = new StaffMainMenu();
            frmStaff.Show();
            this.Dispose();
        }
    }
}
