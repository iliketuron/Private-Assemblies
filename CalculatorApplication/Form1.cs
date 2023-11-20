using System.Drawing.Text;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal = new CalculatorClass();
        private double num1, num2;
        public FrmCalculator()
        {
            InitializeComponent();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            if (cbOperator.Text == "+")
            {
                cal.CalculatorEvent += new Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculatorEvent -= new Formula<double>(cal.GetSum);
            }
            else if (cbOperator.Text == "-")
            {
                cal.CalculatorEvent += new Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculatorEvent -= new Formula<double>(cal.GetDifference);
            }
            else if (cbOperator.Text == "*")
            {
                cal.CalculatorEvent += new Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculatorEvent -= new Formula<double>(cal.GetProduct);
            }
            else if (cbOperator.Text == "/")
            {
                cal.CalculatorEvent += new Formula<double>(cal.GetQuotient);
                lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculatorEvent -= new Formula<double>(cal.GetQuotient);
            }
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}