using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Xceed.Document.NET;
using Xceed.Words.NET;
using OfficeOpenXml;

namespace QuanLyDAPM
{
    public partial class ThongKeQT : Form, IThemeable
    {
        public ThongKeQT()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }

        private void ThongKeQT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DocX document = DocX.Create(@"D:\ThongKe.docx"))
            {
                document.InsertParagraph("Báo cáo thống kê").Bold().FontSize(14).Alignment = Alignment.center;
                document.Save();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            string filePath = @"D:\ThongKe.xlsx";
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                package.SaveAs(new System.IO.FileInfo(filePath));
            }
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.Chart chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart.Width = 400;
            chart.Height = 300;
            System.Windows.Forms.DataVisualization.Charting.Series series = chart.Series.Add("Dữ liệu");
            series.Points.AddXY("Mục 1", 50);
            series.Points.AddXY("Mục 2", 80);
            series.Points.AddXY("Mục 3", 30);
            string chartFileName = "Chart.png";
            string chartFilePath = @"D:\" + chartFileName;
            chart.SaveImage(chartFilePath, ChartImageFormat.Png);
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
