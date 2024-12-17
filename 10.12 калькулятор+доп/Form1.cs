using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _10._12_калькулятор_доп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double currentValue = 0;
        double previousValue = 0;
        string currentOperation = "";
        bool isNewEntry = true;
        List<string> history = [];

        private void AddToHistory(string text)
        {
            history.Add(text);
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (isNewEntry)
            {
                lblDisplay.Text = btn.Text;
                isNewEntry = false;
            }
            else
            {
                lblDisplay.Text += btn.Text;
            }

            currentValue = Convert.ToDouble(lblDisplay.Text);
        }
        private void Operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!isNewEntry || (btn.Text != "" && btn.Text is not null))
            {
                previousValue = currentValue;
                currentOperation = btn.Text;
                isNewEntry = true;
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (currentOperation)
            {
                case "+":
                    AddToHistory($"{previousValue} + {currentValue} = {previousValue + currentValue}");
                    currentValue = previousValue + currentValue;
                    break;
                case "-":
                    AddToHistory($"{previousValue} - {currentValue} = {previousValue - currentValue}");
                    currentValue = previousValue - currentValue;
                    break;
                case "÷":

                    if (currentValue != 0)
                    {
                        AddToHistory($"{previousValue} / {currentValue} = {previousValue / currentValue}");
                        currentValue = previousValue / currentValue;
                    }
                    else
                        lblDisplay.Text = "Ошибка: деление на ноль!";
                    break;
                case "х":
                    AddToHistory($"{previousValue} * {currentValue} = {previousValue * currentValue}");
                    currentValue = previousValue * currentValue;
                    break;
                case "x^y":
                    AddToHistory($"{previousValue}^{currentValue} = {Math.Pow(previousValue, currentValue)}");
                    currentValue = Math.Pow(previousValue, currentValue);
                    break;
            }
            lblHistory.Text = history[^1];
            lblDisplay.Text = currentValue.ToString();
            isNewEntry = true;
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double number = double.Parse(lblDisplay.Text);
            currentValue = Math.Sqrt(number);
            lblDisplay.Text = currentValue.ToString();
            isNewEntry = true;
            AddToHistory($"sqrt({number}) = {currentValue}");
            lblHistory.Text = history[^1];
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            currentValue = 0;
            previousValue = 0;
            lblDisplay.Text = "0";
            isNewEntry = true;
            history.Clear();
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {

            decimal number = decimal.Parse(lblDisplay.Text);

            decimal result = number / 100;
            lblDisplay.Text = result.ToString();
            isNewEntry = true;
            AddToHistory($"{number}% = {result}");
            lblHistory.Text = history[^1];
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {

            decimal number = decimal.Parse(lblDisplay.Text);

            decimal result = Math.Abs(number);
            lblDisplay.Text = result.ToString();
            isNewEntry = true;
            AddToHistory($"|{number}| = {result}");
            lblHistory.Text = history[^1];
        }

        private void btnFact_Click(object sender, EventArgs e)
        {

            int number = (int)double.Parse(lblDisplay.Text);
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            lblDisplay.Text = result.ToString();
            isNewEntry = true;
            AddToHistory($"{number}! = {result}");
            lblHistory.Text = history[^1];
        }

        private void btnLog_Cick(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(lblDisplay.Text);

                if (number <= 0)
                    throw new Exception("Логорифм определен только для положительных чисел");

                double result = Math.Log(number);

                lblDisplay.Text = result.ToString();
                AddToHistory($"Log({number}) = {result}");
                lblHistory.Text = history[^1];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDisplay.Text = "";
            }
        }
        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(lblDisplay.Text);

                double result = Math.Tan(number);

                lblDisplay.Text = result.ToString();

                AddToHistory($"Tan({number}) = {result}");
                lblHistory.Text = history[^1];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDisplay.Text = "";
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(lblDisplay.Text);

                double result = Math.Sin(number);

                lblDisplay.Text = result.ToString();

                AddToHistory($"sin({number}) = {result}");
                lblHistory.Text = history[^1];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDisplay.Text = "";
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(lblDisplay.Text);

                double result = Math.Cos(number);

                lblDisplay.Text = result.ToString();

                AddToHistory($"Cos({number}) = {result}");
                lblHistory.Text = history[^1];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDisplay.Text = "";
            }
        }
    }
}
