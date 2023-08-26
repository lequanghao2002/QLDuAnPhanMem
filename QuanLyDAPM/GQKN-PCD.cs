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
    public partial class GQKN_PCD : Form, IThemeable
    {
        private ToolTip tt;

    
        public GQKN_PCD()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }


        private void GQKN_PCD_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            tt = new ToolTip();
            tt.InitialDelay = 1;
            tt.IsBalloon = true;
            tt.Show(string.Empty, textBox1);
            tt.Show("Tên cơ quan, tổ chức, đơn vị cấp trên trực tiếp", textBox1, 0);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            tt.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
