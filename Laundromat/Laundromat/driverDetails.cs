using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundromat
{
    public partial class driverDetails : UserControl
    {
        public driverDetails()
        {
            InitializeComponent();
        }

        private void driverDetails_Load(object sender, EventArgs e)
        {

        }

        private void btn_editDriver_Click(object sender, EventArgs e)
        {
            btn_driverSearch.Visible = true;
            btn_driverDelete.Visible = true;
        }

        private void btn_newDriver_Click(object sender, EventArgs e)
        {
            btn_driverSearch.Visible = false;
            btn_driverDelete.Visible = false;
        }
    }
}
