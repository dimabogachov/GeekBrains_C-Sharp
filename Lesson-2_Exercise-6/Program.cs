using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Exercise_6
{
    class Program
    {
        [Flags]
        public enum DayOfWork
        {

            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000,
        }

        static void Main(string[] args)
        {
            // Маски рабочей недели
            DayOfWork AllWeekRequirements = DayOfWork.Понедельник | DayOfWork.Вторник | DayOfWork.Среда | DayOfWork.Четверг | DayOfWork.Пятница | DayOfWork.Суббота | DayOfWork.Воскресенье;
            


            //Дни Работы офиса
            DayOfWork WorksDayOffice1 = (DayOfWork)0b0011110;
            DayOfWork WorksDayOffice2 = (DayOfWork)0b0111111;

            bool isAll = (WorksDayOffice1 & AllWeekRequirements) == AllWeekRequirements;
           
            bool isAll2 = (WorksDayOffice2 & AllWeekRequirements) == AllWeekRequirements;
           

            if (isAll)
            {
                Console.WriteLine($"Офис №1 работает все дни неделю:");
                Console.WriteLine($"{WorksDayOffice1}");
            }
            else
            {
                Console.WriteLine($"Офис №1 работает неполную неделю:");
                Console.WriteLine($"{WorksDayOffice1}");
            }
                  
            if (isAll2)
            {
                Console.WriteLine($"Офис №2 работает все дни неделю:");
                Console.WriteLine($"{WorksDayOffice2}");
            }
            else
            {
                Console.WriteLine($"Офис №2 работает неполную неделю:");
                Console.WriteLine($"{WorksDayOffice2}");
            }


        }
    }
}
