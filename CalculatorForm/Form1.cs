using CalculatorForm.Services;
using CalculatorForm.Services.Interface;
using System.Text;

namespace CalculatorForm
{
    public partial class CalculatorForm : Form
    {

        private StringBuilder ExpressionBuilder { get; set; }
        private ICalculatorService ExpressionService { get; set; }

        public CalculatorForm()
        {
            ExpressionBuilder = new StringBuilder();
            ExpressionService = new ExpressionService();
            ExpressionBuilder.Clear();
            InitializeComponent();
        }


        private void ExpressionButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendExpression(button.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Clear();
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            var expression = ResaultTextBox.Text;
            var result = ExpressionService.ProcessExpression(expression);
            ResaultTextBox.Text = result.ToString();
            ExpressionBuilder.Clear();
        }

        private void AppendExpression(string expressionPart)
        {
            ExpressionBuilder.Append(expressionPart);
            ResaultTextBox.Text = ExpressionBuilder.ToString();
        }
    }
}




        