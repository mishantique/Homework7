using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());

            double V;
            double S;

            GetParams(a, out V, out S);
            Console.WriteLine("Площадь куба составляет: {0:.00}; объём: {1:.00}", S, V);
            Console.ReadKey();
        }
        static void GetParams(double a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = 6.0 * Math.Pow(a, 2);
        }
    }
}
