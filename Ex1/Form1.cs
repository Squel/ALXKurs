namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            var number = rnd.NextInt64(-100, 100);
            var number2 = rnd.NextInt64(-100, 100);
            this.button1.Location = new Point(-100 + (int)number, 100 +(int)number2);
        }
    }
}