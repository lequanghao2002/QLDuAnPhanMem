namespace QuanLyDAPM
{
    partial class Xuat
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(478, 258);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(198, 78);
            button1.TabIndex = 0;
            button1.Text = "Xuất file *.docx";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(478, 432);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(198, 78);
            button2.TabIndex = 0;
            button2.Text = "Xuất file *.xlsx";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(478, 610);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(198, 78);
            button3.TabIndex = 0;
            button3.Text = "Xuất file *.pdf";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(330, 53);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(484, 61);
            button4.TabIndex = 1;
            button4.Text = "Chọn file cần xuất";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Xuat
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 758);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(5);
            Name = "Xuat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHỨC NĂNG XUẤT";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}