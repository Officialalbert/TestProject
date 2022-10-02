namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double Ï = 3.14;
            string c = textBox4.Text;
            int val;

            bool IsValue = int.TryParse(c, out val);

            if (IsValue)
            {
                double result = 2 * Ï * Convert.ToDouble(c);
                label6.Text = result.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //p= a+b+c/2
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox1.Text);

            int sumabc = a + b + c;
            int p = sumabc / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            label5.Text = S.ToString();
        }
    }
}