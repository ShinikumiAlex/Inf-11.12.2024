using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf_11._12._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = Input("day=");
            string a = GetDay(day);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        static byte Input (string message)
        {
            Console.Write(message);
            return byte.Parse(Console.ReadLine());
        }

        static string GetDay(int day)
        {
            switch(day)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: return "Error";
            }
        }
    }
}
