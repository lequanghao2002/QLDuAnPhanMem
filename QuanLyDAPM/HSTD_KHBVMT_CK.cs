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
    public partial class HSTD_KHBVMT_CK : Form, IThemeable
    {
        public HSTD_KHBVMT_CK()
        {
            InitializeComponent();
        }
        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }


    }
}
