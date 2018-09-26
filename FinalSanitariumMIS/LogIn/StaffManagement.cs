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
    public partial class StaffManagement : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;

        public StaffManagement()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Rheamaesabas12", "BILL-LAWRENCE", "sanita");
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            DB2ResultSet ResultSet = DB.QueryWithResultSet("SELECT * FROM staff");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
