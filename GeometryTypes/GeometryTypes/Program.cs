using System;

namespace GeometryTypes
{
    class Program
    {
        public static string in_put()
        {
            bool success = false;
            string x = "";
            while (!success)
            {
                x = Console.ReadLine();
                if (int.TryParse(x, out int result))
                {
                    Console.WriteLine("Input is valid.");
                    success = true;
                }
                else
                {
                    Console.WriteLine("Input is invalid. Please enter a valid number:");
                }
            }
            return x;
        }
        public static string rectangle(int a, int b) {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            return "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program : Display Geometry Types");
            Console.WriteLine("===================================");
            int choice = -1;
            while(choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("4. Exit");

                choice = int.Parse(in_put());
                switch (choice)
                {
                    //Show rectangle types
                    case 1:
                        Console.WriteLine("Enter length of two sides:");
                        Console.Write("Length a: ");
                        int a = int.Parse(in_put());
                        Console.Write("Length b: ");
                        int b = int.Parse(in_put());
                        rectangle(a, b);
                        break;
                    default:
                        break;
                }

            }

        }
    }
}
