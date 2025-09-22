using System;

namespace TwoDimensionArray
{
    class Program
    {
        public static void max_value(int[,] x)
        {
            int max = x[0, 0];
            int i_max = 0;
            int j_max= 0;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    if (x[i,j] > max)
                    {
                        max = x[i,j];
                        i_max = i;
                        j_max = j;
                    }
                    else
                        continue;
                }
            }
            Console.WriteLine("Maxtrix has a max value is " + max +" in row " + i_max + " and column " + j_max);
  
        }
        public static void show_matrix(int[,] x)
        {
            for(int i = 0; i < x.GetLength(0); i++)
            {
                for(int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int in_put()
        {
            bool check = false;
            string x = "";
            int result = 0;
            while (!check) {
                x = Console.ReadLine();
                if(int.TryParse(x, out result))
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Input invalid, please re-enter! ");
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Program: Two-DimensionalArray");
            Console.WriteLine("Enter number of Row: ");
            int row1 = in_put();
            Console.WriteLine("Enter number of Column: ");
            int col1 = in_put();
            //Initialize 2D matrix
            int[,] matrix1 = new int[row1,col1];
            show_matrix(matrix1);
            //Enter Values for the matrix
            Console.WriteLine("Enter values in the matrix");
            for(int i = 0; i< matrix1.GetLength(0); i++)
            {
                for (int j = 0;j < matrix1.GetLength(1); j++)
                {
                    matrix1[i,j] = in_put();
                   
                }
                Console.WriteLine();
            }
            show_matrix(matrix1);
            max_value(matrix1);
        }
    }
}