namespace QuanLyDAPM
{
    partial class DoiMK
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 54);
            label1.Name = "label1";
            label1.Size = new Size(242, 36);
            label1.TabIndex = 0;
            label1.Text = "Nhập mật khẩu cũ";
            // 
            // button1
            // 
            button1.Location = new Point(384, 250);
            button1.Name = "button1";
            button1.Size = new Size(128, 43);
            button1.TabIndex = 1;
            button1.Text = "Đổi mật khẩu";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 44);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 114);
            label2.Name = "label2";
            label2.Size = new Size(262, 36);
            label2.TabIndex = 0;
            label2.Text = "Nhập mật khẩu mới";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 44);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 174);
            label3.Name = "label3";
            label3.Size = new Size(302, 36);
            label3.TabIndex = 0;
            label3.Text = "Nhập lại mật khẩu mới";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(251, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 44);
            textBox3.TabIndex = 2;
            // 
            // DoiMK
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 337);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DoiMK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHỨC NĂNG ĐỔI MẬT KHẨU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
    }
}