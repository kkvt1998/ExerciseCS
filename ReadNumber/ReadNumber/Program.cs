using System;

namespace ReadNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program: Read your number");
            Console.WriteLine("Enter your number: ");
            int num;
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your number is: " + num);
            if( 0 <= num && num < 1000)
            {
                //declare variables
                int hundreds, tens, units;
                string strHundreds = "", strTens = "", strUnits = "";
                // caculate hundreds
                hundreds = num / 100;
                switch (hundreds)
                {
                    case 1:
                        strHundreds = "One hundred";
                        break;
                    case 2:
                        strHundreds = "Two hundred";
                        break;
                    case 3:
                        strHundreds = "Three hundred";
                        break;
                    case 4:
                        strHundreds = "Four hundred";
                        break;
                    case 5:
                        strHundreds = "Five hundred";
                        break;
                    case 6:
                        strHundreds = "Six hundred";
                        break;
                    case 7:
                        strHundreds = "Seven hundred";
                        break;
                    case 8:
                        strHundreds = "Eight hundred";
                        break;
                    case 9:
                        strHundreds = "Nine hundred";
                        break;
                    default:
                        strHundreds = "";
                        break;
                }
                tens = (num % 100) / 10; 
                units = (num % 100) % 10;
                if (tens == 0)
                {
                    switch (units)
                    {
                        case 1:
                            strUnits = "One";
                            break;
                        case 2:
                            strUnits = "Two";
                            break;
                        case 3:
                            strUnits = "Three";
                            break;
                        case 4:
                            strUnits = "Four";
                            break;
                        case 5:
                            strUnits = "Five";
                            break;
                        case 6:
                            strUnits = "Six";
                            break;
                        case 7:
                            strUnits = "Seven";
                            break;
                        case 8:
                            strUnits = "Eight";
                            break;
                        case 9:
                            strUnits = "Nine";
                            break;
                        default:
                            strUnits = "";
                            break;
                    }
                    strTens = "";
                }
                else if(tens == 1)
                {
                    strUnits = "";
                    switch (tens)
                    {
                        case 10:
                            strTens = "Ten";
                            break;
                        case 11:
                            strTens = "Eleven";
                            break;
                        case 12:
                            strTens = "Twelve";
                            break;
                        case 13:
                            strTens = "Thirteen";
                            break;
                        case 14:
                            strTens = "Fourteen";
                            break;
                        case 15:
                            strTens = "Fifteen";
                            break;
                        case 16:
                            strTens = "Sixteen";
                            break;
                        case 17:
                            strTens = "Seventeen";
                            break;
                        case 18:
                            strTens = "Eighteen";
                            break;
                        case 19:
                            strTens = "Nineteen";
                            break;
                        default:
                            strTens = "";
                            break;

                    }
                }
                else if(tens > 1) {
                    switch (tens)
                    {
                        case 2:
                            strTens = "Twenty";
                            break;
                        case 3:
                            strTens = "Thirty";
                            break;
                        case 4:
                            strTens = "Forty";
                            break;
                        case 5:
                            strTens = "Fifty";
                            break;
                        case 6:
                            strTens = "Sixty";
                            break;
                        case 7:
                            strTens = "Seventy";
                            break;
                        case 8:
                            strTens = "Eighty";
                            break;
                        case 9:
                            strTens = "Ninety";
                            break;
                        default:
                            strTens = "";
                            break;
                    }
                    switch (units)
                    {
                        case 1:
                            strUnits = "One";
                            break;
                        case 2:
                            strUnits = "Two";
                            break;
                        case 3:
                            strUnits = "Three";
                            break;
                        case 4:
                            strUnits = "Four";
                            break;
                        case 5:
                            strUnits = "Five";
                            break;
                        case 6:
                            strUnits = "Six";
                            break;
                        case 7:
                            strUnits = "Seven";
                            break;
                        case 8:
                            strUnits = "Eight";
                            break;
                        case 9:
                            strUnits = "Nine";
                            break;
                        default:
                            strUnits = "";
                            break;
                    }
                }
                Console.WriteLine("Hundreds: " + strHundreds);
                Console.WriteLine("Tens: " + strTens);
                Console.WriteLine("Units: " + strUnits);

                string result = strHundreds + " and " + strTens + " " + strUnits;
                Console.WriteLine("Your number is read: " + result);
            }
            else
            {
                Console.WriteLine("Your number is out of range 0 - 999");
            }

        }
    }
}