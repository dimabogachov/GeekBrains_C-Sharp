using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
           //Запрос на введение набора чисел и сохрнение его в формате byte
            Console.WriteLine("Введите набор чисел от 0 до 255:");
            string Strings = Console.ReadLine();

            byte[] byteStrings = System.Text.Encoding.Default.GetBytes(Strings);

           
            for (int i = 0; i < byteStrings.Length; i++)
            {
                Console.Write($" {byteStrings[i]} ");
            }
            Console.WriteLine();

            File.WriteAllBytes("NumberToBytes.bin", byteStrings);
            byte[] fromFile = File.ReadAllBytes("NumberToBytes.bin");

            for (int i = 0; i < fromFile.Length; i++)
            {
                Console.Write($" {fromFile[i]} ");
            }
            
        }
    }
}
