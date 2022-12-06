using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double firstElement = 0.0;
            double denominator = 0.0;
            double sum = 0.0;

            while (true)
            {
                try
                {
                    Console.Write("Введите число членов прогрессии: ");
                    n = int.Parse(Console.ReadLine());

                    Console.Write("Введите первый член геометрической прогрессии: ");
                    firstElement = double.Parse(Console.ReadLine());

                    Console.Write("Введите знаменатель геометрической прогрессии: ");
                    denominator = double.Parse(Console.ReadLine());


                    if (denominator == 1.0) throw new Exception("Знаменатель не может быть равен 1!");

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            if (denominator != 1)
                sum = (getElem(n, firstElement, denominator) * denominator - firstElement) / (denominator - 1);
            else
                sum = n * firstElement;

            Console.WriteLine($"Сумма геометрической прогрессии равна: {sum}");

        }

        static double getElem(int n, double a1, double den)
        {
            return a1 * Math.Pow(den, n - 1);
        }

    }
}
