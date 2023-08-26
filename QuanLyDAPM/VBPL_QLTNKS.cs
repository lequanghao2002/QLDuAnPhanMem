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
    public partial class VBPL_QLTNKS : Form, IThemeable
    {
        public VBPL_QLTNKS()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }

        private void VBPL_QLTNKS_Load(object sender, EventArgs e)
        {

        }
    }
}
