using Microsoft.VisualBasic;
using System.Diagnostics;

namespace FormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void hightButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your height is: {highTextBox.Text} cm.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = PreformOperation(Convert.ToDouble(xNumberTextBox.Text),
                                          Convert.ToDouble(yNumberTextBox.Text));
            resultTextBox.Text = result.ToString();
        }

        private double PreformOperation(double x, double y)
        {
            if (AddRadioButton.Checked)
                return x + y;
            else if (SubstractRadioButton.Checked)
                return x - y;
            else if (MultiplyRadioButton.Checked)
                return x * y;
            else
                return x / y;

        }
    }
}