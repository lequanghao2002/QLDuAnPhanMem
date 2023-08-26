namespace QuanLyDAPM
{
    partial class CN_ĐGD
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(119, 67);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Chọn màu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CN_ĐGD
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 209);
            Controls.Add(button1);
            Name = "CN_ĐGD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CN_ĐGD";
            Load += CN_ĐGD_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}