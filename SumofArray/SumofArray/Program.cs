using System;

namespace SumofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array
            int[] number1 = new int[6];
            // add values to array
            number1[0] = 10;
            number1[1] = 4;
            number1[2] = 1;
            number1[3] = 8;
            number1[4] = 2;
            number1[5] = 7;
            //display elements of array
            Console.WriteLine("Element[0] is : " + number1[0]);
            Console.WriteLine("Element[1] is : " + number1[1]);
            //Calculate
            int sum = 0;
            foreach (int i in number1)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum of the array is: " + sum);
            //int total = 0;
            //for (int i = 0; i < number1.Length; i++)
            //{
            //    total = total + number1[i];
            //}
            //Console.WriteLine(total.ToString());

        }
    }
}
