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
            int sum = 0;
            for (int i = 0; i < 5; i++) sum += inputProcedure("> ");
            if (sum / 5 >= 50) Console.WriteLine("> Студента допущено до екзамену.");
            else Console.WriteLine("> Студента не допущено до екзамену.");


        }

        private static int inputProcedure(string ctext)
        {
            while (true)
            {
                Console.Write(ctext);
                if (int.TryParse(Console.ReadLine(), out int outval) && outval <= 100 && outval >= 0) return outval;
                else Console.WriteLine("Wrong input.");
            }
        }
    }
}