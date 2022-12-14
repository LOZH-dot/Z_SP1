using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;

            try
            {
                a = double.Parse(FirstSideTextBox.Text);

                b = double.Parse(SecondSideTextBox.Text);

                c = double.Parse(ThirdSideTextBox.Text);

                if (a <= 0 || b <= 0 || c <= 0) throw new Exception($"Стороны не могут быть меньше или равны нулю!");
                if (!CheckTriangle(a, b, c)) throw new Exception($"Треугольника со сторонами {a},{b},{c} не существует!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (a == b && b == c && a == c)
                MessageBox.Show($"Треугольник является равносторонним!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (a == b || a == c || b == c)
                MessageBox.Show($"Треугольник является равнобедренным!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Треугольние не является ни равносторонним, ни равнобедренным!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private bool CheckTriangle(double a, double b, double c)
        {
            if (a < b + c && b < a + c && c < a + b) return true;
            else return false;
        }
    }
}
