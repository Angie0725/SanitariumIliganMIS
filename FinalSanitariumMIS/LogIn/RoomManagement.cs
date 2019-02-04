using System;
using System.Collections;
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
    public partial class RoomManagement : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public RoomManagement()
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

        private void loadBedList()
        {
            dgvbeds.Rows.Clear();

            string wardnum = "";

            string[] bedlist = new string[4];
            DB2ResultSet rsbeds = DB.QueryWithResultSet("SELECT * FROM BED");
            while (rsbeds.Read())
            {
                bedlist[0] = rsbeds["BED_ID"].ToString();
                bedlist[1] = rsbeds["AVAILABILITY"].ToString();
                bedlist[3] = rsbeds["DESCRIPTION"].ToString();

                wardnum = rsbeds["WARD_NUMBER"].ToString();

                DB2ResultSet rsward = DB.QueryWithResultSet("SELECT * FROM WARD WHERE WARD_NUMBER = '" + wardnum + "'");
                while (rsward.Read())
                {
                    bedlist[2] = rsward["NAME"].ToString();
                }

                dgvbeds.Rows.Add(bedlist);
            }

            
            
            
        }

        private void loadWardList()
        {
            dgvwards.Rows.Clear();

            string[] wardlist = new string[3];
            DB2ResultSet rswards = DB.QueryWithResultSet("SELECT * FROM WARD");
            while (rswards.Read())
            {
                wardlist[0] = rswards["WARD_NUMBER"].ToString();
                wardlist[1] = rswards["NAME"].ToString();
                wardlist[2] = rswards["DESCRIPTION"].ToString();

                dgvwards.Rows.Add(wardlist);
            }

            
            
        }

        private void newWard()
        {
            // credibility of resulting ward number: unsure

            Stack wardnum = new Stack();

            DB2ResultSet rswnum = DB.QueryWithResultSet("SELECT WARD_NUMBER FROM WARD");
            while (rswnum.Read())
            {
                if(rswnum["WARD_NUMBER"].ToString().Length == 2)
                {
                    wardnum.Push(rswnum["WARD_NUMBER"].ToString().Substring(1, 1));
                }
                else
                {
                    wardnum.Push(rswnum["WARD_NUMBER"].ToString().Substring(1, 2));
                }
            }

            txtwardnum.Text = "W" + (Convert.ToInt32(wardnum.Peek()) + 1).ToString();
        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            newBed();
            newWard();

            loadBedList();
            loadWardList();

            cbavailability.Items.Add("AVAILABLE");
            cbavailability.Items.Add("OCCUPIED");

            DB2ResultSet rswname = DB.QueryWithResultSet("SELECT NAME FROM WARD");
            while (rswname.Read())
            {
                cblocward.Items.Add(rswname["NAME"].ToString());
            }


            

        }

        private void newBed()
        {
            DB2ResultSet max_bedID = DB.QueryWithResultSet("SELECT MAX(BED_ID) as MAXID FROM BED");

            while (max_bedID.Read())
            {
                try
                {
                    txtbednum.Text = (Convert.ToInt32(max_bedID["MAXID"]) + 1).ToString();
                }
                catch (Exception er)
                {
                    txtbednum.Text = "1";
                }
            }
        }

        private void btnaddbed_Click(object sender, EventArgs e)
        {
            if (!txtbednum.Equals(""))
            {
                DB2ResultSet rsbednum = DB.QueryWithResultSet("SELECT * FROM BED WHERE BED_ID = " + Convert.ToInt32(txtbednum.Text));
                if (!rsbednum.HasRows)
                {
                    if (!cbavailability.Text.Equals("") && !cblocward.Text.Equals(""))
                    {
                        string wardID = "";
                        DB2ResultSet rswardID = DB.QueryWithResultSet("SELECT WARD_NUMBER FROM WARD WHERE NAME = '" + cblocward.SelectedItem.ToString() + "'");
                        while (rswardID.Read())
                        {
                            wardID = rswardID["WARD_NUMBER"].ToString();
                        }

                        DB.Query("INSERT INTO BED VALUES(" + Convert.ToInt32(txtbednum.Text) + ", '" + wardID + "', '" + cbavailability.SelectedItem.ToString() + "', '" + txtbeddesc.Text + "')");
                        loadBedList();
                        MessageBox.Show("A New Bed has been successfully added!");
                    }
                }
                else
                {
                    MessageBox.Show("The bed number is invalid. Let us give you a new bed number.");
                    newBed();
                }
            }
            
        }

        private void btnudpatebed_Click(object sender, EventArgs e)
        {
            if (!txtbednum.Equals(""))
            {
                DB2ResultSet rsbednum = DB.QueryWithResultSet("SELECT * FROM BED WHERE BED_ID = " + Convert.ToInt32(txtbednum.Text));
                if (rsbednum.HasRows)
                {
                    if (!cbavailability.Text.Equals("") && !cblocward.Text.Equals(""))
                    {
                        string wardID = "";
                        DB2ResultSet rswardID = DB.QueryWithResultSet("SELECT WARD_NUMBER FROM WARD WHERE NAME = '" + cblocward.SelectedItem.ToString() + "'");
                        while (rswardID.Read())
                        {
                            wardID = rswardID["WARD_NUMBER"].ToString();
                        }

                        DB.Query("UPDATE BED SET WARD_NUMBER = '" + wardID + "', AVAILABILITY = '" + cbavailability.SelectedItem.ToString() + "', DESCRIPTION = '" + txtbeddesc.Text + "' WHERE BED_ID = " + Convert.ToInt32(txtbednum.Text));
                        loadBedList();
                        MessageBox.Show("The bed has been successfully updated!");
                    }
                }
                else
                {
                    MessageBox.Show("The bed number does not exist. Please select from the list to update.");
                }
            }
        }

        private void dgvbeds_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex;

            txtbednum.Text = dgvbeds.Rows[rowid].Cells[0].Value.ToString();
            cblocward.SelectedItem = dgvbeds.Rows[rowid].Cells[2].Value.ToString();
            cbavailability.SelectedItem = dgvbeds.Rows[rowid].Cells[1].Value.ToString();
            txtbeddesc.Text = dgvbeds.Rows[rowid].Cells[3].Value.ToString();

        }

        private void btnaddward_Click(object sender, EventArgs e)
        {
            if (!txtwardnum.Equals(""))
            {
                DB2ResultSet rsward = DB.QueryWithResultSet("SELECT * FROM WARD WHERE WARD_NUMBER = '" + txtwardnum.Text + "'");
                if (!rsward.HasRows)
                {
                    if (!txtwardname.Text.Equals(""))
                    {

                        DB.Query("INSERT INTO WARD VALUES('" + txtwardnum.Text + "', '" + txtwardname.Text + "', '" + txtwarddesc.Text + "')");
                        loadWardList();
                        MessageBox.Show("A New Ward has been successfully added!");
                    }
                }
                else
                {
                    MessageBox.Show("The ward number is invalid. Let us give you a new ward number.");
                    newWard();
                }
            }
        }

        private void dgvwards_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowid = e.RowIndex;

            txtwardnum.Text = dgvwards.Rows[rowid].Cells[0].Value.ToString();
            txtwardname.Text = dgvwards.Rows[rowid].Cells[1].Value.ToString();
            txtwarddesc.Text = dgvwards.Rows[rowid].Cells[2].Value.ToString();

        }

        private void btnupdateward_Click(object sender, EventArgs e)
        {
            if (!txtwardnum.Equals(""))
            {
                DB2ResultSet rswardnum = DB.QueryWithResultSet("SELECT * FROM WARD WHERE WARD_NUMBER = '" + txtwardnum.Text + "'");
                if (rswardnum.HasRows)
                {
                    if (!txtwardname.Text.Equals(""))
                    {
                        DB.Query("UPDATE WARD SET NAME = '" + txtwardname.Text + "', DESCRIPTION = '" + txtwarddesc.Text + "' WHERE WARD_NUMBER = '" + txtwardnum.Text + "'");
                        loadWardList();
                        MessageBox.Show("The ward has been successfully updated!");
                    }
                }
                else
                {
                    MessageBox.Show("The ward number does not exist. Please select from the list to update.");
                }
            }
        }
    }
}
