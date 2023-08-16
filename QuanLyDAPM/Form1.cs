namespace QuanLyDAPM
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
            var temp = new DoiMK();
            temp.Show();
        }

        private void phiếuChuyểnĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new QuanLyMoiTruong();
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

        private void thẻHồSơMôiTrườngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hồSơThẩmĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đềÁnBVMTToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void xảThảiNướcThảiVàoNguồnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new XNTVNN();
            temp.Show();
        }

        private void khaiThácNướcDướiĐấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new KTNDD();
            temp.Show();
        }


        private void đềÁnBVMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new DeAnBVMT();
            temp.Show();
        }

        private void chứcNăngThốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var temp = new ThongKe();
            temp.Show();
        }

        private void chứcNăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new Xuat();
            temp.Show();
        }

        private void bảnĐăngKýTCMTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var temp = new TheQTMT_Nhap();
            temp.Show();
        }

        private void đánhGiáTácĐộngMôiTrườngĐTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new ĐTM();
            temp.Show();
        }

        private void biênNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new GBN();
            temp.Show();
        }

        private void bảnĐăngKýĐạtTCMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new HSTD_BDK();
            temp.Show();
        }

        private void camKếtBVMTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var temp = new HSTD_CKcs();
            temp.Show();
        }


        private void đềÁnBVMTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var temp = new HST_ĐABVMT();
            temp.Show();
        }

        private void đềÁnBVMTToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var temp = new HSQL_ĐABVMT();
             temp.Show();
        }

        private void quảnLýTàiNguyênRừngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new QuanLyTaiNguyenRung();
            temp.Show();
        }
    }
}