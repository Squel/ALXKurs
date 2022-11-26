namespace Hardcoded
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HardcodeButton = new Button();
            HardcodeButton.Parent = this;
            HardcodeButton.Top = 50;
            HardcodeButton.Left = 50;
            HardcodeButton.Text = "Hardcoded button...";
            HardcodeButton.Width = 500;
            HardcodeButton.Height = 50;
            HardcodeButton.Click += new System.EventHandler(SayHello);
            HardcodeButton.Click += new System.EventHandler(ExtendetButton);
        }
        private void SayHello(Object sender, EventArgs args)
        {
            MessageBox.Show("Hello");
        }

        private void ExtendetButton(Object sender, EventArgs args)
        {
            HardcodeButton.Width += 50;
            HardcodeButton.Height += 50;
        }
    }
}