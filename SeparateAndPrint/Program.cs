using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaparateAndPrint
{
    class Program
    {
        private static string singleDigit(string number)
        {
            switch (number)
            {
                case "0": return "zero"; break;
                case "1": return "one"; break;
                case "2": return "two"; break;
                case "3": return "three"; break;
                case "4": return "four"; break;
                case "5": return "five"; break;
                case "6": return "six"; break;
                case "7": return "seven"; break;
                case "8": return "eight"; break;
                case "9": return "nine"; break;                
                default: return "Invalid";break;
            }
        }

        private static string doubleDigit(string number)
        {
            string output;
            if (number == "00")
                return "zero";
            else if(number[0] == '0')
            {
                output = singleDigit(number[1].ToString());
            }
            else if (number[0] == '1')
            {
                switch (number)
                {
                    case "10": output = "ten"; break;
                    case "11": output = "eleven"; break;
                    case "12": output = "twelve"; break;
                    case "13": output = "thirteen"; break;
                    case "14": output = "fourteen"; break;
                    case "15": output = "fifteen"; break;
                    case "16": output = "sixteen"; break;
                    case "17": output = "seventeen"; break;
                    case "18": output = "eighteen"; break;
                    case "19": output = "nineteen"; break;
                    case "20": output = "twenty"; break;
                    default: output = "not assigned"; break;
                }
            }
            else if(number[0] == '2')
            {
                output = "twenty " + singleDigit(number[1].ToString());
            }
            else if (number[0] == '3')
            {
                output = "thirty " + singleDigit(number[1].ToString());
            }
            else if (number[0] == '4')
            {
                output = "fourty " + singleDigit(number[1].ToString());
            }
            else if (number[0] == '5')
            {
                output = "fifty " + singleDigit(number[1].ToString());
            }
            else if (number[0] == '6')
            {
                output = "sixty " + singleDigit(number[1].ToString());
            }
            else if (number[0] == '7')
            {
                output = "seventy " + singleDigit(number[1].ToString());
            }
            else if (number[0] == '8')
            {
                output = "eighty " + singleDigit(number[1].ToString());
            }
            else if (number[0] == '9')
            {
                output = "ninety " + singleDigit(number[1].ToString());
            }
            else
            {
                output = "Invalid";
            }
            return output;
        }

        private static string triDigit(string number)
        {
            string output;
            if (number == "000")
                return "zero";
            else if (number[0] == '0' && number[1] == '0')
                output = singleDigit(number[2].ToString());
            else if (number[0] == '0')
            {
                string num = number.Substring(1, 2);
                output = doubleDigit(num);
            }
            else
            {
                string num = number.Substring(1, 2);
                output = singleDigit(number[0].ToString()) + " hundred " + doubleDigit(num);
            }
            return output;
        }
        

        private static string tetraDigit(string number)
        {
            string output, num;
            if (number == "0000")
                return "zero";
            else if(number[0] == '0' && number[1] == '0' && number[2] == '0')
            {
                output = singleDigit(number[3].ToString());
            }
            else if (number[0] == '0' && number[1] == '0')
            {
                num = number.Substring(2, 2);
                output = doubleDigit(num);
            }
            else if (number[0] == '0')
            {
                num = number.Substring(1, 3);
                output = triDigit(num);
            }
            else
            {
                num = number.Substring(1, 3);
                output = singleDigit(number[0].ToString()) + " thousand " + triDigit(num);
            }
            return output;
        }
        private static string pentaDigit(string number)
        {
            string output,num;
            if (number == "00000")
                return "zero";
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0')
                output = singleDigit(number[4].ToString());
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0')
            {
                num = number.Substring(3, 2);
                output = doubleDigit(num.ToString());
            }
            else if (number[0] == '0' && number[1] == '0')
            {
                num = number.Substring(2, 3);
                output = triDigit(num.ToString());
            }
            else if (number[0] == '0')
            {
                num = number.Substring(1, 4);
                output = tetraDigit(num.ToString());
            }
            else
            {
                num = number.Substring(2, 3);
                string num1 = number.Substring(0, 2);
                output = doubleDigit(num1) + " thousand " + triDigit(num1);
            }
            return output;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number between 0-10000");
            string number = Console.ReadLine();
            string output;
            int len = number.Length;
            switch (len)
            {
                case 1: output = singleDigit(number);
                    break;
                case 2: output = doubleDigit(number);
                    break;
                case 3: output = triDigit(number);
                    break;
                case 4:
                    output = tetraDigit(number);
                    break;
                //case 5: output = pentaDigit(number);
                //    Break;
                default: output= "Invalid input";
                    break;
            }
            Console.WriteLine(output);
            Console.Read();
        }
    }
}
