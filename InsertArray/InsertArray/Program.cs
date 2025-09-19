using System;

namespace InsertArray
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
                    Console.WriteLine("Invalid value, please re-enter!");
                }
            }
            return result;
        }
        public static void showArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("Program: Insert in Array");
            bool access = false;
            int[] Arr = {};
            Console.WriteLine(Arr.Length);
            while (!access)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Declare an Array");
                Console.WriteLine("2. Insert value in Array");
                Console.WriteLine("3. Exit");
                int choose = in_put();
                if (choose == 1)
                {
                    Console.WriteLine("Enter the number of elements in the array: ");
                    int numberArr = in_put();
                    Arr = new int[numberArr];
                    for (int i = 0; i < numberArr; i++)
                    {
                        Console.Write("Enter the elements of the array: ");
                        int elementArr = in_put();
                        Arr[i] = elementArr;
                    }
                    Console.WriteLine("Array is: ");
                    showArr(Arr);


                }
                else if(choose == 2)
                {
                    if(Arr.Length != 0)
                    {
                        int[] ArrCopy = {};
                        bool checkIndex = false;
                        while (!checkIndex)
                        {
                            Console.WriteLine("Enter value to insert into array: ");
                            int valueInsert = in_put();
                            Console.WriteLine("Enter index to insert into array: ");
                            int indexInsert = in_put();
                            if (indexInsert <= Arr.Length)
                            {
                                ArrCopy = new int[Arr.Length + 1];
                                for (int i = 0; i < indexInsert; i++)
                                {
                                    ArrCopy[i] = Arr[i];
                                }
                                ArrCopy[indexInsert] = valueInsert;
                                for (int i = indexInsert; i < Arr.Length; i++)
                                {
                                    ArrCopy[i + 1] = Arr[i];
                                }
                                checkIndex = true;

                            }
                            else
                            {
                                Console.WriteLine("index is out of range Array!");
                            }
                        }
                        Console.WriteLine("Array is: ");
                        showArr(ArrCopy);
                        
                    }
                    else
                    {
                        Console.WriteLine("Please declare an Array");
                    }
                    
                }
                else if (choose == 3) {
                    access = true;
                }

            }
        }
    }
}