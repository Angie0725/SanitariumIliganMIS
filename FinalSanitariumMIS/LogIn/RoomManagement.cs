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
    public partial class RoomManagement : Form
    {
        public RoomManagement()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void linkback_Click(object sender, EventArgs e)
        {
            MedDirMainMenu frmMD = new MedDirMainMenu();
            frmMD.Show();
            this.Hide();
        }
    }
}
