using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointsAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("Введіть ціле число в діапазоні [0,9]");
            int num = inputProcedure("> ", 0, 9);
            switch (num)
            {
                case 0: Console.WriteLine("{0} - нуль.", num); break;
                case 1: Console.WriteLine("{0} - один.", num); break;
                case 2: Console.WriteLine("{0} - два.", num); break;
                case 3: Console.WriteLine("{0} - три.", num); break;
                case 4: Console.WriteLine("{0} - чотири.", num); break;
                case 5: Console.WriteLine("{0} - п'ять.", num); break;
                case 6: Console.WriteLine("{0} - шість.", num); break;
                case 7: Console.WriteLine("{0} - сім.", num); break;
                case 8: Console.WriteLine("{0} - вісім.", num); break;
                case 9: Console.WriteLine("{0} - дев'ять", num); break;
            }

        }

        private static int inputProcedure(string ctext, int min, int max)
        {
            while (true)
            {
                Console.Write(ctext);
                if (int.TryParse(Console.ReadLine(), out int outval) && outval <= max && outval >= min) return outval;
                else Console.WriteLine("Дані мають бути цифрою, що належить діапазону [0,9].");
            }
        }
    }
}