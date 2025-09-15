using System;

namespace Design_Menu_Aplication
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
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Welcome to the Menu Application!");
            int choice = -1;
            while(choice != 0)
            {
                //Menu Item
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                // Invalid your choice
                choice = int.Parse(in_put());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }

        }
    }
}
