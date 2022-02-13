using System;
using System.Globalization;

namespace cSharp_DateTime_Formats___Cheat_Sheet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = DateTime.Now;
            string[] format = {
               "d", "D",
               "f", "F",
               "g", "G",
               "m",
               "r",
               "s",
               "t", "T",
               "u", "U",
               "y",
               "dddd, MMMM dd yyyy",
               "ddd, MMM d \"'\"yy",
               "dddd, MMMM dd",
               "M/yy",
               "dd-MM-yy",
            };

            string date;
            for (int i = 0; i < format.Length; i++)
            {
                date = dt.ToString(format[i], DateTimeFormatInfo.InvariantInfo);
                Console.WriteLine(String.Concat(format[i], " :", date));
            }


            Console.ReadKey();
        }
    }
}
