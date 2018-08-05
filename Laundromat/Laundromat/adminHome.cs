using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundromat
{
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        private void btn_mainEdit_MouseHover(object sender, EventArgs e)
        {
            btn_mainDriver.Visible = true;
            btn_mainRoot.Visible = true;
            btn_mainUser.Visible = true;
            btn_mainVehicle.Visible = true;
        }

        private void btn_mainEdit_Click(object sender, EventArgs e)
        {
            btn_mainVehicle.Visible = false;
            btn_mainUser.Visible = false;
            btn_mainRoot.Visible = false;
            btn_mainDriver.Visible = false;
        }

        private void btn_mainEdit_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
