using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            Console.WriteLine("1. Binary To Decimal\n2. Decimal To Binary\n3. Decimal To HexaDecimal\n4. Decimal To Octal");
            Console.WriteLine("Enter Your Choice:-");
            value = Console.ReadLine();
            int choice = int.Parse(value);
            string num;
            switch (choice)
            {
                case 1: Console.WriteLine("Enter Binary Value:-");
                    num = Console.ReadLine();
                    BinaryToDecimal(num);
                    break;

                case 2: Console.WriteLine("Enter Decimal Value:-");
                    num = Console.ReadLine();
                    DecimalToBinary(num);
                    break;

                case 3: Console.WriteLine("Enter Decimal Value:-");
                    num = Console.ReadLine();
                    DecimalToHexadecimal(num);
                    break;

                case 4:
                    Console.WriteLine("Enter Decimal Value:-");
                    num = Console.ReadLine();
                    DecimalToOctal(num);
                    break;

                default: Console.WriteLine("Sorry! Invalid Number");
                    break;
            }
        }
        static void BinaryToDecimal(string binary)
        {
            int BinaryNumber = int.Parse(binary);
            int DecimalNumber = 0;
            int base1 = 1;
            while(BinaryNumber > 0)
            {
                int Reminder = BinaryNumber % 10;
                BinaryNumber /= 10;
                DecimalNumber += Reminder * base1;
                base1 *= 2;
            }
            Console.WriteLine("Given Binary Value is "+binary+" And Equivqlent Decimal Value is "+DecimalNumber);
            Console.ReadKey();
        }
        static void DecimalToBinary(string Decimal)
        {
            string Binary = "";
            string BinaryResult = "";
            int DecimalValue = int.Parse(Decimal);
            while(DecimalValue > 0)
            {
                Binary += DecimalValue % 2;
                DecimalValue /= 2;
            }
            int length = Binary.Length - 1;
            while(length >= 0)
            {
                BinaryResult += Binary[length];
                length--;
            }
            Console.WriteLine("Given Decimal Value is " + Decimal + " And Equivqlent Binary Value is " + BinaryResult);
            Console.ReadKey();
        }
        static void DecimalToHexadecimal(string Decimal)
        {
            string Hexadecimal = "";
            string Result = "";
            int value = int.Parse(Decimal);
            while (value > 0)
            {
                int ans = value % 16;
                switch (ans)
                {
                    case 10:
                        Hexadecimal += "A";
                        break;
                    case 11:
                        Hexadecimal += "B";
                        break;
                    case 12:
                        Hexadecimal += "C";
                        break;
                    case 13:
                        Hexadecimal += "D";
                        break;
                    case 14:
                        Hexadecimal += "E";
                        break;
                    case 15:
                        Hexadecimal += "F";
                        break;
                    default:
                        Hexadecimal += value % 16;
                        break;
                }
                value /= 16;
            }
            int length = Hexadecimal.Length - 1;
            while (length >= 0)
            {
                Result += Hexadecimal[length];
                length--;
            }
            Console.WriteLine("Given Decimal Value is " + Decimal + " And Equivqlent Hexadecimal Value is " + Result);
            Console.ReadKey();
        }
        static void DecimalToOctal(string Decimal)
        {
            string Octal = "";
            string Result = "";
            int Value = int.Parse(Decimal);
            while (Value > 0)
            {
                Octal += Value % 8;
                Value /= 8;
            }
            int length = Octal.Length - 1;
            while (length >= 0)
            {
                Result += Octal[length];
                length--;
            }
            Console.WriteLine("Given Decimal Value is " + Decimal + " And Equivqlent Octal Value is " + Result);
            Console.ReadKey();
        }
    }
}

