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
    public partial class Requisitions : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB; 

        public Requisitions()
        {
            InitializeComponent();
            PopulateRequestHistoryTable();
        }

        private void linkback_Click(object sender, EventArgs e)
        {
            MedDirMainMenu frmMD = new MedDirMainMenu();
            frmMD.Show();
            this.Dispose();
        }

        private void btn_save_request_Click(object sender, EventArgs e)
        {
            if(dgv_requesition_details.Rows.Count < 1)
            {
                MessageBox.Show("Cannot submit an empty request","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB.QueryWithResultSet("INSERT INTO requesition VALUES (" + tb_requesition_number.Text + "," + tb_requested_by.Text + ",'" + cb_wardnames.Text + "',current timestamp)");
            
            foreach(DataGridViewRow r in dgv_requesition_details.Rows)
            {
                DB.Query("INSERT INTO requesitiondetail VALUES (" + tb_requesition_number.Text + "," + r.Cells[0].Value.ToString() + "," + r.Cells[2].Value.ToString() + ")");
            }

            MessageBox.Show("Successfully Added Requesition");
            PopulateRequestHistoryTable();
            EmptyFields();
        }

        private void btn_additem_Click(object sender, EventArgs e)
        {
            panel_add_stock.Show();
            PopulateSearchItemsTable();
        }

        private void btn_cancel_add_stock_Click(object sender, EventArgs e)
        {
            panel_add_stock.Hide();
        }

        private void tb_item_search_TextChanged(object sender, EventArgs e)
        {
            PopulateSearchItemsTable();
        }

        private void btn_add_stock_Click(object sender, EventArgs e)
        {
            if(dgv_add_items.SelectedRows == null)
            {
                MessageBox.Show("Cannot add item, please pick an item from the list");
                return;
            }

            if(tb_stock_quantity.Text.Equals(""))
            {
                MessageBox.Show("Cannot add item, please specify the requested stock quantity");
                return;
            }

         
            if (Int32.Parse(tb_stock_quantity.Text) > Int32.Parse(dgv_add_items.CurrentRow.Cells[2].Value.ToString()))
            {
                MessageBox.Show("Cannot add item, requested quantity exceeds the available stocks");
                return;
            }

            int matchIndex = -1;

            foreach(DataGridViewRow r in dgv_requesition_details.Rows)
            {
                if(r.Cells[1].Value.ToString() == dgv_add_items.CurrentRow.Cells[1].Value.ToString())
                {
                    if (Int32.Parse(r.Cells[2].Value.ToString()) + Int32.Parse(tb_stock_quantity.Text) > Int32.Parse(dgv_add_items.CurrentRow.Cells[2].Value.ToString()))
                    {
                        MessageBox.Show("Cannot add additional requested stock for the item, the total of the requested stock exceeds the available stocks");
                        return;   
                    }

                    matchIndex = r.Index;

                    break;
                }
            }


            if(matchIndex > -1)
            {
                dgv_requesition_details.Rows[matchIndex].Cells[2].Value = Int32.Parse(dgv_requesition_details.Rows[matchIndex].Cells[2].Value.ToString()) + Int32.Parse(tb_stock_quantity.Text);
            }
            else 
            {
                Object[] d = new Object[3];

                d[0] = dgv_add_items.CurrentRow.Cells[0].Value.ToString();
                d[1] = dgv_add_items.CurrentRow.Cells[1].Value.ToString();
                d[2] = tb_stock_quantity.Text;

                dgv_requesition_details.Rows.Add(d);
            }

            tb_stock_quantity.Text = "";
            panel_add_stock.Hide();
        }

        private void tb_stock_quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_stock_quantity.Text == "")
            {
                return;
            }

            try
            {
                Int32.Parse(tb_stock_quantity.Text);
            }
            catch (Exception ex)
            {
                tb_stock_quantity.Text = "";

                MessageBox.Show("only numeric values are allowed");
            }
        }

        private void btn_remove_item_Click(object sender, EventArgs e)
        {
            if(dgv_requesition_details.CurrentRow == null)
            {
                return;
            }

            DialogResult dr = MessageBox.Show("Do you confirm the removal of " + dgv_requesition_details.CurrentRow.Cells[1].Value.ToString() + " from the list?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if(dr == DialogResult.Yes)
            {
                dgv_requesition_details.Rows.Remove(dgv_requesition_details.CurrentRow);
            }
        }

        private void tb_request_history_search_TextChanged(object sender, EventArgs e)
        {
            PopulateRequestHistoryTable();
        }

        private void PopulateSearchItemsTable()
        {
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM SUPPLY WHERE item_name LIKE '" + tb_item_search.Text + "%' ORDER BY item_name DESC");

            dgv_add_items.Rows.Clear();

            while (rs.Read())
            {
                Object[] d = new Object[3];

                d[0] = rs.GetString(0);
                d[1] = rs.GetString(2);
                d[2] = rs.GetString(4);

                dgv_add_items.Rows.Add(d);
            }
        }

        private void PopulateRequestHistoryTable()
        {
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM REQUESITION WHERE requesition_number LIKE '" + tb_request_history_search.Text + "%' ORDER BY requesition_number DESC");

            dgv_requesition_list.Rows.Clear();

            while (rs.Read())
            {
                Object[] d = new Object[4];

                d[0] = rs.GetString(0);
                d[1] = rs.GetString(1);
                d[2] = rs.GetString(2);
                d[3] = rs.GetString(3);

                dgv_requesition_list.Rows.Add(d);
            }
        }

        private void EmptyFields()
        {
            tb_requesition_number.Text = "";
            cb_wardnames.Text = "";
            tb_requested_by.Text = "";
        }

    }
}
