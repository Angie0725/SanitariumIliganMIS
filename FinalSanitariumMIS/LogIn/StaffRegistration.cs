using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class StaffRegistration : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public StaffRegistration()
        {
            InitializeComponent();
            emptyAllInputFields();
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Rheamaesabas12", "BILL-LAWRENCE", "sanita");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Add Code For Input Constraint Implementation

            DB.Query("INSERT INTO staff VALUES('" 
                + txtstaffnumber.Text + "','"
                + txtfirstname.Text + "','"
                + txtlastname.Text + "','"
                + txtaddress.Text + "','"
                + txttelnumber.Text + "','"
                + dtp_work_experrience_start.Value.ToString("yyyy-MM-dd") + "','" 
                + cbPosition.Text  + "','"
                + txtNIN.Text + 
            "')");

            foreach (DataGridViewRow row in dgvQualifications.Rows)
            {
                DB.Query("INSERT INTO qualifications VALUES(0," + txtstaffnumber.Text + ",'" + row.Cells[0].Value.ToString() + "')");
            }

            foreach (DataGridViewRow row in dgvQualifications.Rows)
            {
                DB.Query("INSERT INTO workexperience VALUES(0," + txtstaffnumber.Text + ",'" + row.Cells[0].Value.ToString() + "')");
            }

            dgvQualifications.Rows.Clear();
            dgvWorkExperience.Rows.Clear();
            emptyAllInputFields();
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
                d[2] = dtp_work_experrience_start.Text;
                d[3] = dtp_work_experrience_finish.Text;

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
            txtNoHoursWorked.Text = "";
            dtpWorkStartDate.Text = "";

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
    }
}
