namespace QuanLyDAPM
{
    public partial class Form1 : Form, IThemeable
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bảnĐăngKýTCMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new HuongDanSuDung();
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
            var temp = new VBPL_QLTNKS();
            temp.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new VBPL_QLTND();
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


        private void camKếtBVMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new _4();
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

        private void kếHoạchBVMTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var temp = new HST_KHBVMT();
            temp.Show();
        }

        private void kếHoạchBVMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new HSTD_KHBVMT();
            temp.Show();
        }

        private void kếHoạchBVMTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var temp = new QLHS_KHBVMT();
            temp.Show();
        }

        private void vănBảnTrảLờiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var temp = new QuanLyTaiNguyenNuoc();
            temp.Show();
        }

        private void bảnĐăngKýĐạtTCMTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var temp = new HSTD_BDK();
            temp.Show();
        }

        private void camKếtBVMTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var temp = new HSTD_CKcs();
            temp.Show();
        }

        private void chứcNăngThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void chứcNăngMởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn 1 file";
            openFileDialog.Filter = "Các tệp DOCX (*.docx)|*.docx|Các tệp XLSX (*.xlsx)|*.xlsx|Các tệp PDF (*.pdf)|*.pdf|Tất cả các tệp (*.*)|*.*";
            openFileDialog.FilterIndex = 4;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
            }
        }

        private void chứcNăngLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string savedFilePath = "";
            if (string.IsNullOrEmpty(savedFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Lưu file mới";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    savedFilePath = saveFileDialog.FileName;
                    SaveContentToFile(savedFilePath);
                }
            }
            else
            {
                // Nếu đã lưu file trước đó, tiếp tục lưu lại file đó
                SaveContentToFile(savedFilePath);
            }
            void SaveContentToFile(string filePath)
            {
                string contentToSave = "Nội dung cần lưu vào tệp";
                File.WriteAllText(filePath, contentToSave);
            }
        }

        private void chứcNăngLưuTênKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Lưu file";
            saveFileDialog.Filter = "Các tệp DOCX (*.docx)|*.docx|Các tệp XLSX (*.xlsx)|*.xlsx|Các tệp PDF (*.pdf)|*.pdf|Tất cả các tệp (*.*)|*.*";
            saveFileDialog.FilterIndex = 4;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = saveFileDialog.FileName;
            }
        }

        private void thẻHồSơMôiTrườngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var temp = new CN_ĐGD();
            temp.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThemeManager.OnNewFormCreated(this);
        }

        private void phiếuChuyểnĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var temp = new GQKN_PCD();
            temp.Show();
        }

        private void biênBảnKiểmTraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var temp = new GQKN_BBKT();
            temp.Show();
        }

        private void biênBảnBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new GQKN_BC();
            temp.Show();
        }

        private void vănBảnTrảLờiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var temp = new GQKN_VBTL();
            temp.Show();
        }

        private void chứcNăngThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new ThongKeQT();
            temp.Show();
        }

        private void quyChuẩnTiêuChuẩnHiệnHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new VBPL_QCTCHH();
            temp.Show();
        }
    }
}