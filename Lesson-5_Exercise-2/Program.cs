using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Time_txt = "StartUp.txt";

            var Time = DateTime.Now;
            File.WriteAllText(Time_txt, Time.ToLongTimeString());

            string OutTime = File.ReadAllText(Time_txt);
            Console.WriteLine(OutTime);
        }
    }
}
