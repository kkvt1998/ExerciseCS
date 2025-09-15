using System;
using System.Runtime.Serialization.Formatters;

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
                    //show triagle types
                    case 2:
                        Console.WriteLine("Print the square triangle");
                        Console.Write("Enter length of side: ");
                        int c = int.Parse(in_put());
                        Console.WriteLine("1. Top-left");
                        Console.WriteLine("2. Top-right");
                        Console.WriteLine("3. Bottom-left");
                        Console.WriteLine("4. Bottom-right");
                        Console.Write("Enter your choice: ");
                        int TriagleChoice = int.Parse(in_put());
                        //top-left
                        if (TriagleChoice == 1)
                        {
                            for (int i = 0; i < c; i++) {
                                for (int j = c; j > i; j--) {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                        }
                        //top-right
                        else if (TriagleChoice == 2)
                        {
                            for (int i = 0; i < c; i++)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    Console.Write("  ");
                                }
                                for (int k = c; k > i; k--)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                        }
                        //bottom-left
                        else if (TriagleChoice == 3)
                        {
                            for (int i = 0; i < c; i++)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                        }
                        //bottom-right
                        else if (TriagleChoice == 4)
                        {
                            for (int i = 0; i < c; i++)
                            {
                                for (int j = c; j > i; j--)
                                {
                                    Console.Write("  ");
                                }
                                for (int k = 0; k < i; k++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else 
                        {
                            Console.WriteLine("No choice!");
                        }
                            break;
                    case 3:
                        Console.WriteLine("Print isosceles triangle ");
                        Console.Write("Enter length of side: ");
                        int d = int.Parse(in_put());
                        for (int i = 0; i < d; i++)
                        {
                            for (int j = d; j > i; j--)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k < 2*i - 1; k++)
                            {
                                Console.Write("*");
                            }
                            
                            Console.WriteLine();
                        }
                        break;
                    case 4: 
                        Console.WriteLine("Exit");
                        choice = 0;
                        break;
                    default:
                        break;
                }

            }

        }
    }
}
