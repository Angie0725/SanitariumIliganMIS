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
            RefreshListofRequesitions();
        }

        private void linkback_Click(object sender, EventArgs e)
        {
            MedDirMainMenu frmMD = new MedDirMainMenu();
            frmMD.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshListofRequesitions() 
        {
            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper();

            DB2ResultSet rs = DB.QueryWithResultSet("SELECT * FROM REQUESITION");
        }

    }
}
