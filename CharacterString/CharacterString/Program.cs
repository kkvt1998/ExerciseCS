using System;

namespace CharacterString
{
    class Program
    {
        public static int count_character(string x, string a)
        {
            int count = 0;
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] == Convert.ToChar(a))
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Program: count of the number character in a string");
            Console.WriteLine("Enter a sentence: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the character to find: ");
            string char_count = Console.ReadLine();
            int count = count_character(str, char_count);
            Console.WriteLine("Character " + char_count + " appears " + count + " times"); 
        }
    }
}