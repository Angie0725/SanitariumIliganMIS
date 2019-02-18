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
    public partial class PositionMaintenance : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public PositionMaintenance()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }
        
        private void loadPositions()
        {
            string[] pos = new string[3];
            DB2ResultSet rssalary = DB.QueryWithResultSet("SELECT * FROM POSITION");

            while (rssalary.Read())
            {
                pos[0] = rssalary["POSITION_ID"].ToString();
                pos[1] = rssalary["POSITION_TITLE"].ToString();
                pos[2] = rssalary["DESCRIPTION"].ToString();

                dgposition.Rows.Add(pos);
            }
        }

        private void PositionMaintenance_Load(object sender, EventArgs e)
        {
            dgposition.Rows.Clear();
            loadPositions();
        }

        private void dgposition_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            txtpositionID.Text = dgposition.Rows[rownum].Cells[0].Value.ToString();
            txttitle.Text = dgposition.Rows[rownum].Cells[1].Value.ToString();
            txtdescription.Text = dgposition.Rows[rownum].Cells[2].Value.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!txtpositionID.Text.Equals("") && !txttitle.Text.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM POSITION WHERE POSITION_ID = " + Convert.ToInt32(txtpositionID.Text));
                if (check.Read())
                {
                    DialogResult res = MessageBox.Show("That Position ID already exists! Let us give you a NEW Position ID.", "Existing Position ID", MessageBoxButtons.OKCancel);

                    if (res == DialogResult.OK)
                    {
                        DB2ResultSet max_salID = DB.QueryWithResultSet("SELECT MAX(POSITION_ID) as MAXID FROM POSITION");

                        while (max_salID.Read())
                        {
                            try
                            {
                                txtpositionID.Text = (Convert.ToInt32(max_salID["MAXID"]) + 1).ToString();
                            }
                            catch (Exception er)
                            {
                                txtpositionID.Text = "1";
                            }
                        }
                    }

                }
                else
                {
                    DB.Query("INSERT INTO POSITION VALUES("
                    + Convert.ToInt32(txtpositionID.Text) + ",'"
                    + txttitle.Text + "','"
                    + txtdescription.Text + "'" +
                    ")");

                    dgposition.Rows.Clear();
                    loadPositions();

                    MessageBox.Show("New Position has been saved!");
                }
            }
            else
            {
                MessageBox.Show("Please enter the Position ID and Position Title.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (!txtpositionID.Text.Equals("") && !txttitle.Text.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM POSITION WHERE POSITION_ID = " + Convert.ToInt32(txtpositionID.Text));
                if (check.Read())
                {
                    DB.Query("UPDATE POSITION SET " +
                    " POSITION_TITLE = '" + txttitle.Text +
                    "', DESCRIPTION = '" + txtdescription.Text +
                    "' WHERE POSITION_ID = " + Convert.ToInt32(txtpositionID.Text));

                    txtpositionID.Clear();
                    txttitle.Clear();
                    txtdescription.Clear();
                    MessageBox.Show("Record successfully updated!");
                    dgposition.Rows.Clear();
                    loadPositions();
                }
                else
                {
                    MessageBox.Show("That Position ID does not exist. Please select from the Position List on the right.");
                }
            }
            else
            {
                MessageBox.Show("Please select (DOUBLE-CLICK) an existing record from the Position List on the right.");
            }
        }

        private void PositionMaintenance_FormClosing(object sender, FormClosingEventArgs e)
        {
            HRMainMenu frmHR = new HRMainMenu();
            frmHR.Show();
            this.Dispose();
        }
    }
}
