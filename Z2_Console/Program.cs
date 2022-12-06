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

                    if (a <= 0 || b <= 0 || c <= 0) throw new Exception($"Стороны не могут быть меньше или равны нулю!");
                    if (!CheckTriangle(a, b, c)) throw new Exception($"Треугольника со сторонами {a},{b},{c} не существует!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            if (a == b && b == c && a == c)
                Console.WriteLine("Треугольник является равносторонним!");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Треугольник является равнобедренным!");
            else
                Console.WriteLine("Треугольние не является ни равносторонним, ни равнобедренным!");
        }

        static bool CheckTriangle(double a, double b, double c)
        {
            if (a < b + c && b < a + c && c < a + b) return true;
            else return false;
        }
    }
}
