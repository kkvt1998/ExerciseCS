using System;

namespace primeNumberTesting
{
    class Program
    {
        //method input data
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
                {
                    Console.WriteLine("Invalid input, please enter an integer.");
                }
            }
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program: prime number testing");
            int numberTest;
            bool isPrime = true;
            while(isPrime)
            {
                Console.WriteLine("Enter a number to check if it's prime:");
                numberTest = in_put();
                if (numberTest < 2)
                {
                    Console.WriteLine("Number " + numberTest + " isn't a prime Number");
                }
                else
                {
                    //create a variable to check if the number is primeNumber

                    for (int i = 2; i <= Math.Sqrt(numberTest); i++)
                    {
                        if (numberTest % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    //check result
                    if (isPrime)
                    {
                        Console.WriteLine("Number " + numberTest + " is a prime Number");
                    }
                    else
                    {
                        Console.WriteLine("Number " + numberTest + " isn't a prime Number");
                    }
                }
            }
            
        }
    }
}