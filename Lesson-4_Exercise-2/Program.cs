using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант №1
            Console.WriteLine("Ведите числа через пробел: ");
            string Numbers = Console.ReadLine();
            var number = Numbers.Split();
            int Sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                Sum = Sum + int.Parse(number[i]);
            };
            Console.WriteLine(Sum);


            // Вариант №2
            Console.WriteLine("Ведите числа через пробел: ");
            string[] Input = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < Input.Length; sum += Convert.ToInt32(Input[i++]))
            {
                
            };
            Console.WriteLine(sum);

        }

    }
}
