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
using FinalSanitariumMIS.Helpers;

namespace LogIn
{
    public partial class Doctors : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public Doctors()
        {
            InitializeComponent();
        }


        private void btn_reigster_Click(object sender, EventArgs e)
        {
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM VW_STAFF WHERE supplier_number = '" + tb_tel_no.Text + "'");

            if (rs.Read())
            {
                //DB.Query("UPDATE STAFF SET " +
                //    "SUPPLIER_NUMBER = " + tb_supplier_number.Text + "," +
                //    "SUPPLIER_NAME = '" + tb_supplier_name.Text + "'," +
                //    "ADDRESS = '" + tb_address.Text + "'," +
                //    "TELNUMBER = " + tb_tel_no.Text + "," +
                //    "FAXNUMBER = " + tb_fax_no.Text + " WHERE SUPPLIER_NUMBER = " +
                //    dgv_masterlist.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                //DB.Query("INSERT INTO SUPPLIER VALUES (" +
                //    tb_supplier_number.Text + ",'" + tb_supplier_name.Text + "','" +
                //    tb_address.Text + "'," + tb_tel_no.Text + "," + tb_fax_no.Text + ")");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_masterlist.CurrentRow.Index == -1)
            {
                MessageBox.Show("Please select an entry from the Master List of Doctors");
                return;
            }

            tb_doctor_id.Text = dgv_masterlist.CurrentRow.Cells[0].Value.ToString();
            tb_firstname.Text = dgv_masterlist.CurrentRow.Cells[1].Value.ToString();
            tb_lastname.Text = dgv_masterlist.CurrentRow.Cells[2].Value.ToString();
            cb_clinic_number.Text = dgv_masterlist.CurrentRow.Cells[3].Value.ToString();
            tb_address.Text = dgv_masterlist.CurrentRow.Cells[4].Value.ToString();
            tb_tel_no.Text = dgv_masterlist.CurrentRow.Cells[5].Value.ToString();
        }

        private void RefreshMasterList()
        {
            // not yet tested , requires view from db
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM VW_STAFF WHERE POSITION = 'doctor'");

            dgv_masterlist.Rows.Clear();

            while (rs.Read())
            {
                Object[] d = new Object[5];

                d[0] = rs.GetString(0);
                d[1] = rs.GetString(1);
                d[2] = rs.GetString(2);
                d[3] = rs.GetString(3);
                d[4] = rs.GetString(4);

                dgv_masterlist.Rows.Add(d);
            }
        }
    }
}
