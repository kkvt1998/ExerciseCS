using System;
using System.Net;

namespace primeNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program: dislay prime numbers between 2 to 100");
            int dem = 0;
            for(int i = 2; i < 100; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        dem = dem + 1;
                    }
                }
                if(dem == 2)
                {
                    Console.WriteLine(i);
                    
                }
                dem = 0;
            }
        }
    }
}