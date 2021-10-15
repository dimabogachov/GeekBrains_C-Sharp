using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_6_TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {

            Process[] ProcList = Process.GetProcesses();
            // Вывод запущенных Id процесса и его имя
            foreach (var proc in ProcList)
            {
                Console.WriteLine($"{proc.Id} {proc.ProcessName} ");
            }

            Console.WriteLine();

            string id = GetId();

            try
            {
                using (Process chosen = Process.GetProcessById(Int32.Parse(id)))
                {
                    {
                        chosen.Kill();
                        //chosen.WaitForExit();
                        Console.WriteLine($"Процесс  {chosen.ProcessName} завершен");
                    }
                }
            }
            catch (IdException ex) when (ex.Code == ErrorCodes.Empty)
            {

                Console.WriteLine("Вы не ввели номер Id процесса");
            }

            catch (ArgumentException)
            {
                Console.WriteLine($"Процесс с номером {id} не найден! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Произошла ошибка: {ex.Message} ");
            }
        }
        //Метод по получению Id процесса из списка запущенных
        static string GetId()
        {
            Console.Write("Введите номер Id процесса для завершения:");
            string Id = Console.ReadLine();
            if (string.IsNullOrEmpty(Id))
            {
                throw new IdException(ErrorCodes.Empty);
            }

            return Id;
        }
    }
}