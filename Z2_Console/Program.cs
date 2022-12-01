using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите первую сторону треугольника: ");
                    a = double.Parse(Console.ReadLine());

                    Console.Write("Введите вторую сторону треугольника: ");
                    b = double.Parse(Console.ReadLine());

                    Console.Write("Введите третью сторону треугольника: ");
                    c = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            if (a == b && b == c && a == c)
                Console.WriteLine("Треугольник является равносторонним!");
            else
                Console.WriteLine("Треугольник не является равносторонним!");
        }
    }
}
