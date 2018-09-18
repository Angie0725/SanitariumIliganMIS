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
            RefreshMasterList();
        }

        private void linkback_Click(object sender, EventArgs e)
        {
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgv_masterlist.CurrentRow.Index == -1)
            {
                MessageBox.Show("Please select a supplier from the Master List of Suppliers");
                return;
            }

            tb_supplier_number.Text = dgv_masterlist.CurrentRow.Cells[0].Value.ToString();
            tb_supplier_name.Text = dgv_masterlist.CurrentRow.Cells[1].Value.ToString();
            tb_address.Text = dgv_masterlist.CurrentRow.Cells[2].Value.ToString();
            tb_tel_no.Text = dgv_masterlist.CurrentRow.Cells[3].Value.ToString();
            tb_fax_no.Text = dgv_masterlist.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM SUPPLIER WHERE supplier_number = '" + tb_supplier_number.Text + "'");

            if (rs.Read())
            {
                DB.Query("UPDATE SET ---- WHERE ----");
            }
            else
            {
                DB.Query("INSERT INTO SET ---- WHERE ----");
            }
        }

        private void RefreshMasterList()
        {
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM SUPPLIER");

            dgv_masterlist.Rows.Clear();

            while(rs.Read())
            {
                Object[] d = new Object[5];

                d[0] = tb_supplier_number.Text;
                d[1] = tb_supplier_name.Text;
                d[2] = tb_address.Text;
                d[3] = tb_tel_no.Text;
                d[4] = tb_fax_no.Text;

                dgv_masterlist.Rows.Add(d);
            }
        }
    }
}
