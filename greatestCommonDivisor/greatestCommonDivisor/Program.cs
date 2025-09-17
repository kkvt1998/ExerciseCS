using System;

namespace greatestCommonDivisor
{
    class Program
    {
        public static int in_put()
        {
            string x = "";
            int result = 0;
            bool check = false;
            while (!check)
            {
                x = Console.ReadLine();
                if(int.TryParse(x, out result))
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Invalid Value, please re-enter!");
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program: Find the greatest common divisor ");
            int number1, number2;
            Console.WriteLine("Enter the first number: ");
            number1 = Math.Abs(in_put());
            Console.WriteLine("Enter the second number: ");
            number2 = Math.Abs(in_put());
            if(number1 == 0 && number2 == 0)
            {
                Console.WriteLine("No greatest common divisor exists!");
            }
            else if(number1 == 0 || number2 == 0) 
            {
                Console.WriteLine(" The greatest Common Divisor is: " + (number1 + number2));

            }
            else if(number1 == number2)
            {
                Console.WriteLine(" The greatest Common Divisor is: " + number1);

            }
            else {
                int min;
                if (number1 < number2)
                {
                    min = number1;
                }
                else
                {
                    min = number2;
                }
                for(int i = min; i >= 1; i--)
                {
                    if(number1 % i == 0 && number2 % i == 0)
                    {
                        Console.WriteLine("The greatest Common Divisor is " + i);
                        break;
                    }
                }
            }

        }
    }
}