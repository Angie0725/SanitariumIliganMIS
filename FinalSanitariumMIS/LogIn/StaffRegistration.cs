using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class StaffRegistration : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public StaffRegistration()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Rheamaesabas12", "BILL-LAWRENCE", "sanita");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            DB.Query("INSERT INTO staff VALUES('" 
                + txtstaffnumber.Text + "','"
                + txtfirstname.Text + "','"
                + txtlastname.Text + "','"
                + txtaddress.Text + "','"
                + txttelnumber.Text + "','"
                + dateTimePicker1.Text + "','" //asdasdasdasdasdasd
                + comboBox1.Text  + "','"
                + txtNIN.Text + 
            "')");
        }
    }
}
