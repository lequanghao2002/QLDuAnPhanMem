namespace QuanLyDAPM
{
    public partial class TheQTMT_Nhap : Form, IThemeable
    {
        private static List<List<string>> list = new();

        public static List<List<string>>? ListData
        {
            get { return list; }
            set => list = value!;
        }

        public TheQTMT_Nhap()
        {
            InitializeComponent();
        }

        public void ApplyTheme(Color backgroundColor)
        {
            this.BackColor = backgroundColor;
        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void TheQTMT_Nhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var KhongKhiXungQuanh = new List<string>() {
                textBox1.Text, textBox6.Text, textBox11.Text
            };
            var NuocThai = new List<string>() {
                textBox2.Text, textBox7.Text, textBox12.Text
            };
            var NuocMat = new List<string>() {
                textBox3.Text, textBox8.Text, textBox13.Text
            };
            var NuocDuoiDat = new List<string>() {
                textBox4.Text, textBox9.Text, textBox14.Text
            };
            var KhiThai = new List<string>() {
                textBox5.Text, textBox10.Text, textBox15.Text
            };
            list.Clear();
            list.AddRange(new List<List<string>>()
            {
                KhongKhiXungQuanh, NuocThai, NuocMat, NuocDuoiDat, KhiThai
            });
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        
    }
}
