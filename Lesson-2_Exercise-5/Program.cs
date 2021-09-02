using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Exercise_5
{
       class Program
    {
        enum Mounth
        {
            Январь = 1,
            Февраль = 2,
            Март = 3,
            Апрель = 4,
            Май = 5,
            Июнь = 6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите порядковый номер месяца");
            int MounthNumber = Convert.ToInt32(Console.ReadLine());
            string Season = "";

            switch (MounthNumber)
            {
                case 1:
                case 2:
                case 12:
                    Season = "Зима";
                    break;
                case 3:
                case 4:
                case 5:
                    Season = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    Season = "Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    Season = "Осень";
                    break;
            }

            Console.WriteLine($"Сезон - {Season}");

            Console.WriteLine("Какая минимальная температура за сутки?");
            string MinimumTempDay = Console.ReadLine();
            float Min = Convert.ToInt32(MinimumTempDay);

            Console.WriteLine("Какая максимальная температура за сутки?");
            string MaximumTempDay = Console.ReadLine();
            float Max = Convert.ToInt32(MaximumTempDay);

            float Mean = (Max + Min) / 2;

            Console.WriteLine($"Среднесуточная температура - {Mean} градусов Цельсия");

            bool isWarmWinter = Season == "Зима" && (Mean > 0);
            bool isCoolSummer = Season == "Лето" && (Mean < 0);
            if (isWarmWinter)
            {
                Console.WriteLine("Дождливая Зима");
            }
            if (isCoolSummer)
            {
                Console.WriteLine("Морозное Лето");
            }
        }
    }
}
