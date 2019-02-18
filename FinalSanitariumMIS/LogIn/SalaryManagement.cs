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
    public partial class SalaryManagement : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public SalaryManagement()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        private void loadSalaries()
        {
            string[] salist = new string[6];
            DB2ResultSet salaries = DB.QueryWithResultSet("SELECT * FROM SALARY");
            while (salaries.Read())
            {
                salist[0] = salaries["SALARY_ID"].ToString();
                salist[1] = salaries["SALARY"].ToString();
                salist[2] = salaries["DESCRIPTION"].ToString();

                dgsalary.Rows.Add(salist);
            }
        }

        private void SalaryManagement_Load(object sender, EventArgs e)
        {
            loadSalaries();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!txtSalaryID.Text.Equals("") && !txtAmount.Text.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM SALARY WHERE SALARY_ID = " + Convert.ToInt32(txtSalaryID.Text));
                if (check.Read())
                {
                    DialogResult res = MessageBox.Show("That Salary ID already exists! Let us give you a NEW Salary ID.", "Existing Salary ID", MessageBoxButtons.OKCancel);

                    if (res == DialogResult.OK)
                    {
                        DB2ResultSet max_salID = DB.QueryWithResultSet("SELECT MAX(SALARY_ID) as MAXID FROM SALARY");

                        while (max_salID.Read())
                        {
                            try
                            {
                                txtSalaryID.Text = (Convert.ToInt32(max_salID["MAXID"]) + 1).ToString();
                            }
                            catch (Exception er)
                            {
                                txtSalaryID.Text = "1";
                            }
                        }
                    }
                    
                }
                else
                {
                    DB.Query("INSERT INTO SALARY VALUES("
                    + Convert.ToInt32(txtSalaryID.Text) + ","
                    + Convert.ToDouble(txtAmount.Text) + ",'"
                    + txtDescription.Text + "'" +
                    ")");

                    dgsalary.Rows.Clear();
                    loadSalaries();

                    MessageBox.Show("New Salary Grade has been saved!");
                }
            }
            else
            {
                MessageBox.Show("Please enter the Salary ID and Salary Amount.");
            }
        }

        private void dgsalary_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            txtSalaryID.Text = dgsalary.Rows[rownum].Cells[0].Value.ToString();
            txtAmount.Text = dgsalary.Rows[rownum].Cells[1].Value.ToString();
            txtDescription.Text = dgsalary.Rows[rownum].Cells[2].Value.ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(!txtSalaryID.Text.Equals("") && !txtAmount.Text.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM SALARY WHERE SALARY_ID = " + Convert.ToInt32(txtSalaryID.Text));
                if (check.Read())
                {
                    DB.Query("UPDATE SALARY SET " +
                    " SALARY = " + Convert.ToDouble(txtAmount.Text) +
                    ", DESCRIPTION = '" + txtDescription.Text +
                    "' WHERE SALARY_ID = " + Convert.ToInt32(txtSalaryID.Text));

                    txtSalaryID.Clear();
                    txtAmount.Clear();
                    txtDescription.Clear();
                    MessageBox.Show("Record successfully updated!");
                    dgsalary.Rows.Clear();
                    loadSalaries();
                }
                else
                {
                    MessageBox.Show("That Salary ID does not exist. Please select from the Salary List on the right.");
                }
            }
            else
            {
                MessageBox.Show("Please select (DOUBLE-CLICK) an existing record from the Salary List on the right.");
            }
        }

        private void SalaryManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            HRMainMenu frmHR = new HRMainMenu();
            frmHR.Show();
            this.Dispose();
        }
    }
}
