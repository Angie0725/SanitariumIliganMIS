using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalSanitariumMIS;
using IBM.Data.DB2;

namespace LogIn
{
    public partial class Requisitions : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;
        private int reqNumber = 0;

        public Requisitions()
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

        private void loadRequests()
        {
            string[] reqlist = new string[5];
            DB2ResultSet reqs = DB.QueryWithResultSet("SELECT * FROM REQUESITION");
            while (reqs.Read())
            {
                reqlist[0] = reqs["REQUESITION_NUMBER"].ToString();
                reqlist[1] = reqs["STAFF_NUMBER"].ToString();
                reqlist[2] = reqs["WARD_NUMBER"].ToString();
                reqlist[3] = reqs["DATE_REQUESTED"].ToString();
                reqlist[4] = reqs["STATUS"].ToString();

                dg_requestdetails.Rows.Add(reqlist);
            }
        }

        private void Requisitions_Load(object sender, EventArgs e)
        {
            pnlAddItems.Visible = false;

            DB2ResultSet rswname = DB.QueryWithResultSet("SELECT NAME FROM WARD");
            while (rswname.Read())
            {
                cbward.Items.Add(rswname["NAME"].ToString());
            }

            LoginDetails oIDNum = new LoginDetails();
            txtreqby.Text = oIDNum.getStaffNum().ToString();

            loadRequests();

        }

