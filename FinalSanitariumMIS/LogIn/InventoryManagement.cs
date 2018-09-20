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

            panel_add_stock.Visible = true;
        }

        private void btn_add_stock_Click(object sender, EventArgs e)
        {
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
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM SUPPLY");

            dgv_inventory.Rows.Clear();

            while (rs.Read())
            {
                Object[] d = new Object[5];

                d[0] = rs.GetString(0);
                d[1] = rs.GetString(1);
                d[2] = rs.GetString(2);
                d[3] = rs.GetString(3);
                d[4] = rs.GetString(4);

                dgv_inventory.Rows.Add(d);
            }
        }
    }
}
