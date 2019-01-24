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
    public partial class Suppliers : Form
    {
        // Written By : Bill-Lawrence Samar
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public Suppliers()
        {
            InitializeComponent();
        

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        private void linkback_Click(object sender, EventArgs e)
        {
            InventoryManagement frm= new InventoryManagement();
            frm.Show();
            this.Dispose();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (!tb_supplier_number.Text.Equals("") && !tb_supplier_name.Text.Equals("") && !tb_address.Text.Equals("") && !tb_tel_no.Text.Equals("") && !tb_fax_no.Text.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM SUPPLIER WHERE SUPPLIER_NUMBER = " + Convert.ToInt32(tb_supplier_number.Text));
                if (check.Read())
                {
                    DB.Query("UPDATE SUPPLIER SET " +
                    " SUPPLIER_NAME = '" + tb_supplier_name.Text +
                    "', ADDRESS = '" + tb_address.Text +
                    "', TELNUMBER = " + tb_tel_no.Text +
                    ", FAXNUMBER = " + tb_fax_no.Text +
                    " WHERE SUPPLIER_NUMBER = " + Convert.ToInt32(tb_supplier_number.Text));

                    tb_supplier_number.Clear();
                    tb_supplier_name.Clear();
                    tb_address.Clear();
                    tb_tel_no.Clear();
                    tb_fax_no.Clear();
                    MessageBox.Show("Record successfully updated!");
                    dgv_masterlist.Rows.Clear();
                    RefreshMasterList();
                }
                else
                {
                    MessageBox.Show("That Supplier Number does not exist. Please select from the Suppliers List on the right.");
                }
            }
            else
            {
                MessageBox.Show("Please make sure all fields are correctly filled out.");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!tb_supplier_number.Text.Equals("") && !tb_supplier_name.Text.Equals("") && !tb_address.Text.Equals("") && !tb_tel_no.Text.Equals("") && !tb_fax_no.Text.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM SUPPLIER WHERE SUPPLIER_NUMBER = " + Convert.ToInt32(tb_supplier_number.Text));
                if (check.Read())
                {
                    DialogResult res = MessageBox.Show("That Supplier Number already exists! Let us give you a NEW Supplier Number.", "Existing Supplier Number", MessageBoxButtons.OKCancel);

                    if (res == DialogResult.OK)
                    {
                        DB2ResultSet max_salID = DB.QueryWithResultSet("SELECT MAX(Supplier_Number) as MAXID FROM SUPPLIER");

                        while (max_salID.Read())
                        {
                            try
                            {
                                tb_supplier_number.Text = (Convert.ToInt32(max_salID["MAXID"]) + 1).ToString();
                            }
                            catch (Exception er)
                            {
                                tb_supplier_number.Text = "1";
                            }
                        }
                    }

                }
                else
                {
                    DB.Query("INSERT INTO SUPPLIER VALUES("
                    + Convert.ToInt32(tb_supplier_number.Text) + ",'"
                    + tb_supplier_name.Text + "','"
                    + tb_address.Text + "',"
                    + tb_tel_no.Text + ","
                    + tb_fax_no.Text
                    + ")");

                    dgv_masterlist.Rows.Clear();
                    RefreshMasterList();

                    MessageBox.Show("New Supplier has been saved!");
                }
            }
            else
            {
                MessageBox.Show("Please make sure all fields are correctly filled out.");
            }

            dgv_masterlist.Rows.Clear();
            RefreshMasterList();
        }

        private void RefreshMasterList()
        {

            string[] salist = new string[5];
            DB2ResultSet suppliers = DB.QueryWithResultSet("SELECT * FROM SUPPLIER");
            while (suppliers.Read())
            {
                salist[0] = suppliers["SUPPLIER_NUMBER"].ToString();
                salist[1] = suppliers["SUPPLIER_NAME"].ToString();
                salist[2] = suppliers["ADDRESS"].ToString();
                salist[3] = suppliers["TELNUMBER"].ToString();
                salist[4] = suppliers["FAXNUMBER"].ToString();

                dgv_masterlist.Rows.Add(salist);
            }
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            RefreshMasterList();
        }

        private void masterlist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            tb_supplier_number.Text = dgv_masterlist.Rows[rownum].Cells[0].Value.ToString();
            tb_supplier_name.Text = dgv_masterlist.Rows[rownum].Cells[1].Value.ToString();
            tb_address.Text = dgv_masterlist.Rows[rownum].Cells[2].Value.ToString();
            tb_tel_no.Text = dgv_masterlist.Rows[rownum].Cells[3].Value.ToString();
            tb_fax_no.Text = dgv_masterlist.Rows[rownum].Cells[4].Value.ToString();
        }

        //private void Suppliers_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    InventoryManagement frm = new InventoryManagement();
        //    frm.Show();
        //    this.Dispose();
        //}
    }
}
