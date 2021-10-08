using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Exerise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер элемента из чисел Фиббоначи:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacсi(n));
           
        }
        static int Fibonacсi(int Number)
        {
            {
                if (Number == 0)
                {
                    return 0;
                }
                else if (Number == 1)
                {
                    return 1;
                }
                else
                {
                    return Fibonacсi(Number - 1) + Fibonacсi(Number - 2);
                }
            }


        }


    }
}
