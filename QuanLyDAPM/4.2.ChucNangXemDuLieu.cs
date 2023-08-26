namespace QuanLyDAPM;
public partial class _4 : Form, IThemeable
{
    public _4()
    {
        InitializeComponent();
    }

    public void ApplyTheme(Color backgroundColor)
    {
        this.BackColor = backgroundColor;
    }


    private void _4_Load(object sender, EventArgs e)
    {
        if (TheQTMT_Nhap.ListData is null)
        {
            MessageBox.Show("No data");
            this.Close();
            return;
        }
        textBox1.Text = TheQTMT_Nhap.ListData[0][0];
        textBox6.Text = TheQTMT_Nhap.ListData[0][1];
        textBox11.Text = TheQTMT_Nhap.ListData[0][2];
        textBox2.Text = TheQTMT_Nhap.ListData[1][0];
        textBox7.Text = TheQTMT_Nhap.ListData[1][1];
        textBox12.Text = TheQTMT_Nhap.ListData[1][2];
        textBox3.Text = TheQTMT_Nhap.ListData[2][0];
        textBox8.Text = TheQTMT_Nhap.ListData[2][1];
        textBox13.Text = TheQTMT_Nhap.ListData[2][2];
        textBox4.Text = TheQTMT_Nhap.ListData[3][0];
        textBox9.Text = TheQTMT_Nhap.ListData[3][1];
        textBox14.Text = TheQTMT_Nhap.ListData[3][2];
        textBox5.Text = TheQTMT_Nhap.ListData[4][0];
        textBox10.Text = TheQTMT_Nhap.ListData[4][1];
        textBox15.Text = TheQTMT_Nhap.ListData[4][2];
    }

  
}
