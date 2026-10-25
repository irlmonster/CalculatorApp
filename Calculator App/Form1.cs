using System;
using System.Data;

namespace Calculator_App
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void AppendToCalculationString(object sender, EventArgs e)
        {
            Button invokedBtn = sender as Button;
            if (invokedBtn != null)
            {
                resultBox.Text += invokedBtn.Text;
            }
        }

        private void ClearEntry(object sender, EventArgs e)
        {
            resultBox.Text = string.Empty;
        }

        private void EvaluateCalculation(object sender, EventArgs e)
        {
            string expression = resultBox.Text;
            var result = new DataTable();
            try
            {
                double evaluatedResuIt = Convert.ToDouble(result.Compute(expression, null));
                if (double.IsInfinity(evaluatedResuIt) || double.IsNaN(evaluatedResuIt))
                {
                    MessageBox.Show("Expression was evaulated to be undefined", "Evaluation Error", MessageBoxButtons.OK);
                    resultBox.Text = string.Empty;
                    return;
                }
                resultBox.Text = evaluatedResuIt.ToString(); // gör om det till string för att textrutan kan bara ta strings

            }
            catch (System.Data.SyntaxErrorException)
            {
                MessageBox.Show("Expression was not valid", "Evaluation Error", MessageBoxButtons.OK);
                resultBox.Text = string.Empty;
            }

        }


    }
}
