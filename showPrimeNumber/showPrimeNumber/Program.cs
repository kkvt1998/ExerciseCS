using System;

namespace showPrimeNumber
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
                if (int.TryParse(x, out result))
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Invalid your number, please re-enter your number!");
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Program: Show Prime Number");
            Console.WriteLine("Enter the number of prime numbers you want to display: ");
            int numPrime;
            numPrime = in_put();
            if (numPrime <= 20)
            {
                Console.Write(numPrime + " number of the prime numbers is:");
                int count = 0, checkPrime = 0;
                for (int i = 2; i < 10000; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if(i % j == 0)
                        {
                            checkPrime++;
                        }
                    };
                    if(checkPrime == 2)
                    {
                        Console.Write(" " +i);
                        count++;
                    }
                    checkPrime = 0;
                    if(count == numPrime)
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("the number of prime numbers is out of range 20");
            }
        }

    }
}