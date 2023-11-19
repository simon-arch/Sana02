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
            Console.WriteLine("> Введіть натуральне число: ");
            int n = inputProcedure("> ");
            Console.WriteLine("a = {0:f3}", func1(n));
            Console.WriteLine("b = {0:f3}", func2(n));
            Console.WriteLine("c = {0}", func3(n));
        }

        private static double func1(int n)
        {
            double res = 0;
            for (int i = 1; i <= n; i++)
            {
                res += Math.Pow(-1, i) / (2 * i + 1);
            }
            return res;
        }

        private static double func2(int n)
        {
            double res = 0;
            for (int i = 1; i <= n; i++)
            {
                res += 1+(1/Math.Pow(i, 2));
            }
            return res;
        }

        private static long func3(int n)
        {
            long res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        private static int inputProcedure(string ctext)
        {
            while (true)
            {
                Console.Write(ctext);
                if (int.TryParse(Console.ReadLine(), out int outval) && outval > 0) return outval;
                else Console.WriteLine("Введіть натуральне число.");
            }
        }
    }
}