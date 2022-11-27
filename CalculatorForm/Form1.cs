using System.Text;

namespace CalculatorForm
{
    public partial class CalculatorForm : Form
    {

        public StringBuilder ExpressionBuilder { get; set; }
        public CalculatorForm()
        {
            ExpressionBuilder = new StringBuilder();
            InitializeComponent();
        }

        private void StringBuilderButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("Hello ");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
            ExpressionBuilder.Append("user ");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
            ExpressionBuilder.Append("this ");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
            ExpressionBuilder.Append("is ");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
            ExpressionBuilder.Append("a ");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
            ExpressionBuilder.Append("String builder. ");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
            var text = ExpressionBuilder.ToString();
            ExpressionBuilder.Clear();
        }
        
        private void Key1Button_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("1");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void Key2Button_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("2");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void Key3Button_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("3");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void Key4Button_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("4");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void Key5Button_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("5");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void Key6Button_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("6");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void Key7Button_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("7");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void Key8Button_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("8");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void Key9Button_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("9");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void Key0Button_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("0");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void KeyCommonButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append(",");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Clear();
            ResaultTextBox.Text = ExpressionBuilder.ToString() ;
        }

        private void KeyAddButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append(" + ");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void KeySubstractButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append(" - ");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void KeyMultipleyButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append(" * ");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void KeyDivineButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append(" / ");
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {

        }
    }
}