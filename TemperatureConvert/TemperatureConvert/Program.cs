using System;
namespace TemperatureConvert
{
    class Program
    {
    
        public static void convertCtoF()
        {
            Console.WriteLine("Please enter the degree C: ");
            double degree = (double)in_put();
            degree = degree * 9 / 5 + 32;
            Console.WriteLine("Result: " + degree + "F");
        }
        public static void convertFtoC()
        {
            Console.WriteLine("Please enter the degree F: ");
            double degree = (double)in_put();
            degree = (degree - 32)* 5/9;
            Console.WriteLine("Result: " + degree + "C");
        }
        public static int in_put()
        {
            string x = "";
            int result = 0;
            bool check = false;
            while (!check)
            {
                x = Console.ReadLine();
                if (int.TryParse(x, out result))
                {
                    check = true;
                }
                else
                    Console.WriteLine("Input invalid, please re-enter!");
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Program: Temperature Convert");
            bool access = false;
            while (!access)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Convert degree C to degree F");
                Console.WriteLine("2. Convert degree F to degree C");
                Console.WriteLine("3. Exit");
                int choose = in_put();
                if (choose == 3)
                {
                    access = true;
                }
                else if (choose == 1)
                {
                    convertCtoF();
                }
                else if (choose == 2)
                {
                    convertFtoC();
                }
                else
                {
                    Console.WriteLine("input invalid, please re-choose !");
                }
                
            }
            

        }
    }
}