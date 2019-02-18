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
    public partial class ApproveRequisition : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public ApproveRequisition()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        

        private void ApproveRequisition_Load(object sender, EventArgs e)
        {
            cbstatus.Items.Add("PENDING");
            cbstatus.Items.Add("APPROVED");
            cbstatus.Items.Add("DECLINED");

            dgrequisitions.Rows.Clear();
            loadRequisitions("");
            
        }

        private void loadRequisitions(String cond)
        {
            string[] reqs = new string[5];
            DB2ResultSet rsrequests = DB.QueryWithResultSet("SELECT * FROM REQUESITION " + cond);
            while (rsrequests.Read())
            {
                reqs[0] = rsrequests["REQUESITION_NUMBER"].ToString();
                reqs[1] = rsrequests["STAFF_NUMBER"].ToString();
                reqs[2] = rsrequests["WARD_NUMBER"].ToString();
                reqs[3] = rsrequests["DATE_REQUESTED"].ToString();
                reqs[4] = rsrequests["STATUS"].ToString();

                dgrequisitions.Rows.Add(reqs);
            }
        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbstatus.SelectedIndex != -1)
            {
                if (cbstatus.SelectedItem.ToString().Equals("PENDING"))
                {
                    dgrequisitions.Rows.Clear();
                    loadRequisitions("WHERE STATUS = 'PENDING'");
                }
                else if (cbstatus.SelectedItem.ToString().Equals("APPROVED"))
                {
                    dgrequisitions.Rows.Clear();
                    loadRequisitions("WHERE STATUS = 'APPROVED'");
                }
                else if (cbstatus.SelectedItem.ToString().Equals("DECLINED"))
                {
                    dgrequisitions.Rows.Clear();
                    loadRequisitions("WHERE STATUS = 'DECLINED'");
                }
            }
            else
            {
                dgrequisitions.Rows.Clear();
                loadRequisitions("");
            }
        }

        private void loadReqItems(int ReqNum)
        {
            string[] reqs = new string[4];
            DB2ResultSet rsrequests = DB.QueryWithResultSet("SELECT * FROM REQUESITION_ITEMS WHERE REQ_NUMBER = " + ReqNum);
            while (rsrequests.Read())
            {
                reqs[0] = rsrequests["REQITEM_ID"].ToString();
                reqs[1] = rsrequests["ITEM_NUMBER"].ToString();

                DB2ResultSet rsitems = DB.QueryWithResultSet("SELECT ITEM_NAME FROM SUPPLY WHERE ITEM_NUMBER = " + Convert.ToInt32(rsrequests["REQITEM_ID"].ToString()));
                while (rsitems.Read())
                {
                    reqs[2] = rsitems["ITEM_NAME"].ToString();
                    
                }

                reqs[3] = rsrequests["QUANTITY"].ToString();
                
                dgreqitems.Rows.Add(reqs);
            }
        }

        private void dgrequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            int reqNum = Convert.ToInt32(dgrequisitions.Rows[rownum].Cells[0].Value);

            lblreqnum.Text = reqNum.ToString();

            dgreqitems.Rows.Clear();
            loadReqItems(reqNum);

        }

        private void btnapprove_Click(object sender, EventArgs e)
        {
            int selrow = dgrequisitions.CurrentRow.Index;

            DB.Query("UPDATE REQUESITION SET STATUS = 'APPROVED' " +
                            "WHERE REQUESITION_NUMBER = " + Convert.ToInt32(dgrequisitions.Rows[selrow].Cells[0].Value));

            MessageBox.Show("Request has been approved!");

            cbstatus.SelectedIndex = -1;
            dgrequisitions.Rows.Clear();
            loadRequisitions("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selrow = dgrequisitions.CurrentRow.Index;

            DB.Query("UPDATE REQUESITION SET STATUS = 'DECLINED' " +
                            "WHERE REQUESITION_NUMBER = " + Convert.ToInt32(dgrequisitions.Rows[selrow].Cells[0].Value));

            MessageBox.Show("Request has been declined!");

            cbstatus.SelectedIndex = -1;
            dgrequisitions.Rows.Clear();
            loadRequisitions("");
        }

        private void ApprovedReq_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChargeNurseMainMenu frmCN = new ChargeNurseMainMenu();
            frmCN.Show();
            this.Dispose();
        }
    }
}
