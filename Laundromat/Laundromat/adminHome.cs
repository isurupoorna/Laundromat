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

        private void btn_mainEdit_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_mainDriver_Click(object sender, EventArgs e)
        {
            btn_mainDriver.FlatAppearance.BorderColor = Color.Red;
            
        }
    }
}
