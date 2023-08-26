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
    public partial class QLHS_KHBVMT_CT : Form, IThemeable
    {
        public QLHS_KHBVMT_CT()
        {
            InitializeComponent();
        }
        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var temp = new QLHS_KHBVMT_TT();
            temp.Show();
        }

        private void QLHS_KHBVMT_CT_Load(object sender, EventArgs e)
        {

        }
    }
}
