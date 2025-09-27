using System;

namespace mineSweeper
{
    class Program
    {
        //input method
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
                    Console.WriteLine("Input invalid, please re-enter");
                }
            }
            return result;
        }
        //create a random matrix map
        public static string[,] mineMap(int x, int y)
        {
            Random rand = new Random();
            int[,] map1 = new int[x, y];
            string[,] map2 = new string[x,y];
            for (int i = 0; i < map1.GetLength(0); i++)
            {
                for(int j = 0; j < map1.GetLength(1); j++)
                {
                    map1[i, j] = rand.Next(5);
                    if(map1[i, j] == 0)
                    {
                        map2[i, j] = "*";
                    }
                    else
                    {
                        map2[i, j] = ".";
                    }
                }
            }
            return map2;
        }
        public static void findMine(string[,] x)
        {
            string result = "";
            for(int i = 0;i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    result = count(x, i, j).ToString();
                    if(result == "0" && x[i,j] != ".")
                    {
                        result = "*";
                    }
                    Console.Write(result + " ");  
                }
                Console.WriteLine();
            }

        }
        public static int count(string[,] x, int row, int col)
        {
            int count = 0;
            if (x[row, col] == "*")
            {
                count = 0;
            }
            else
            {
                for(int i = -1; i < 2; i++)
                {
                    for(int j = -1; j < 2; j++)
                    {
                        if(row + i >= 0 && row + i < x.GetLength(0) && col + j >= 0 && col + j < x.GetLength(1))
                        if (x[row + i, col + j] == "*")
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        public static void show_map(string[,] x)
        {
            for (int i = 0;i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Program: Mine Sweeper");

            Console.WriteLine("Enter the size width of the map");
            int map_size_width = in_put();
            Console.WriteLine("Enter the size height of the map");
            int map_size_height = in_put();
            string[,]mine_map = mineMap(map_size_height, map_size_width);
            Console.WriteLine("Create a random map with Mine");
            //show Mine Map
            show_map(mine_map);
            Console.WriteLine("Show Mine sweeper Map");
            findMine(mine_map);
            
        }
    }
}