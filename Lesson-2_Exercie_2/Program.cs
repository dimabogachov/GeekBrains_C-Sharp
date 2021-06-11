using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Exercie_2
{
    class Program
    {

        enum Month // Перечисление месяцев с присвоеним порядкого номера
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
            string MounthTitle = "";

            switch (MounthNumber)
            {
                case 1:
                    MounthTitle = "Январь";
                    break;
                case 2:
                    MounthTitle = "Февраль";
                    break;
                case 3:
                    MounthTitle = "Март";
                    break;
                case 4:
                    MounthTitle = "Апрель";
                    break;
                case 5:
                    MounthTitle = "Май";
                    break;
                case 6:
                    MounthTitle = "Июнь";
                    break;
                case 7:
                    MounthTitle = "Июль";
                    break;
                case 8:
                    MounthTitle = "Август";
                    break;
                case 9:
                    MounthTitle = "Сентябрь";
                    break;
                case 10:
                    MounthTitle = "Октябрь";
                    break;
                case 11:
                    MounthTitle = "Ноябрь";
                    break;
                case 12:
                    MounthTitle = "Декабрь";
                    break;
            }

            Console.WriteLine($"Месяц - {MounthTitle}");
        }
    }
}
