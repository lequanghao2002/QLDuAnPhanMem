using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDAPM
{
    public partial class QLHS_KHBVMT_CT : Form
    {
        public QLHS_KHBVMT_CT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = new QLHS_KHBVMT_TT();
            temp.Show();
        }
    }
}
