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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshMasterList()
        {
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM STAFF WHERE");
        }
    }
}
