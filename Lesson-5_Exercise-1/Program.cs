using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string File_txt = "Задание_#1.txt";
            File.WriteAllText(File_txt, "К Истине нет пути");

            File.AppendAllText(File_txt, Environment.NewLine);

            string[] Add =
            {
                "В этом красота Истины",
                "<Свобода от Известного>"
            };

            File.AppendAllLines(File_txt, Add);

            string Text = File.ReadAllText(File_txt);
            Console.WriteLine(Text);

            string[] Lines = File.ReadAllLines(File_txt);
            Console.WriteLine(Lines[0]);



        }
    }
}
