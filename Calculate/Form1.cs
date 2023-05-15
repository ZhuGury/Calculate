namespace Calculate
{
    public partial class Form1 : Form
    {
        Single a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            a = Convert.ToSingle(textBox1.Text) + Convert.ToSingle(textBox2.Text);
            textBox3.Text = a.ToString();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            a = Convert.ToSingle(textBox1.Text) - Convert.ToSingle(textBox2.Text);
            textBox3.Text = a.ToString();
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            a = Convert.ToSingle(textBox1.Text) * Convert.ToSingle(textBox2.Text);
            textBox3.Text = a.ToString();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if(Convert.ToSingle(textBox2.Text) == 0)
            {
                throw new ApplicationException();
            }
            else
            {
                label1.Text = "/";
                a = Convert.ToSingle(textBox1.Text) / Convert.ToSingle(textBox2.Text);
            }
            textBox3.Text = a.ToString();

        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Equ_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}