        private void btnrequest_Click(object sender, EventArgs e)
        {
            string wardID = "";
            if (!txtreqnumber.Text.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM REQUESITION WHERE REQUESITION_NUMBER = " + Convert.ToInt32(txtreqnumber.Text));
                if (check.Read())
                {
                    DialogResult res = MessageBox.Show("That Requisition Number already exists! Let us give you a NEW Requisition Number.", "Existing Requisition Number", MessageBoxButtons.OKCancel);

                    if (res == DialogResult.OK)
                    {
                        DB2ResultSet max_salID = DB.QueryWithResultSet("SELECT MAX(REQUESITION_NUMBER) as MAXID FROM REQUESITION");

                        while (max_salID.Read())
                        {
                            try
                            {
                                txtreqnumber.Text = (Convert.ToInt32(max_salID["MAXID"]) + 1).ToString();
                            }
                            catch (Exception er)
                            {
                                txtreqnumber.Text = "1";
                            }
                        }
                    }

                }
                else
                {
                    DB2ResultSet rsward = DB.QueryWithResultSet("SELECT WARD_NUMBER FROM WARD WHERE NAME = '" + cbward.SelectedItem.ToString() + "'");
                    while (rsward.Read())
                    {
                        wardID = rsward["WARD_NUMBER"].ToString();
                    }

                    DB.Query("INSERT INTO REQUESITION VALUES("
                    + Convert.ToInt32(txtreqnumber.Text) + ","
                    + Convert.ToInt32(txtreqby.Text) + ",'"
                    + wardID + "','"
                    + dtpreqdate.Value.ToString("yyyy-MM-dd") + "','"
                    + "PENDING" + "'"
                    + ")");

                    dg_requestdetails.Rows.Clear();
                    loadRequests();

                    MessageBox.Show("New Request has been saved!");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void loadInventory()
        {
            string[] invlist = new string[3];
            DB2ResultSet rsinventory = DB.QueryWithResultSet("SELECT ITEM_NUMBER, ITEM_NAME, QUANTITY FROM SUPPLY");
            while (rsinventory.Read())
            {
                invlist[0] = rsinventory["ITEM_NUMBER"].ToString();
                invlist[1] = rsinventory["ITEM_NAME"].ToString();
                invlist[2] = rsinventory["QUANTITY"].ToString();

                dg_inventory.Rows.Add(invlist);
            }
        }

        private void loadReqItems()
        {
            string[] reqlist = new string[4];
            DB2ResultSet rsreqitems = DB.QueryWithResultSet("SELECT REQITEM_ID, ITEM_NUMBER, QUANTITY FROM REQUESITION_ITEMS WHERE REQ_NUMBER = " + reqNumber);
            while (rsreqitems.Read())
            {
                reqlist[0] = rsreqitems["REQITEM_ID"].ToString();
                reqlist[1] = rsreqitems["ITEM_NUMBER"].ToString();
                reqlist[3] = rsreqitems["QUANTITY"].ToString();

                DB2ResultSet rsitemname = DB.QueryWithResultSet("SELECT ITEM_NAME FROM SUPPLY WHERE ITEM_NUMBER = " + Convert.ToInt32(rsreqitems["ITEM_NUMBER"]));
                while (rsitemname.Read())
                {
                    reqlist[2] = rsitemname["ITEM_NAME"].ToString();
                }

                dg_requestitems.Rows.Add(reqlist);
            }
        }

        private void dgrequestdetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            pnlAddItems.Visible = true;
            reqNumber = Convert.ToInt32(dg_requestdetails.Rows[rownum].Cells[0].Value);
            lblreqnum.Text = lblreqnum.Text + dg_requestdetails.Rows[rownum].Cells[0].Value.ToString();

            dg_inventory.Rows.Clear();
            loadInventory();
            dg_requestitems.Rows.Clear();
            loadReqItems();
        }

        private void btnupdatereq_Click(object sender, EventArgs e)
        {
            if (!txtreqnumber.Text.Equals(""))
            {
                string wardnum = "";
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM REQUESITION WHERE REQUESITION_NUMBER = " + Convert.ToInt32(txtreqnumber.Text));
                if (check.Read())
                {
                    DB2ResultSet rswardnum = DB.QueryWithResultSet("SELECT WARD_NUMBER FROM WARD WHERE NAME = '" + cbward.SelectedItem.ToString() + "'");
                    while(rswardnum.Read())
                    {
                        wardnum = rswardnum["WARD_NUMBER"].ToString();
                    }

                        DB.Query("UPDATE REQUESITION SET " +
                    " STAFF_NUMBER = " + Convert.ToInt32(txtreqby.Text) +
                    ", WARD_NUMBER = '" + wardnum +
                    "', DATE_REQUESTED = '" + dtpreqdate.Value.ToString("yyyy-MM-dd") +
                    "', STATUS = '" + "PENDING" +
                    "' WHERE REQUESITION_NUMBER = " + Convert.ToInt32(txtreqnumber.Text));

                    txtreqnumber.Clear();
                    cbward.SelectedIndex = -1;
                    
                    MessageBox.Show("Record successfully updated!");
                    dg_requestdetails.Rows.Clear();
                    loadRequests();
                }
                else
                {
                    MessageBox.Show("That Requisition Number does not exist. Please select from the Request List below.");
                }
            }
            else
            {
                MessageBox.Show("Please select an existing record from the Request List on the right.");
            }
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            int selrow = dg_inventory.CurrentRow.Index;

            int itemnum = Convert.ToInt32(dg_inventory.Rows[selrow].Cells[0].Value);

            if (!txtreqqty.Text.Equals(""))
            {
                DB.Query("INSERT INTO REQUESITION_ITEMS (REQ_NUMBER, ITEM_NUMBER, QUANTITY) VALUES("
                + reqNumber + ","
                + itemnum + ","
                + Convert.ToInt32(txtreqqty.Text)
                + ")");

                dg_requestitems.Rows.Clear();
                loadReqItems();
            }
            else
            {
                MessageBox.Show("Please enter the desired quantity.");
            }
        }

        private void btnremoveitem_Click(object sender, EventArgs e)
        {
            int selrow = dg_requestitems.CurrentRow.Index;

            int reqitemID = Convert.ToInt32(dg_requestitems.Rows[selrow].Cells[0].Value);

            DialogResult removeitem = MessageBox.Show("Are you sure you want to remove this item from the request?", "Remove Item", MessageBoxButtons.YesNo);

            if(removeitem == DialogResult.Yes)
            {
                DB.Query("DELETE FROM REQUESITION_ITEMS WHERE REQITEM_ID = " + reqitemID);
                MessageBox.Show("Item was successfully removed.");
                dg_requestitems.Rows.Clear();
                loadReqItems();
            }
            
        }

        private void dgrequestdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            txtreqnumber.Text = dg_requestdetails.Rows[rownum].Cells[0].Value.ToString();

            DB2ResultSet rswardname = DB.QueryWithResultSet("SELECT NAME FROM WARD WHERE WARD_NUMBER = '" + dg_requestdetails.Rows[rownum].Cells[2].Value.ToString() + "'");
            while (rswardname.Read())
            {
                cbward.SelectedItem = rswardname["NAME"].ToString();
            }

            dtpreqdate.Value = Convert.ToDateTime(dg_requestdetails.Rows[rownum].Cells[3].Value.ToString());
        }
    }
}
