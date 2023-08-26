namespace QuanLyDAPM
{
    partial class QuanLyTaiNguyenRung
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
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(273, 136);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(529, 42);
            label2.TabIndex = 8;
            label2.Text = "Danh sách quản lý tài nguyên rừng";
            // 
            // button2
            // 
            button2.Location = new Point(1084, 381);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(187, 70);
            button2.TabIndex = 6;
            button2.Text = "Chỉnh sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1084, 205);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(187, 70);
            button1.TabIndex = 7;
            button1.Text = "In";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 205);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1003, 499);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(242, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(914, 42);
            label1.TabIndex = 4;
            label1.Text = "VĂN BẢN PHÁP LÝ: QUẢN LÝ TÀI NGUYÊN RỪNG";
            // 
            // QuanLyTaiNguyenRung
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "QuanLyTaiNguyenRung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ TÀI NGUYÊN RỪNG";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
    }
}