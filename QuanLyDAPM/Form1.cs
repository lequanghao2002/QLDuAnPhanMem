﻿namespace QuanLyDAPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bảnĐăngKýTCMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new HSTD_BDK();
            temp.Show();
        }

        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new HSTD_CKcs();
            temp.Show();
        }

        private void phiếuChuyểnĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new GQKN_PCD();
            temp.Show();
        }

        private void biênBảnKiểmTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new GQKN_BBKT();
            temp.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new GQKN_BC();
            temp.Show();
        }

        private void vănBảnTrảLờiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new GQKN_VBTL();
            temp.Show();
        }
    }
}