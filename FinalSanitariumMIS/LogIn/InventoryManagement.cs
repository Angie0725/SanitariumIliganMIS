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
    public partial class InventoryManagement : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public InventoryManagement()
        {
            InitializeComponent();
            RefreshMasterList();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Suppliers frm = new Suppliers();
            frm.Show();
            this.Dispose();
        }

        private void linkback_Click(object sender, EventArgs e)
        {
            MedDirMainMenu frmMD = new MedDirMainMenu();
            frmMD.Show();
            this.Hide();
        }

        private void btn_show_add_stock_panel_Click(object sender, EventArgs e)
        {
            if(dgv_inventory.CurrentRow == null)
            {
                MessageBox.Show("To add a stock, please select an item on the inventory list");
                return;
            }

            label_product_name.Text = dgv_inventory.CurrentRow.Cells[1].Value.ToString();
            panel_add_stock.Visible = true;
        }

        private void btn_add_stock_Click(object sender, EventArgs e)
        {
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB.Query("UPDATE SUPPLY SET QUANTITY = QUANTITY + " + tb_stock_quantity.Text + " WHERE ITEM_NUMBER = " + dgv_inventory.CurrentRow.Cells[0].Value.ToString());
            RefreshMasterList();

            tb_stock_quantity.Text = "";
            panel_add_stock.Visible = false;
        }

        private void btn_cancel_add_stock_Click(object sender, EventArgs e)
        {
            tb_stock_quantity.Text = "";
            panel_add_stock.Visible = false;
        }

        private void RefreshMasterList()
        {
            String modifier = "";

            if (cb_filter.SelectedIndex == 0 || cb_filter.SelectedIndex == -1)
            {
                modifier = "WHERE " +
                    " ITEM_NUMBER LIKE '" + tb_search.Text + "%' OR " +
                    " SUPPLIER_NUMBER LIKE '" + tb_search.Text + "%' OR " +
                    " ITEM_NAME LIKE '" + tb_search.Text + "%' OR " +
                    " DESCRIPTION LIKE '" + tb_search.Text + "%' OR " +
                    " QUANTITY LIKE '" + tb_search.Text + "%' OR " +
                    " REORDER_LEVEL LIKE '" + tb_search.Text + "%' OR " +
                    " UNIT LIKE '" + tb_search.Text + "%' OR " +
                    " COST_PER_UNIT LIKE '" + tb_search.Text + "%' OR " +
                    " ITEM_TYPE LIKE '" + tb_search.Text + "%' OR " +
                    " DOSAGE LIKE '" + tb_search.Text + "%' OR " +
                    " METHOD_OF_ADMINISTRATION  LIKE '%" + tb_search.Text + "'";
            }
            else 
            {
                modifier = "WHERE " + cb_filter.SelectedItem.ToString() + " LIKE '" + tb_search.Text + "%'"; 
            }

            //DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM SUPPLY " + modifier);

            dgv_inventory.Rows.Clear();

            while (rs.Read())
            {
                Object[] d = new Object[11];

                d[0] = rs.GetString(0);
                d[1] = rs.GetString(2);
                d[2] = rs.GetString(3);
                d[3] = rs.GetString(4);
                d[4] = rs.GetString(5);
                d[5] = rs.GetString(6);
                d[6] = rs.GetString(7);
                d[7] = rs.GetString(1);
                d[8] = (rs.GetInt32(8) == 0)? "Supply" : "Drug";
                d[9] = rs.GetString(9);
                d[10] = rs.GetString(10);

                dgv_inventory.Rows.Add(d);
            }
        }

        private void btn_update_supply_Click(object sender, EventArgs e)
        {
            if(dgv_inventory.CurrentRow == null)
            {
                MessageBox.Show("Please select an item on the master list");
                return;
            }

            tb_supply_no.Text = dgv_inventory.CurrentRow.Cells[0].Value.ToString();
            tb_supply_name.Text = dgv_inventory.CurrentRow.Cells[1].Value.ToString();
            tb_description.Text = dgv_inventory.CurrentRow.Cells[2].Value.ToString();
            tb_reorder_level.Text = dgv_inventory.CurrentRow.Cells[4].Value.ToString();
            tb_unit.Text = dgv_inventory.CurrentRow.Cells[5].Value.ToString();
            tb_cost_per_unit.Text = dgv_inventory.CurrentRow.Cells[6].Value.ToString();
            tb_supplier.Text = dgv_inventory.CurrentRow.Cells[7].Value.ToString();
            cb_type_of_supply.Text = dgv_inventory.CurrentRow.Cells[8].Value.ToString();
            tb_dosage.Text = dgv_inventory.CurrentRow.Cells[9].Value.ToString();
            cb_method_administration.Text = dgv_inventory.CurrentRow.Cells[10].Value.ToString();
        }

        private void btn_save_supply_Click(object sender, EventArgs e)
        {
            int isDrug = (tb_dosage.Text == "") ? 0 : 1;

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT ITEM_NUMBER FROM SUPPLY WHERE ITEM_NUMBER = " + tb_supply_no.Text);

            if (!rs.Read())
            {
                DB.Query("INSERT INTO SUPPLY VALUES (" +
                    tb_supply_no.Text + "," + tb_supplier.Text + ",'" + tb_supply_name.Text + "','" + tb_description.Text + "',0," +
                    tb_reorder_level.Text + ",'" + tb_unit.Text + "'," + tb_cost_per_unit.Text + "," + isDrug + ",'" + tb_dosage.Text + "','" +
                    cb_method_administration.Text + "')");
            }
            else
            {
                DB.Query("UPDATE SUPPLY SET " +
                    "SUPPLIER_NUMBER = " + tb_supplier.Text + ", ITEM_NAME = '" + tb_supply_name.Text + "', DESCRIPTION = '" + tb_description.Text +
                    "', REORDER_LEVEL = " + tb_reorder_level.Text + ", UNIT = '" + tb_unit.Text + "', COST_PER_UNIT = " + tb_cost_per_unit.Text +
                    ", ITEM_TYPE = " + isDrug + ", DOSAGE = '" + tb_dosage.Text + "', METHOD_OF_ADMINISTRATION = '" + cb_method_administration.Text +
                    "' WHERE ITEM_NUMBER = " + dgv_inventory.CurrentRow.Cells[0].Value.ToString());
            }

            RefreshMasterList();
            ClearAllFields();
        }

        private void cb_type_of_supply_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_type_of_supply.SelectedIndex == 0)
            {
                tb_dosage.Enabled = false;
                cb_method_administration.Enabled = false;
            }
            else
            {
                tb_dosage.Enabled = true;
                cb_method_administration.Enabled = true;
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            RefreshMasterList();
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMasterList();
        }

        private void ClearAllFields()
        {
            tb_supply_no.Text = "";
            tb_supply_name.Text = "";
            tb_description.Text = "";
            tb_reorder_level.Text = "";
            tb_unit.Text = "";
            tb_cost_per_unit.Text = "";
            tb_supplier.Text = "";
            cb_type_of_supply.Text = "";
            tb_dosage.Text = "";
            cb_method_administration.Text = "";
        }

        private void InventoryManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            MedDirMainMenu frmMD = new MedDirMainMenu();
            frmMD.Show();
            this.Hide();
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
