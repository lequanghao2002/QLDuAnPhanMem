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

        }

        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}