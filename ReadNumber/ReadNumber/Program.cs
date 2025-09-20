using System;

namespace ReadNumber
{
    class Program
    {
        public static string units(int unit)
        {
            string resultUnit = " ";
            switch (unit)
            {
                case 1:
                    resultUnit = "one";
                    break;
                case 2:
                    resultUnit = "two";
                    break;
                case 3:
                    resultUnit = "three";
                    break;
                case 4:
                    resultUnit = "four";
                    break;
                case 5:
                    resultUnit = "five";
                    break;
                case 6:
                    resultUnit = "six";
                    break;
                case 7:
                    resultUnit = "seven";
                    break;
                case 8:
                    resultUnit = "eight";
                    break;
                case 9:
                    resultUnit = "nine";
                    break;
                default:
                    resultUnit = "";
                    break;
            }
            return resultUnit;
        }
        public static string tens(int ten, int unit)
        {
            string resultTens = "";
            if (ten == 0)
            {
                units(unit);
            }
            else if (ten == 1)
            {
                switch (unit)
                {
                    case 0:
                        resultTens = "ten";
                        break;
                    case 1:
                        resultTens = "eleven";
                        break;
                    case 2:
                        resultTens = "twelve";
                        break;
                    case 3:
                        resultTens = "thirteen";
                        break;
                    case 4:
                        resultTens = "forteen";
                        break;
                    case 5:
                        resultTens = "fifteen";
                        break;
                    case 6:
                        resultTens = "sixteen";
                        break;
                    case 7:
                        resultTens = "seventeen";
                        break;
                    case 8:
                        resultTens = "eightteen";
                        break;
                    case 9:
                        resultTens = "nineteen";
                        break;
                    default:
                        resultTens = "";
                        break;
                }
            }
            else
            {
                switch (ten)
                {
                    case 2:
                        resultTens = "twenty";
                        break;
                    case 3:
                        resultTens = "thirty";
                        break;
                    case 4:
                        resultTens = "forty";
                        break;
                    case 5:
                        resultTens = "fifty";
                        break;
                    case 6:
                        resultTens = "sixty";
                        break;
                    case 7:
                        resultTens = "seventy";
                        break;
                    case 8:
                        resultTens = "eightty";
                        break;
                    case 9:
                        resultTens = "ninety";
                        break;
                    default:
                        resultTens = "";
                        break;
                }
            }
            return resultTens;
        }
        public static string hundreds(int hundred)
        {
            string resultHundred = "";
            if (hundred != 0)
            {
                resultHundred = units(hundred) + " hundred";
            }
            return resultHundred;   
        }
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
         static void Main(string[] args)
            {
                Console.WriteLine("Program: Read your number");
                Console.WriteLine("Enter your number: ");
                int num = in_put();
                Console.WriteLine("Your number is: " + num);
                if (0 <= num && num < 1000)
                {
                    //declare variables
                    string strHundreds = "", strTens = "", strUnits = "";
                // caculate hundreds
                    int hundred = num / 100,
                        ten = (num % 100)/10,
                        unit = (num % 100) % 10;

      
                    strHundreds = hundreds(hundred);
                    strTens = tens(ten, unit);
                    strUnits = units(unit);
                    if(ten == 1)
                    {
                    Console.WriteLine(strHundreds + " and " + strTens);
                    }
                    else
                    {
                    Console.WriteLine(strHundreds + " and " + strTens + " " + strUnits);
                    }
                }
                else
                {
                    Console.WriteLine("Your number is out of range 0 - 999");
                }

            }
        }
}