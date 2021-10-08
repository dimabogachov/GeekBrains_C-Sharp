using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_4_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {

            (string firstName, string lastName, string patronymic)[] FIOs = CreateFullNames();
            //*Menu();
            PrintUsers(FIOs);
        }

        // Метод по вводу ФИО
        static (string firstName, string lastName, string patronymic) CreateFullName()
        {
            Console.WriteLine("Введите Фамилию");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите Имя");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите Отчество");
            string patronymic = Console.ReadLine();

            return (firstName, lastName, patronymic);
        }
       // Сначала была идея вывести меню с запросом ввода ФИО и одновременным подсчетом количества введенных ФИО,
       // но не понятно как передать параметр Numder

        /*static (string answer, int Number) Menu()
        {

             Console.WriteLine($"Введите ФИО? (y/n):");
              string answer = Console.ReadLine();
              int Number = 0;
              do
              {
                  switch (answer)
                  {
                      case "y":
                          CreateFullName();
                          ++Number;
                          break;
                      case "n":
                          Console.WriteLine("Ввод ФИО завершен"); ;
                          break;
                      default:
                          break;
                  }
              } while (answer != "y");
              return (answer, Number);
          
        }
        */

        // Метод по создаию массива ФИО
        static (string firstName, string lastName, string patronymic)[] CreateFullNames()
        {
            int Sum = 3;
            (string firstName, string lastName, string patronymic)[] FIO = new (string firstName, string lastName, string patronymic)[Sum];
            for (int i = 0; i < FIO.Length; i++)
            {
                FIO[i] = CreateFullName();
            }

            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();

            return FIO;
        }


       //Метод, перебирающий массив сохраненных ФИО с вызовом метода печати ФИО
        static void PrintUsers((string firstName, string lastName, string patronymic)[] FIOs)
        {
            Console.WriteLine("Вывод введенных ФИО:");
            for (int i = 0; i < FIOs.Length; i++)
            {
                PrintUser(FIOs[i]);
            }

        }

        // Метод, выводящий на печать ФИО 
        static void PrintUser((string firstName, string lastName, string patronymic) FIO)
        {
            Console.WriteLine($"{FIO.firstName} {FIO.lastName} {FIO.patronymic}");
        }

    }
}
