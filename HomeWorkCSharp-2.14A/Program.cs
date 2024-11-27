using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._14A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.14А. Даны стороны прямоугольника. Найти его периметр и длину диагонали.
            Console.WriteLine("Программа для вычисления периметра и длины диагонали прямоугольника по сторонам.");
        imputA:
            Console.Write("Введите сторону \"a\": ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
            imputB:
                Console.Write("Введите сторону \"b\": ");
                double b = Convert.ToDouble(Console.ReadLine());
                if (b > 0)
                {
                    double P = (a + b) * 2;
                    double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    Console.WriteLine($"Периметр прямоугольника равен: {P.ToString("#.##")}\nДиагональ прямоугольника равна: {d.ToString("#.##")}");
                    return;
                }
                Console.WriteLine("Введено неверное значение");
                goto imputB;
            }
            Console.WriteLine("Введено неверное значение");
            goto imputA;
        }
    }
}
