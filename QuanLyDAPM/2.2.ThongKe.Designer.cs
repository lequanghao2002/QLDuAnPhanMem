﻿namespace QuanLyDAPM
{
    partial class ThongKe
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Thời gian", "Loại hình", "Khu vực" });
            comboBox1.Location = new Point(324, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 39);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 45);
            label1.Name = "label1";
            label1.Size = new Size(254, 36);
            label1.TabIndex = 1;
            label1.Text = "Chọn loại thống kê";
            // 
            // button1
            // 
            button1.Location = new Point(737, 45);
            button1.Name = "button1";
            button1.Size = new Size(177, 39);
            button1.TabIndex = 2;
            button1.Text = "Thống kê";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(895, 401);
            dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(550, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 39);
            textBox1.TabIndex = 4;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 523);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2.2 CHỨC NĂNG THỐNG KÊ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}