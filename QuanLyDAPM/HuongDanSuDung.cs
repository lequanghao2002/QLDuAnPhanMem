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
    public partial class HuongDanSuDung : Form, IThemeable
    {
        public HuongDanSuDung()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }

        private void HuongDanSuDung_Load(object sender, EventArgs e)
        {

        }
    }
}
