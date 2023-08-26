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
    public partial class VBPL_QCTCHH : Form, IThemeable
    {
        public VBPL_QCTCHH()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }

        private void VBPL_QCTCHH_Load(object sender, EventArgs e)
        {

        }
    }
}
