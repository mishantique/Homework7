using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, z1, x2, y2, z2;
            Console.WriteLine("Введите первую сторону первого треугольника");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону первого треугольника");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третью сторону первого треугольника");
            z1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите первую сторону второго треугольника");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону второго треугольника");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третью сторону второго треугольника");
            z2 = Convert.ToDouble(Console.ReadLine());

            double S1 = GetSquare(x1, y1, z1);
            double S2 = GetSquare(x2, y2, z2);

            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
            else if 
                (S1 < S2)
            {
                Console.WriteLine("Площадь второго треугольника больше");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Площади равны");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }
        static double GetSquare(double x, double y, double z)
        {
            double p = (x + y + z)/2.0;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }
}
