﻿using System;
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
    public partial class QLHS_KHBVMT_TT : Form, IThemeable
    {
        public QLHS_KHBVMT_TT()
        {
            InitializeComponent();
        }
        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}