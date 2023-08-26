using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDAPM;
public partial class XNTVNN : Form, IThemeable
{
    public XNTVNN()
    {
        InitializeComponent();
    }
    public void ApplyTheme(Color backgroundColor)
    {
        this.BackColor = backgroundColor;
    }


    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
