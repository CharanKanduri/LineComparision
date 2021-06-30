using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LineComparision Program");

            int x1, x2, y1, y2;


            Console.WriteLine("Enter X1");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Y1 ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter X2");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Y2 ");
            y2 = Convert.ToInt32(Console.ReadLine());

            string length = FindLength(x1, x2, y1, y2);

            Console.WriteLine("The lenght is: "+length);

        }

        public static string FindLength(int a, int b, int c, int d)
        {
            double sqrt = Math.Sqrt(Math.Pow((a - b), 2) + Math.Pow((c - d), 2));
            string val = Convert.ToString(Math.Round(sqrt, 2));
            return val;

        }
    }
}

