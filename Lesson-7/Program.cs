using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Program
    {
        /// Рекурсивный метод для вычисления факториала числа

        static double Factorial(uint n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }

        }

        /// Рекурсивный метод возведения в степень
        static double Power(double N, int degree)
        {
            if (degree == 0)
            {
                return 1;
            }
            else
            {
                return N * Power(N, degree - 1);
            }

        }

        /// Модуль числа
        static double Abs(double n)
        {
            if (n >= 0)
            {
                return n;
            }

            return -n;
        }


        /// Рекурсивный метод вычисления cos(x)

        public static double Cos(double x, int n = 0, double precision = 1e-3)
        {
            var t = Power(-1, n) * Power(x, 2 * n) / Factorial((uint)(2 * n));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Cos(x, n + 1, precision);
        }

        public static void Main()
        {
            Console.Write("Введите значение агумента функции cos(x) в радианах = ");
            var x = double.Parse(Console.ReadLine());
            var result = Cos(x);
            Console.WriteLine("Cos(x)      = {0:f5}", result);
            Console.WriteLine("Math.Cos(x) = {0:f5}", Math.Cos(x));

        }
    }

}


