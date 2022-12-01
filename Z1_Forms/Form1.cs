using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int n = 0;
            double firstElement = 0.0;
            double denominator = 0.0;
            double sum = 0.0;

            try
            {
                n = int.Parse(CountTextBox.Text);

                firstElement = double.Parse(FirstElemTextBox.Text);

                denominator = double.Parse(DenominatorTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (denominator != 1)
                sum = (getElem(n, firstElement, denominator) * denominator - firstElement) / (denominator - 1);
            else
                sum = n * firstElement;

            MessageBox.Show($"Сумма {n} членов геометрической прогрессии с {firstElement} первым элементом и {denominator} знаменателем равна: {Math.Round(sum, 2)}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        double getElem(int n, double a1, double den)
        {
            return a1 * Math.Pow(den, n - 1);
        }
    }
}
