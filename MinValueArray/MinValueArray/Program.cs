using System;

namespace MinValueArray
{
    class Program
    {
        public static void show_Array(int[] x)
        {
            foreach (int i in x)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static int min_value(int[] x)
        {
            int min_value = x[0];
            for(int i = 0; i < x.Length; i++)
            {
                if(x[i] < min_value)
                {
                    min_value = x[i];
                }
            }
            return min_value;
        }
        public static void enter(int[] x)
        {
            for (int i = 0; i < x.Length; i++) 
            {
                x[i] = in_put();
            }
        }
        public static int in_put()
        {
            bool check = false;
            string x = "";
            int result = 0;
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
            Console.WriteLine("Program: the min value in Array");
            Console.WriteLine("Enter the number of value in Array: ");
            int num = in_put();
            int[] arr = new int[num];
            Console.WriteLine("Please enter the value in Array!");
            enter(arr);
            show_Array(arr);
            int minValue = min_value(arr);
           
            Console.WriteLine("Min Value in Array is " +minValue);

        }
    }
}