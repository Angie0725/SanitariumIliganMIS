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
    public partial class StaffWardAllocation : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;
        private string wardID = "";

        public StaffWardAllocation()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "ANGELIE BUEN", "sanita");
        }

        private void StaffWardAllocation_Load(object sender, EventArgs e)
        {
            pnlstafflist.Hide();

            DB2ResultSet rsward = DB.QueryWithResultSet("SELECT NAME FROM WARD");
            while (rsward.Read())
            {
                cbward.Items.Add(rsward["NAME"].ToString());
            }

            loadStaffAllocList();
            
        }

        private void loadStaffAllocList()
        {
            string[] asswards = new string[5];

            DB2ResultSet rswalloc = DB.QueryWithResultSet("SELECT * FROM ASSIGNEDWARD");
            while (rswalloc.Read())
            {
                asswards[2] = rswalloc["WARD_NUMBER"].ToString();
                asswards[0] = rswalloc["STAFF_NUMBER"].ToString();
                asswards[4] = rswalloc["DATE_ASSIGNED"].ToString();

                DB2ResultSet rswardname = DB.QueryWithResultSet("SELECT NAME FROM WARD WHERE WARD_NUMBER = '" + rswalloc["WARD_NUMBER"].ToString() + "'");
                while (rswardname.Read())
                {
                    asswards[3] = rswardname["NAME"].ToString();
                }

                DB2ResultSet rsfname = DB.QueryWithResultSet("SELECT FIRSTNAME, LASTNAME FROM STAFF WHERE STAFF_NUMBER = " + Convert.ToInt32(rswalloc["STAFF_NUMBER"]));
                while (rsfname.Read())
                {
                    asswards[1] = rsfname["FIRSTNAME"].ToString() + " " + rsfname["LASTNAME"].ToString();
                }

                dgvwardallocation.Rows.Add(asswards);
            }
        }

        private void btnsearchstaff_Click(object sender, EventArgs e)
        {
            pnlstafflist.Show();
        }

        private void pnlstafflist_Paint(object sender, PaintEventArgs e)
        {
            dgvstafflist.Rows.Clear();
            string[] slist = new string[8];

            DB2ResultSet rsstafflist = DB.QueryWithResultSet("SELECT * FROM STAFF");
            while (rsstafflist.Read())
            {
                slist[0] = rsstafflist["STAFF_NUMBER"].ToString();
                slist[1] = rsstafflist["FIRSTNAME"].ToString();
                slist[2] = rsstafflist["LASTNAME"].ToString();
                slist[3] = rsstafflist["ADDRESS"].ToString();
                slist[4] = rsstafflist["TELNUMBER"].ToString();
                slist[5] = rsstafflist["BIRTHDATE"].ToString();
                slist[6] = rsstafflist["SEX"].ToString();
                slist[7] = rsstafflist["NIN"].ToString();

                dgvstafflist.Rows.Add(slist);

            }
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            
            txtstaffnumber.Text = dgvstafflist.CurrentRow.Cells[0].Value.ToString();
            pnlstafflist.Hide();
        }

        private void txtstaffnumber_TextChanged(object sender, EventArgs e)
        {
            DB2ResultSet rsfname = DB.QueryWithResultSet("SELECT FIRSTNAME, LASTNAME FROM STAFF WHERE STAFF_NUMBER = " + Convert.ToInt32(txtstaffnumber.Text));
            while (rsfname.Read())
            {
                lblfullname.Text = rsfname["FIRSTNAME"].ToString() + " " + rsfname["LASTNAME"].ToString();
            }
        }

        private void cbward_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB2ResultSet rswardid = DB.QueryWithResultSet("SELECT WARD_NUMBER FROM WARD WHERE NAME = '" + cbward.SelectedItem.ToString() + "'");
            while (rswardid.Read())
            {
                wardID = rswardid["WARD_NUMBER"].ToString();
            }
        }

        private void btnupdatedesig_Click(object sender, EventArgs e)
        {
            if (!txtstaffnumber.Equals(""))
            {
                DB2ResultSet rsstaff = DB.QueryWithResultSet("SELECT * FROM ASSIGNEDWARD WHERE STAFF_NUMBER = " + Convert.ToInt32(txtstaffnumber.Text));
                if (rsstaff.Read())
                {
                    string wardnum = "";
                    DB2ResultSet wardid = DB.QueryWithResultSet("SELECT WARD_NUMBER FROM WARD WHERE NAME = '" + cbward.SelectedItem.ToString() + "'");
                    if (wardid.Read())
                    {
                        wardnum = wardid["WARD_NUMBER"].ToString();
                    }
                        DB.Query("UPDATE ASSIGNEDWARD SET" +
                                " WARD_NUMBER = '" + wardnum +
                                "', DATE_ASSIGNED = '" + dtpdateassigned.Value.ToString("yyyy-MM-dd") +
                                "' WHERE STAFF_NUMBER = " + Convert.ToInt32(txtstaffnumber.Text));

                    dgvwardallocation.Rows.Clear();
                    loadStaffAllocList();

                    MessageBox.Show("Assigned staff has been updated!");
                }
                else
                {
                    MessageBox.Show("This staff does not exist!");
                }
            }
        }

        private void btnchoosestaff_Click(object sender, EventArgs e)
        {
            DB2ResultSet rsstaff = DB.QueryWithResultSet("SELECT * FROM ASSIGNEDWARD WHERE STAFF_NUMBER = " + Convert.ToInt32(txtstaffnumber.Text));
            if (rsstaff.Read())
            {
                MessageBox.Show("This staff was already assigned to a ward. \nYou can UPDATE if you wish to change the designation.");
            }
            else
            {
                DB.Query("INSERT INTO ASSIGNEDWARD VALUES('"
                + wardID + "',"
                + Convert.ToInt32(txtstaffnumber.Text) + ",'"
                + dtpdateassigned.Value.ToString("yyyy-MM-dd") + 
                "')");

                MessageBox.Show("Selected Staff has been assigned!");

                dgvwardallocation.Rows.Clear();
                loadStaffAllocList();
            }
        }

        private void dgvwardallocation_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            txtstaffnumber.Text = dgvwardallocation.Rows[rownum].Cells[0].Value.ToString();
            cbward.SelectedItem = dgvwardallocation.Rows[rownum].Cells[3].Value.ToString();
            dtpdateassigned.Value = Convert.ToDateTime(dgvwardallocation.Rows[rownum].Cells[4].Value);
        }
    }
}
