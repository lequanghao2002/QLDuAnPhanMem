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
    public partial class GQKN_VBTL : Form, IThemeable
    {
        public GQKN_VBTL()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }


        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
