using System;
namespace MaxValue
{
    class Program
    {
        public static string in_put()
        {
            string x = "";
            bool access = false;
            while (!access)
            {   
                x = Console.ReadLine();
                if (int.TryParse(x, out int result)){
                    access = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program: Top billionaire");
            //Khai bao so luong ty phu
            int n = 0;
            bool size = false;
            while (!size)
            {
                Console.Write("Enter the number of billionaires: ");
                n = int.Parse(in_put());
                if ( n > 20)
                {
                    Console.WriteLine("Max of billionaires is 20. Please enter again.");
                }
                else
                {
                    size = true;
                }
                  
            }
            int[] billionaires = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter the wealth of billionaire " + i + ": ");
                billionaires[i] = int.Parse(in_put());
            }
            //Xu ly yeu cau bai toan
            //in ra danh sach tai san
            Console.Write("List of billionaires: ");
            foreach (int i in billionaires)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //tim ty phu giau nhat
            int maxBillionaire = billionaires[0];
            int index = 0;
            for (int i = 1; i < n; i++)
            {
                if (billionaires[i] > maxBillionaire)
                {
                    maxBillionaire = billionaires[i];
                    index = i;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("The richest billionaire is billionaire " + (index + 1)  + " with wealth: " + maxBillionaire);

        }
    }
}