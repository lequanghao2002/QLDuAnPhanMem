namespace QuanLyDAPM;

partial class QuanLyTaiNguyenNuoc
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridView1 = new DataGridView();
        TT = new DataGridViewTextBoxColumn();
        TenCongTrinh = new DataGridViewTextBoxColumn();
        ViTri = new DataGridViewTextBoxColumn();
        NguonNuoc = new DataGridViewTextBoxColumn();
        GiaTriDongChayToiThieu = new DataGridViewTextBoxColumn();
        LoaiHinhCongTrinh = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TT, TenCongTrinh, ViTri, NguonNuoc, GiaTriDongChayToiThieu, LoaiHinhCongTrinh });
        dataGridView1.Location = new Point(20, 19);
        dataGridView1.Margin = new Padding(5);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 29;
        dataGridView1.Size = new Size(1500, 1091);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // TT
        // 
        TT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        TT.HeaderText = "TT";
        TT.MinimumWidth = 6;
        TT.Name = "TT";
        // 
        // TenCongTrinh
        // 
        TenCongTrinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        TenCongTrinh.HeaderText = "Tên công trình";
        TenCongTrinh.MinimumWidth = 6;
        TenCongTrinh.Name = "TenCongTrinh";
        // 
        // ViTri
        // 
        ViTri.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        ViTri.HeaderText = "Vị trí";
        ViTri.MinimumWidth = 6;
        ViTri.Name = "ViTri";
        // 
        // NguonNuoc
        // 
        NguonNuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        NguonNuoc.HeaderText = "Nguồn nước";
        NguonNuoc.MinimumWidth = 6;
        NguonNuoc.Name = "NguonNuoc";
        // 
        // GiaTriDongChayToiThieu
        // 
        GiaTriDongChayToiThieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        GiaTriDongChayToiThieu.HeaderText = "Giá trị dòng chảy tối thiểu";
        GiaTriDongChayToiThieu.MinimumWidth = 6;
        GiaTriDongChayToiThieu.Name = "GiaTriDongChayToiThieu";
        // 
        // LoaiHinhCongTrinh
        // 
        LoaiHinhCongTrinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        LoaiHinhCongTrinh.HeaderText = "Loại hình công trình";
        LoaiHinhCongTrinh.MinimumWidth = 6;
        LoaiHinhCongTrinh.Name = "LoaiHinhCongTrinh";
        // 
        // QuanLyTaiNguyenNuoc
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1539, 1130);
        Controls.Add(dataGridView1);
        Margin = new Padding(5);
        Name = "QuanLyTaiNguyenNuoc";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý tài nguyên nước";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn TT;
    private DataGridViewTextBoxColumn TenCongTrinh;
    private DataGridViewTextBoxColumn ViTri;
    private DataGridViewTextBoxColumn NguonNuoc;
    private DataGridViewTextBoxColumn GiaTriDongChayToiThieu;
    private DataGridViewTextBoxColumn LoaiHinhCongTrinh;
}