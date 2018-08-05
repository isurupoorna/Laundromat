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
    public partial class frm_display : Form
    {
        public frm_display()
        {
            InitializeComponent();
        }

        private void timer_timeTableSystemTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.lbl_time.Text = dt.ToString();
        }

        private void frm_display_Load(object sender, EventArgs e)
        {

        }
    }
}
