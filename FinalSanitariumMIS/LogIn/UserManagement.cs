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
    public partial class UserManagement : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public UserManagement()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        private void loadAccounts()
        {
            string[] userz = new string[5];
            DB2ResultSet rsacct = DB.QueryWithResultSet("SELECT * FROM ACCOUNT");
            while (rsacct.Read())
            {
                userz[0] = rsacct["ACCOUNT_NO"].ToString();
                userz[1] = rsacct["STAFF_NUMBER"].ToString();
                userz[2] = rsacct["USERNAME"].ToString();
                userz[3] = rsacct["PASSCODE"].ToString();
                userz[4] = rsacct["ACCOUNT_TYPE"].ToString();

                dgusers.Rows.Add(userz);
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            dgusers.Rows.Clear();
            loadAccounts();

            cbaccttype.Items.Add("MEDICAL DIRECTOR");
            cbaccttype.Items.Add("PERSONNEL OFFICER");
            cbaccttype.Items.Add("CHARGE NURSE");
            cbaccttype.Items.Add("STAFF");
        }

        private void txtstaffnum_TextChanged(object sender, EventArgs e)
        {
   
            int posid = 0;
            if (!txtstaffnum.Text.Equals(""))
            {
                DB2ResultSet rsstaff = DB.QueryWithResultSet("SELECT FIRSTNAME, LASTNAME FROM STAFF WHERE STAFF_NUMBER = " + Convert.ToInt32(txtstaffnum.Text));
                while (rsstaff.Read())
                {
                    lblstaffname.Text = rsstaff["FIRSTNAME"].ToString() + " " + rsstaff["LASTNAME"].ToString();
                }

                DB2ResultSet rsacctype = DB.QueryWithResultSet("SELECT POSITION_TITLE FROM POSITION WHERE POSITION_ID = (SELECT ACCOUNT_TYPE FROM ACCOUNT WHERE STAFF_NUMBER = " + Convert.ToInt32(txtstaffnum.Text) + ")");
                while (rsacctype.Read())
                {
                    cbaccttype.SelectedItem = rsacctype["POSITION_TITLE"].ToString();
                }

            }
            else
            {
                lblstaffname.Text = "STAFF FULL NAME...";
                cbaccttype.SelectedIndex = -1;
            }
        }

        private void dgusers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;
            int posid = 0;

            txtuserid.Text = dgusers.Rows[rownum].Cells[0].Value.ToString();
            txtstaffnum.Text = dgusers.Rows[rownum].Cells[1].Value.ToString();
            txtusername.Text = dgusers.Rows[rownum].Cells[2].Value.ToString();
            txtpassword.Text = dgusers.Rows[rownum].Cells[3].Value.ToString();
            posid = Convert.ToInt32(dgusers.Rows[rownum].Cells[4].Value);

            DB2ResultSet rsacctype = DB.QueryWithResultSet("SELECT POSITION_TITLE FROM POSITION WHERE POSITION_ID = " + posid);
            while (rsacctype.Read())
            {
                cbaccttype.SelectedItem = rsacctype["POSITION_TITLE"].ToString();
            }
        }
        

        private void btnupdateacct_Click(object sender, EventArgs e)
        {
            if (!txtpassword.Text.Equals(""))
            {
                DB.Query("UPDATE ACCOUNT SET ACCOUNT_TYPE = (SELECT POSITION_ID FROM POSITION WHERE POSITION_TITLE = '" + cbaccttype.SelectedItem.ToString() + "'), PASSCODE = '" + txtpassword.Text + "' WHERE ACCOUNT_NO = " + Convert.ToInt32(txtuserid.Text));
                MessageBox.Show("Password has been successfully changed!");
                dgusers.Rows.Clear();
                loadAccounts();
            }

            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void btnremoveacct_Click(object sender, EventArgs e)
        {
            int selrow = dgusers.CurrentRow.Index;

            DialogResult removeAcct = MessageBox.Show("Are you sure you want to remove this account?", "Confirm Removing of Account", MessageBoxButtons.YesNo);

            if(removeAcct == DialogResult.Yes)
            {
                DB.Query("DELETE FROM ACCOUNT WHERE ACCOUNT_NO =" + Convert.ToInt32(dgusers.Rows[selrow].Cells[0].Value));
                MessageBox.Show("Account was successfully deleted!");
                dgusers.Rows.Clear();
                loadAccounts();
            }
        }

        private void btncreateacct_Click(object sender, EventArgs e)
        {
            int posid = 0;

            if(!txtstaffnum.Text.Equals("") && !txtusername.Text.Equals("") && !txtpassword.Text.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM ACCOUNT WHERE STAFF_NUMBER = " + Convert.ToInt32(txtstaffnum.Text));
                if (check.Read())
                {
                    MessageBox.Show("That Staff Number already has an account. You can update its record or save a new account.");
                }
                else
                {
                    DB2ResultSet rsacctID = DB.QueryWithResultSet("SELECT POSITION_ID FROM POSITION WHERE POSITION_TITLE = '" + cbaccttype.SelectedItem.ToString() + "'");
                    while (rsacctID.Read())
                    {
                        posid = Convert.ToInt32(rsacctID["POSITION_ID"]);
                    }

                    DB.Query("INSERT INTO ACCOUNT (STAFF_NUMBER, USERNAME, PASSCODE, ACCOUNT_TYPE) VALUES("
                                + Convert.ToInt32(txtstaffnum.Text) + ",'"
                                + txtusername.Text + "','"
                                + txtpassword.Text + "',"
                                + posid
                                + ")");

                    MessageBox.Show("Account successfully created.");
                    dgusers.Rows.Clear();
                    loadAccounts();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void UserMgt_FormClosing(object sender, FormClosingEventArgs e)
        {
            MedDirMainMenu frmMD = new MedDirMainMenu();
            frmMD.Show();
            this.Dispose();
        }
    }
}
