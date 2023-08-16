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
    public partial class QLHS_KHBVMT : Form
    {
        public QLHS_KHBVMT()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var temp = new QLHS_KHBVMT_CT();
            temp.Show();
        }
    }
}
