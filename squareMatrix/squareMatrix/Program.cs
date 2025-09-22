using System;

namespace squareMatrix
{
    class Program
    {
        public static double sum_main_diagonal(double[,] x)
        {
            double sum = 0;
            for(int i = 0; i < x.GetLength(0); i++)
            {
                for(int j = 0; j < x.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        sum = sum + x[i, j];
                    }
                }
            }
            return sum;
        }
        public static void show_matrix(double[,] x)
        {
            for(int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public static double in_put()
        {
            bool check = false;
            string x = "";
            double result = 0;
            while (!check)
            {
                x = Console.ReadLine();
                if (double.TryParse(x, out result))
                {
                    check = true;
                }
                else
                    Console.WriteLine("Input invalid, please re-enter value!");
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Program: Sum of numbers on main diagonal of square matrix ");
            Console.WriteLine("Enter the column number of the square matrix: ");
            //initialization square matrix
            int col = (int)in_put();
            double[,] matrix = new double[col, col];
            show_matrix(matrix);
            //Enter column values and row values
            Console.WriteLine("Enter the column values and the row values: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = in_put();
                }
                Console.WriteLine();
            }
            show_matrix(matrix);
            double sum = sum_main_diagonal(matrix);
            Console.WriteLine("Sum of the numbers on main diagonal of square matrix is: " + sum);

        }
    }
}