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
    public partial class VBPL_QLTND : Form, IThemeable
    {
        public VBPL_QLTND()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }

        private void VBPL_QLTND_Load(object sender, EventArgs e)
        {

        }
    }
}
