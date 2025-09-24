using System;
using System.Security.Cryptography.X509Certificates;

namespace DeleteElementArray
{
    class Program
    {
        //method delete an element in Array
        public static void delete_arr(int[] x, int d)
        {
            int[] new_arr = new int[x.Length - 1];
            int index_del = 0;
            bool check_index = false;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == d)
                {
                    index_del = i;
                    check_index = true;
                    break;
                }
            }
            if (!check_index)
            {
                Console.WriteLine("No find the value");
            }
            else
            {
                for(int i = 0; i < index_del; i++)
                {
                    new_arr[i] = x[i];
                }
                for(int i = index_del + 1; i < x.Length; i++)
                {
                    new_arr[i - 1] = x[i];
                }
                Console.WriteLine("Array is : ");
                show_arr(new_arr);
            }

        }
        public static void show_arr(int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
        }
        //method enter input value

        public static int in_put()
        {
            bool check = false;
            string x = "";
            int result = 0;
            while (!check)
            {
                x = Console.ReadLine();
                if(int.TryParse(x, out result))
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Input invalid, please re-enter!");
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Program: Delete Element in Array");
            Console.WriteLine("Please declare an array");
            Console.WriteLine("Enter the number of elements in the array: ");
            int numElement = in_put();
            //declare an new Array
            int[] arr = new int[numElement];
            Console.WriteLine("Enter the value of elements in the array: ");
            for(int i = 0; i < numElement; i++)
            {
                arr[i] = in_put();
            }

            show_arr(arr);
            Console.WriteLine("Enter value want to delete: ");
            int valueDelete = in_put();
            delete_arr(arr, valueDelete);
        }
    }
}
