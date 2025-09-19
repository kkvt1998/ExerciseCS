using System;

namespace FindValueInArray
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Program: Find Value in Array");
            
            string[] StudentArray = new string[] { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Enter the student's name: ");
            string nameStudent = Console.ReadLine();
            bool checkStudent = false;
            for(int  i = 0; i < StudentArray.Length; i++)
            {
                if (StudentArray[i] == nameStudent)
                {
                    Console.WriteLine("The student " + nameStudent + " is the number " + (i+1));
                    checkStudent = true;
                }
                
            }
            if(checkStudent == false)
            {
                Console.WriteLine("No find the student has the name " + nameStudent);
            }
        }
    }
}