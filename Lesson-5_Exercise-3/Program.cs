using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

            //Сериализация бинарных данных
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("NumberToBytes_#2.bin", FileMode.OpenOrCreate), byteStrings);

            // Десериализация
            using (FileStream File = new FileStream("NumberToBytes_#2.bin", FileMode.Open))
            {
                byte[] deserilizeNumber = (byte[])formatter.Deserialize(File);

                foreach (byte item in deserilizeNumber)
                {
                    Console.WriteLine(deserilizeNumber[item]);
                }
            }

            
            /*
            // Вывод на консоль элементов массива byte

            for (int i = 0; i < byteStrings.Length; i++)
            {
                Console.Write($" {byteStrings[i]} ");
            }
            Console.WriteLine();
           
            // Запись массива байт в бинарный файл и чтение его содержимого с выводом на консоль

            File.WriteAllBytes("NumberToBytes.bin", byteStrings);
            byte[] fromFile = File.ReadAllBytes("NumberToBytes.bin");

            for (int i = 0; i < fromFile.Length; i++)
            {
                Console.Write($" {fromFile[i]} ");
            }
            */
        }
    }
}
