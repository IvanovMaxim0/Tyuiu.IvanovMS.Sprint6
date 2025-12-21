using Tyuiu.IvanovMS.Sprint6.Task0.V10.Lib;

namespace Tyuiu.IvanovMS.Sprint6.Task0.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string x = text2.Text;
            int y = int.Parse(x);
            DataService ds = new DataService();

            double result = ds.Calculate(y);
            textOutPut.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textOutPut_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}