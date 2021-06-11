using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какая минимальная температура за сутки?");
            string MinimumTempDay = Console.ReadLine();
            float Min = Convert.ToInt32(MinimumTempDay);

            Console.WriteLine("Какая максимальная температура за сутки?");
            string MaximumTempDay = Console.ReadLine();
            float Max = Convert.ToInt32(MaximumTempDay);

            float Mean = (Max + Min) / 2;

            Console.WriteLine($"Среднесуточная температура - {Mean} градусов Цельсия");

        }
    }
}
