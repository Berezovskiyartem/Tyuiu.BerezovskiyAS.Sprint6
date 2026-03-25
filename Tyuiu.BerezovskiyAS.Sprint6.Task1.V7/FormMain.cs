using System;
using System.Windows.Forms;

namespace FunctionTabulationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalculateAndDisplay();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateAndDisplay();
        }

        private void CalculateAndDisplay()
        {
            try
            {
                txtResult.Clear();

                // Заголовок
                txtResult.Text = "Табулирование функции F(x) = (2x-3)/(cos(x)+x) + 5\r\n";
                txtResult.Text += "Диапазон: [-5; 5], шаг: 1\r\n";
                txtResult.Text += "При делении на ноль возвращается 0\r\n";
                txtResult.Text += new string('-', 50) + "\r\n";
                txtResult.Text += "    x     |    F(x)    \r\n";
                txtResult.Text += new string('-', 50) + "\r\n";

                // Табуляция
                for (double x = -5; x <= 5.001; x += 1)
                {
                    double numerator = 2 * x - 3;
                    double denominator = Math.Cos(x) + x;
                    double y;

                    if (Math.Abs(denominator) < 1e-10)
                    {
                        y = 0;
                        txtResult.Text += string.Format("{0,8:F2} | {1,10:F2} *\r\n", x, y);
                    }
                    else
                    {
                        y = numerator / denominator + 5;
                        txtResult.Text += string.Format("{0,8:F2} | {1,10:F2}\r\n", x, y);
                    }
                }

                txtResult.Text += new string('-', 50) + "\r\n";
                txtResult.Text += "* - значение получено при делении на ноль\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
