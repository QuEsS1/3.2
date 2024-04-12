namespace лаба_10_з2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            textBox2.Text = sum.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int res = (n * (n + 1)) / 2;
            textBox2.Text=res.ToString();
        }
    }
}
