using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x1, x2, D;
            Console.WriteLine("a^2 + b*x + c = 0");
            a = inputProcedure("a: ");
            b = inputProcedure("b: ");
            c = inputProcedure("c: ");
            D = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0) Console.WriteLine("Equation is not Quadratic.");
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("\nDiscriminant: {0:f3}", D);
                Console.WriteLine("Two roots ");
                Console.WriteLine("x1: {0:f3}", x1);
                Console.WriteLine("x2: {0:f3}", x2);
            }
            else if (D == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine("\nDiscriminant: {0}", D);
                Console.WriteLine("One root ");
                Console.WriteLine("x: {0:f3}", x1);
            }
            else
            {
                Console.WriteLine("\nDiscriminant: {0:f3}", D);
                Console.WriteLine("No roots.");
            }
        }

        private static double inputProcedure(string ctext)
        {
            while (true)
            {
                Console.Write(ctext);
                if (double.TryParse(Console.ReadLine(), out double outval)) return outval;
                else Console.WriteLine("Wrong input.");
            }
        }
    }
}