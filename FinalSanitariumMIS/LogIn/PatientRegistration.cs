using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalSanitariumMIS.Helpers;
using IBM.Data.DB2;

namespace LogIn
{
    public partial class PatientRegistration : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public PatientRegistration()
        {
            InitializeComponent();
            PopulatePatientMasterList();
        }

        private void PopulatePatientMasterList() 
        {
            DB = new DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM patient ORDER BY firstname DESC");

            dgv_patient_masterlist.Rows.Clear();

            while(rs.Read())
            {
                Object[] d = new Object[13];

                d[0] = rs.GetString(0);
                d[1] = rs.GetString(1);
                d[2] = rs.GetString(2);
                d[3] = rs.GetString(3);
                d[4] = rs.GetString(4);
                d[5] = rs.GetString(5);
                d[6] = rs.GetString(6);
                d[7] = rs.GetString(7);
                d[8] = "-";
                d[9] = "-";
                d[10] = "-";
                d[11] = "-";
                d[12] = "-";

                dgv_patient_masterlist.Rows.Add(d);
            }
        }

        private void EmptyFields()
        {
            tb_patient_number.Text = "";
            tb_firstname.Text = "";
            tb_lastname.Text = "";
            tb_address.Text = "";
            tb_tel_no.Text = "";
            cb_sex.Text = "";
            cb_civil_status.Text = "";
            tb_nextofkin_no.Text = "";
            tb_nok_firstname.Text = "";
            tb_nok_lastname.Text = "";
            tb_nok_address.Text = "";
            tb_nok_tel_no.Text = "";
            tb_nok_relationship.Text = "";
        }

        private void linkback_Click(object sender, EventArgs e)
        {
            MedDirMainMenu frmMD = new MedDirMainMenu();
            frmMD.Show();
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DB = new DatabaseHelper();

            DB.Query("INSERT INTO patient VALUES ("+ tb_patient_number.Text +",'"+ tb_firstname.Text +"','"+ tb_lastname.Text +"','"+ tb_address.Text +"',"+ tb_tel_no.Text +",current timestamp,'"+ cb_sex.Text +"','"+ cb_civil_status.Text +"')");
            DB.Query("INSERT INTO nextofkin VALUES ("+ tb_nextofkin_no.Text +","+ tb_patient_number.Text +",'"+ tb_nok_firstname.Text +"','"+ tb_nok_lastname.Text +"','"+ tb_nok_address.Text +"',"+ tb_nok_tel_no.Text +",'"+ tb_nok_relationship.Text +"')");

            PopulatePatientMasterList();
            EmptyFields();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            tb_patient_number.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[0].Value.ToString();
            tb_firstname.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[1].Value.ToString();
            tb_lastname.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[2].Value.ToString();
            tb_address.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[3].Value.ToString();
            tb_tel_no.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[4].Value.ToString();
            cb_sex.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[5].Value.ToString();
            cb_civil_status.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[6].Value.ToString();

            tb_nextofkin_no.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[7].Value.ToString();
            tb_nok_firstname.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[8].Value.ToString();
            tb_nok_lastname.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[9].Value.ToString();
            tb_nok_address.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[10].Value.ToString();
            tb_nok_tel_no.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[11].Value.ToString();
            tb_nok_relationship.Text = dgv_patient_masterlist.Rows[dgv_patient_masterlist.CurrentRow.Index].Cells[12].Value.ToString();
        }
    }
}
