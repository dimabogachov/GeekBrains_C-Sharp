using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            double Number = Convert.ToInt32(Console.ReadLine());

            double N = Number / 2; //Делим число на 2
            double NRound = Math.Round(N, MidpointRounding.AwayFromZero);
            // Округляем до ближайшего четного числа
            // В случае введенного нечетного числа получится число большее, чем неокругленное 

            if (NRound - N == 0)
            {
                Console.WriteLine("Вы ввели четное число");
            }
            else
            {
                Console.WriteLine("Вы ввели Нечетное число");
            }
        }
    }
}
