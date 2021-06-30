using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LineComparision Program");
            int x1, x2, y1, y2;
            int stringLenght1 = 0;
            int stringLength2 = 0;


            String[] lengthArray = new String[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter X1");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Y1 ");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter X2");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Y2 ");
                y2 = Convert.ToInt32(Console.ReadLine());

                lengthArray[i] = FindLength(x1, x2, y1, y2);
            }
            Console.WriteLine("The lengths are" + lengthArray[0] + " " + lengthArray[1]);

            stringLenght1 = lengthArray[0].Length;
            stringLength2 = lengthArray[1].Length;

            if (string.Equals(lengthArray[0], lengthArray[1]))
            {
                Console.WriteLine("\nBoth Lengths are same");
            }
            else if (stringLenght1 > stringLength2)
            {
                Console.WriteLine("\nSecond line is larger");
            }
            else
            {
                Console.WriteLine("\nFirst line is larger"); 
            }
        }


        public static string FindLength(int a, int b, int c, int d)
        {
            double sqrt = Math.Sqrt(Math.Pow((a - b), 2) + Math.Pow((c - d), 2));
            string val = Convert.ToString(Math.Round(sqrt, 2));
            return val;
        }
    }
}



