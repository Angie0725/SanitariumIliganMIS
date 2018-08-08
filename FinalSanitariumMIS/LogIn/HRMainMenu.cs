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
    public partial class HRMainMenu : Form
    {
        private FinalSanitariumMIS.Helpers.DatabaseHelper DB;
        
        public HRMainMenu()
        {
            InitializeComponent();

            DB = new FinalSanitariumMIS.Helpers.DatabaseHelper("127.0.0.1", "50000", "Rheamaesabas12", "BILL-LAWRENCE", "sanita");
        }
    }
}
