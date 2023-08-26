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
    public partial class Xuat : Form, IThemeable
    {
        public Xuat()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file cần xuất";
            openFileDialog.Filter = "Các tệp DOCX (*.docx)|*.docx|Các tệp XLSX (*.xlsx)|*.xlsx|Các tệp PDF (*.pdf)|*.pdf|Tất cả các tệp (*.*)|*.*";
            openFileDialog.FilterIndex = 4;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
            }
        }
    }
}
