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
        private int totalQuantity = 0;
        private DB2ResultSet theSupplies;

        public InventoryManagement()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Nicksplat93", "Angelie_Buen", "sanita");
        }

        private void loadSupplyList()
        {
            string[] supplylist = new string[11];
            DB2ResultSet supplies = DB.QueryWithResultSet("SELECT * FROM SUPPLY");
            while (supplies.Read())
            {
                supplylist[0] = supplies["ITEM_NUMBER"].ToString();
                supplylist[1] = supplies["ITEM_NAME"].ToString();
                supplylist[2] = supplies["DESCRIPTION"].ToString();
                supplylist[3] = supplies["QUANTITY"].ToString();
                supplylist[4] = supplies["REORDER_LEVEL"].ToString();
                supplylist[5] = supplies["UNIT"].ToString();
                supplylist[6] = supplies["COST_PER_UNIT"].ToString();
                supplylist[7] = supplies["SUPPLIER_NUMBER"].ToString();
                supplylist[8] = supplies["ITEM_TYPE"].ToString();
                supplylist[9] = supplies["DOSAGE"].ToString();
                supplylist[10] = supplies["METHOD_OF_ADMINISTRATION"].ToString();

                dgv_inventory.Rows.Add(supplylist);
            }
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            //tb_dosage.Enabled = false;
            //cb_method_administration.Enabled = false;

            dgv_inventory.Rows.Clear();
            loadSupplyList();

            cb_type_of_supply.Items.Clear();
            cb_type_of_supply.Items.Add("Drugs");
            cb_type_of_supply.Items.Add("Surgical");
            cb_type_of_supply.Items.Add("Non-Surgical");

            cb_method_administration.Items.Clear();
            cb_method_administration.Items.Add("Oral");
            cb_method_administration.Items.Add("Intravenous");
            cb_method_administration.Items.Add("Intramuscular");

            cb_filter.Items.Clear();
            cb_filter.Items.Add("ALL");
            cb_filter.Items.Add("Drugs");
            cb_filter.Items.Add("Surgical");
            cb_filter.Items.Add("Non-Surgical");
        }

        private void btn_add_stock_Click(object sender, EventArgs e)
        {
            int oldQuantity = 0;
            DB2ResultSet quanti = DB.QueryWithResultSet("SELECT Quantity FROM SUPPLY WHERE ITEM_NUMBER = " + Convert.ToInt32(lblitemnum.Text));
            while (quanti.Read())
            {
                oldQuantity = Convert.ToInt32(quanti["Quantity"].ToString());
            }

            totalQuantity = oldQuantity + Convert.ToInt32(tb_stock_quantity.Text);

            DB.Query("UPDATE SUPPLY SET QUANTITY = " + Convert.ToInt32(totalQuantity) + " WHERE ITEM_NUMBER = " + Convert.ToInt32(lblitemnum.Text));

            dgv_inventory.Rows.Clear();
            loadSupplyList();

            tb_stock_quantity.Text = "";
            lblitemname.Text = "Item Name...";
            lblitemnum.Text = "Item Number...";
            panel_add_stock.Visible = false;
            MessageBox.Show("Stock quantity has been successfully updated!");

        }

        private void btn_cancel_add_stock_Click(object sender, EventArgs e)
        {
            tb_stock_quantity.Text = "";
            lblitemname.Text = "Item Name...";
            lblitemnum.Text = "Item Number...";
            panel_add_stock.Visible = false;
        }

        

        private void btn_update_supply_Click(object sender, EventArgs e)
        {
            if (!tb_supply_no.Text.Equals("") && !tb_supply_name.Text.Equals("")
                && !tb_reorder_level.Text.Equals("") && !tb_unit.Text.Equals("") && !tb_cost_per_unit.Text.Equals("")
                && !tb_supplier.Text.Equals("") && !cb_type_of_supply.SelectedItem.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM SUPPLY WHERE ITEM_NUMBER = " + Convert.ToInt32(tb_supply_no.Text));
                if (check.Read())
                {
                    if (cb_type_of_supply.SelectedItem.Equals("Drugs"))
                    {
                        //tb_dosage.Enabled = true;
                        //cb_method_administration.Enabled = true;

                        DB.Query("UPDATE SUPPLY SET " +
                        " ITEM_NAME = '" + tb_supply_name.Text +
                        "', DESCRIPTION = '" + tb_description.Text +
                        "', REORDER_LEVEL = " + Convert.ToInt32(tb_reorder_level.Text) +
                        ", UNIT = '" + tb_unit.Text +
                        "', COST_PER_UNIT = " + Convert.ToDouble(tb_cost_per_unit.Text) +
                        ", SUPPLIER_NUMBER = " + Convert.ToInt32(tb_supplier.Text) +
                        ", ITEM_TYPE = '" + cb_type_of_supply.SelectedItem.ToString() +
                        "', DOSAGE = '" + tb_dosage.Text +
                        "', METHOD_OF_ADMINISTRATION = '" + cb_method_administration.SelectedItem.ToString() +
                        "' WHERE ITEM_NUMBER = " + Convert.ToInt32(tb_supply_no.Text));
                    }
                    else
                    {
                        DB.Query("UPDATE SUPPLY SET " +
                        " ITEM_NAME = '" + tb_supply_name.Text +
                        "', DESCRIPTION = '" + tb_description.Text +
                        "', REORDER_LEVEL = " + Convert.ToInt32(tb_reorder_level.Text) +
                        ", UNIT = '" + tb_unit.Text +
                        "', COST_PER_UNIT = " + Convert.ToDouble(tb_cost_per_unit.Text) +
                        ", SUPPLIER_NUMBER = " + Convert.ToInt32(tb_supplier.Text) +
                        ", ITEM_TYPE = '" + cb_type_of_supply.SelectedItem.ToString() +
                        "' WHERE ITEM_NUMBER = " + Convert.ToInt32(tb_supply_no.Text));
                    }
                    

                    tb_supply_no.Clear();
                    tb_supply_name.Clear();
                    tb_description.Clear();
                    tb_reorder_level.Clear();
                    tb_unit.Clear();
                    tb_cost_per_unit.Clear();
                    tb_supplier.Clear();
                    cb_type_of_supply.SelectedIndex = -1;
                    tb_dosage.Clear();
                    cb_method_administration.SelectedIndex = -1;


                    MessageBox.Show("Record successfully updated!");
                    dgv_inventory.Rows.Clear();
                    loadSupplyList();

                    //tb_dosage.Enabled = false;
                    //cb_method_administration.Enabled = false;
                }
                else
                {
                    MessageBox.Show("That Item Number does not exist. Please select from the Inventory List on the right.");
                }
            }
            else
            {
                MessageBox.Show("Please select (DOUBLE-CLICK) an existing record from the Inventory List on the right.");
            }
        }

        private void btn_save_supply_Click(object sender, EventArgs e)
        {
            if (!tb_supply_no.Text.Equals("") && !tb_supply_name.Text.Equals("")
                && !tb_reorder_level.Text.Equals("") && !tb_unit.Text.Equals("") && !tb_cost_per_unit.Text.Equals("")
                && !tb_supplier.Text.Equals("") && !cb_type_of_supply.SelectedItem.Equals(""))
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM SUPPLY WHERE ITEM_NUMBER = " + Convert.ToInt32(tb_supply_no.Text));
                if (check.Read())
                {
                    DialogResult res = MessageBox.Show("That ITEM NUMBER already exists! Let us give you a NEW ITEM NUMBER.", "Existing ITEM NUMBER", MessageBoxButtons.OKCancel);

                    if (res == DialogResult.OK)
                    {
                        DB2ResultSet max_salID = DB.QueryWithResultSet("SELECT MAX(ITEM_NUMBER) as MAXID FROM SUPPLY");

                        while (max_salID.Read())
                        {
                            try
                            {
                                tb_supply_no.Text = (Convert.ToInt32(max_salID["MAXID"]) + 1).ToString();
                            }
                            catch (Exception er)
                            {
                                tb_supply_no.Text = "1";
                            }
                        }
                    }

                }
                else
                {
                    if (cb_type_of_supply.SelectedItem.Equals("Drugs"))
                    {
                        DB.Query("INSERT INTO SUPPLY VALUES("
                        + Convert.ToInt32(tb_supply_no.Text) + ",'"
                        + tb_supply_name.Text + "','"
                        + tb_description.Text + "',"
                        + 0 + ","
                        + Convert.ToInt32(tb_reorder_level.Text) + ",'"
                        + tb_unit.Text + "',"
                        + Convert.ToDouble(tb_cost_per_unit.Text) + ","
                        + Convert.ToInt32(tb_supplier.Text) + ",'"
                        + cb_type_of_supply.SelectedItem.ToString() + "','"
                        + tb_dosage.Text + "','"
                        + cb_method_administration.SelectedItem.ToString() + "'"
                        + ")");
                    }
                    else
                    {
                        DB.Query("INSERT INTO SUPPLY (ITEM_NUMBER, ITEM_NAME, DESCRIPTION, QUANTITY, REORDER_LEVEL, " +
                        "UNIT, COST_PER_UNIT, SUPPLIER_NUMBER, ITEM_TYPE)" +
                        "VALUES("
                        + Convert.ToInt32(tb_supply_no.Text) + ",'"
                        + tb_supply_name.Text + "','"
                        + tb_description.Text + "',"
                        + 0 + ","
                        + Convert.ToInt32(tb_reorder_level.Text) + ",'"
                        + tb_unit.Text + "',"
                        + Convert.ToDouble(tb_cost_per_unit.Text) + ","
                        + Convert.ToInt32(tb_supplier.Text) + ",'"
                        + cb_type_of_supply.SelectedItem.ToString() + "'"
                        + ")");
                    }
                    

                    dgv_inventory.Rows.Clear();
                    loadSupplyList();

                    MessageBox.Show("New Item has been saved!");
                    ClearAllFields();
                    //tb_dosage.Enabled = false;
                    //cb_method_administration.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please make sure all fields are correctly filled out.");
            }
        }

        //private void cb_type_of_supply_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cb_type_of_supply.SelectedItem.Equals("Drugs"))
        //    {
        //        tb_dosage.Enabled = true;
        //        cb_method_administration.Enabled = true;
        //    }
        //    else
        //    {
        //        tb_dosage.Enabled = false;
        //        cb_method_administration.Enabled = false;
        //    }
        //}

        private void ClearAllFields()
        {
            tb_supply_no.Text = "";
            tb_supply_name.Text = "";
            tb_description.Text = "";
            tb_reorder_level.Text = "";
            tb_unit.Text = "";
            tb_cost_per_unit.Text = "";
            tb_supplier.Text = "";
            cb_type_of_supply.SelectedIndex = -1;
            tb_dosage.Text = "";
            cb_method_administration.SelectedIndex = -1;
        }

        

        private void tb_supplier_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DB2ResultSet check = DB.QueryWithResultSet("SELECT * FROM SUPPLIER WHERE SUPPLIER_NUMBER = " + Convert.ToInt32(tb_supplier.Text));
                while (check.Read())
                {
                    lblsuppliername.Text = check["SUPPLIER_NAME"].ToString();
                }
            }
            catch(Exception er)
            {
                lblsuppliername.Text = "Supplier does not exist.";
            }
            
        }

        private void inventory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownum = e.RowIndex;

            tb_supply_no.Text = dgv_inventory.Rows[rownum].Cells[0].Value.ToString();
            tb_supply_name.Text = dgv_inventory.Rows[rownum].Cells[1].Value.ToString();
            tb_description.Text = dgv_inventory.Rows[rownum].Cells[2].Value.ToString();
            tb_reorder_level.Text = dgv_inventory.Rows[rownum].Cells[4].Value.ToString();
            tb_unit.Text = dgv_inventory.Rows[rownum].Cells[5].Value.ToString();
            tb_cost_per_unit.Text = dgv_inventory.Rows[rownum].Cells[6].Value.ToString();
            tb_supplier.Text = dgv_inventory.Rows[rownum].Cells[7].Value.ToString();
            cb_type_of_supply.SelectedItem = dgv_inventory.Rows[rownum].Cells[8].Value.ToString();
            tb_dosage.Text = dgv_inventory.Rows[rownum].Cells[9].Value.ToString();
            cb_method_administration.SelectedItem = dgv_inventory.Rows[rownum].Cells[10].Value.ToString();
        }

        private void btn_show_add_stock_panel_Click(object sender, EventArgs e)
        {
            int selrow = dgv_inventory.CurrentRow.Index;

            panel_add_stock.Visible = true;

            lblitemnum.Text = dgv_inventory.Rows[selrow].Cells[0].Value.ToString();
            lblitemname.Text = dgv_inventory.Rows[selrow].Cells[1].Value.ToString();


        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            Suppliers frmSuppliers = new Suppliers();
            frmSuppliers.Show();
            
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_inventory.Rows.Clear();

            string[] supplylist = new string[11];
            
            if (cb_filter.SelectedItem.Equals("ALL"))
            {
                theSupplies = DB.QueryWithResultSet("SELECT * FROM SUPPLY");
            }
            else if (cb_filter.SelectedItem.Equals("Drugs"))
            {
                theSupplies = DB.QueryWithResultSet("SELECT * FROM SUPPLY WHERE ITEM_TYPE = 'Drugs'");
            }
            else if (cb_filter.SelectedItem.Equals("Surgical"))
            {
                theSupplies = DB.QueryWithResultSet("SELECT * FROM SUPPLY WHERE ITEM_TYPE = 'Surgical'");
            }
            else if (cb_filter.SelectedItem.Equals("Surgical"))
            {
                theSupplies = DB.QueryWithResultSet("SELECT * FROM SUPPLY WHERE ITEM_TYPE = 'Non-Surgical'");
            }


            while (theSupplies.Read())
            {
                supplylist[0] = theSupplies["ITEM_NUMBER"].ToString();
                supplylist[1] = theSupplies["ITEM_NAME"].ToString();
                supplylist[2] = theSupplies["DESCRIPTION"].ToString();
                supplylist[3] = theSupplies["QUANTITY"].ToString();
                supplylist[4] = theSupplies["REORDER_LEVEL"].ToString();
                supplylist[5] = theSupplies["UNIT"].ToString();
                supplylist[6] = theSupplies["COST_PER_UNIT"].ToString();
                supplylist[7] = theSupplies["SUPPLIER_NUMBER"].ToString();
                supplylist[8] = theSupplies["ITEM_TYPE"].ToString();
                supplylist[9] = theSupplies["DOSAGE"].ToString();
                supplylist[10] = theSupplies["METHOD_OF_ADMINISTRATION"].ToString();

                dgv_inventory.Rows.Add(supplylist);
            }

            
            
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (tb_search.Text.Equals(""))
            {
                dgv_inventory.Rows.Clear();
                loadSupplyList();
            }
            else
            {
                dgv_inventory.Rows.Clear();

                string[] supplylist = new string[11];
                DB2ResultSet supplies = DB.QueryWithResultSet("SELECT * FROM SUPPLY WHERE LOWER(ITEM_NAME) LIKE '%" + tb_search.Text + "%' OR UPPER(ITEM_NAME) LIKE '%" + tb_search.Text + "%'");
                while (supplies.Read())
                {
                    supplylist[0] = supplies["ITEM_NUMBER"].ToString();
                    supplylist[1] = supplies["ITEM_NAME"].ToString();
                    supplylist[2] = supplies["DESCRIPTION"].ToString();
                    supplylist[3] = supplies["QUANTITY"].ToString();
                    supplylist[4] = supplies["REORDER_LEVEL"].ToString();
                    supplylist[5] = supplies["UNIT"].ToString();
                    supplylist[6] = supplies["COST_PER_UNIT"].ToString();
                    supplylist[7] = supplies["SUPPLIER_NUMBER"].ToString();
                    supplylist[8] = supplies["ITEM_TYPE"].ToString();
                    supplylist[9] = supplies["DOSAGE"].ToString();
                    supplylist[10] = supplies["METHOD_OF_ADMINISTRATION"].ToString();

                    dgv_inventory.Rows.Add(supplylist);
                }
            }
        }

        private void InventoryManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            MedDirMainMenu frmMD = new MedDirMainMenu();
            frmMD.Show();
            this.Dispose();
        }
    }
}
