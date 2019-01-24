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
    public partial class StaffPositionManagement : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;
        private int staffnum = 0;
        private int PosHeldID = 0;

        public StaffPositionManagement()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        private void loadDgvPositionHeld()
        {
            int posid = -1, wsid = -1, salid = -1, empid = -1;


            string[] ph = new string[6];
            DB2ResultSet idnums = DB.QueryWithResultSet("SELECT * FROM POSITIONHELD WHERE STAFF_NUMBER = " + staffnum + " ORDER BY DATE_ASSIGNED DESC");
            while (idnums.Read())
            {

                posid = Convert.ToInt32(idnums["POSITION_ID"]);
                wsid = Convert.ToInt32(idnums["WORKSHIFTTYPE_ID"]);
                salid = Convert.ToInt32(idnums["SALARY_ID"]);
                empid = Convert.ToInt32(idnums["EMPLOYMENT_TYPE"]);

                ph[0] = idnums["POSITIONHELD_ID"].ToString();
                ph[5] = idnums["DATE_ASSIGNED"].ToString();

                DB2ResultSet pos = DB.QueryWithResultSet("SELECT POSITION_TITLE FROM POSITION WHERE POSITION_ID = " + posid);
                while (pos.Read())
                {
                    ph[1] = pos["POSITION_TITLE"].ToString();
                }

                DB2ResultSet ws = DB.QueryWithResultSet("SELECT SHIFT FROM WORKSHIFTTYPE WHERE WORKSHIFTTYPE_ID = " + wsid);
                while (ws.Read())
                {
                    ph[2] = ws["SHIFT"].ToString();
                }

                DB2ResultSet sal = DB.QueryWithResultSet("SELECT SALARY FROM SALARY WHERE SALARY_ID = " + salid);
                while (sal.Read())
                {
                    ph[3] = sal["SALARY"].ToString();
                }

                DB2ResultSet et = DB.QueryWithResultSet("SELECT TYPE FROM EMPLOYMENTTYPE WHERE ETYPE_ID = " + empid);
                while (et.Read())
                {
                    ph[4] = et["TYPE"].ToString();
                }

                dgvpositionheld.Rows.Add(ph);
            }
        }
        private void StaffPositionManagement_Load(object sender, EventArgs e)
        {
            staffnum = Convert.ToInt32(StaffManagement.staffID);

            dgvpositionheld.Rows.Clear();
            loadDgvPositionHeld();

            DB2ResultSet rsposition = DB.QueryWithResultSet("SELECT POSITION_TITLE FROM POSITION");

            while (rsposition.Read())
            {
                cbposition.Items.Add(rsposition["POSITION_TITLE"]);
            }

            DB2ResultSet rsemploy = DB.QueryWithResultSet("SELECT TYPE FROM EMPLOYMENTTYPE");

            while (rsemploy.Read())
            {
                cbtypeemp.Items.Add(rsemploy["TYPE"]);
            }

            DB2ResultSet rssalary = DB.QueryWithResultSet("SELECT SALARY_ID, SALARY FROM SALARY");

            while (rssalary.Read())
            {
                cbSalaryPaymnetType.Items.Add(rssalary["SALARY"].ToString());
            }

            DB2ResultSet rsshift = DB.QueryWithResultSet("SELECT * FROM WORKSHIFTTYPE");

            while (rsshift.Read())
            {
                cbworkshift.Items.Add(rsshift["SHIFT"]);
            }


            DB2ResultSet staffname = DB.QueryWithResultSet("SELECT * FROM STAFF WHERE STAFF_NUMBER = " + staffnum);
            while (staffname.Read())
            {
                txtfullname.Text = staffname["FIRSTNAME"].ToString() + " " + staffname["LASTNAME"].ToString();
            }

            //DB2ResultSet staffdetails = DB.QueryWithResultSet("SELECT * FROM POSITIONHELD WHERE STAFF_NUMBER = " + staffnum + " ORDER BY DATE_ASSIGNED DESC");
            //while (staffdetails.Read())
            //{
                
            //    cbposition.SelectedIndex = Convert.ToInt32(staffdetails["POSITION_ID"]) - 1;
            //    cbtypeemp.SelectedIndex = Convert.ToInt32(staffdetails["EMPLOYMENT_TYPE"]) - 1;
            //    cbworkshift.SelectedIndex = Convert.ToInt32(staffdetails["WORKSHIFTTYPE_ID"]) - 1;
            //    cbSalaryPaymnetType.SelectedIndex = Convert.ToInt32(staffdetails["SALARY_ID"]) - 1;
            //    dtpstartdate.Value = Convert.ToDateTime(staffdetails["DATE_ASSIGNED"]);
            //    break;
            //}

            
        }

        private void dgvpositions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            PosHeldID = Convert.ToInt32(dgvpositionheld.Rows[rownum].Cells[0].Value);
            cbposition.SelectedItem = dgvpositionheld.Rows[rownum].Cells[1].Value.ToString();
            cbworkshift.SelectedItem = dgvpositionheld.Rows[rownum].Cells[2].Value.ToString();
            cbSalaryPaymnetType.SelectedItem = dgvpositionheld.Rows[rownum].Cells[3].Value.ToString();
            cbtypeemp.SelectedItem = dgvpositionheld.Rows[rownum].Cells[4].Value.ToString();
            dtpstartdate.Value = Convert.ToDateTime(dgvpositionheld.Rows[rownum].Cells[5].Value);
        }

        private void btnupdatepos_Click(object sender, EventArgs e)
        {
            DB.Query("UPDATE POSITIONHELD SET " +
                "POSITION_ID = " + (cbposition.SelectedIndex + 1) + 
                ", WORKSHIFTTYPE_ID = " + (cbworkshift.SelectedIndex + 1) +
                ", SALARY_ID = " + (cbSalaryPaymnetType.SelectedIndex + 1) +
                ", DATE_ASSIGNED = '" + dtpstartdate.Value.ToString("yyyy-MM-dd") + 
                "', EMPLOYMENT_TYPE = " + (cbSalaryPaymnetType.SelectedIndex + 1) +
                " WHERE POSITIONHELD_ID = " + PosHeldID);

            dgvpositionheld.Rows.Clear();
            loadDgvPositionHeld();

            MessageBox.Show("The selected position record ahs been updated!");
        }

        private void btnchangepos_Click(object sender, EventArgs e)
        {
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
                + staffnum + ","
                + (cbposition.SelectedIndex + 1) + ","
                + (cbworkshift.SelectedIndex + 1) + ","
                + (cbSalaryPaymnetType.SelectedIndex + 1) + ",'"
                + dtpstartdate.Value.ToString("yyyy-MM-dd") + "',"
                + (cbtypeemp.SelectedIndex + 1) +
            ")");

            dgvpositionheld.Rows.Clear();
            loadDgvPositionHeld();

            MessageBox.Show("New position has been saved!");
        }
    }
}
