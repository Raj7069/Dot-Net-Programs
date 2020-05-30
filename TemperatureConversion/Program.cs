using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("<-----Temperature Conversion----->");
            Console.WriteLine("1. Celsius To Fahrenheit \n2. Fahrenheit To Celsius \n3. Celsius To Kelvin");
            Console.WriteLine("Enter your choice:-");
            int choice = int.Parse(Console.ReadLine());
            double celsius, fahrenheit,kelvin;
            switch (choice)
            {
                case 1: 
                    Console.WriteLine("Enter the temperature in celsius");
                    celsius = double.Parse(Console.ReadLine());
                    fahrenheit = (celsius * (9.0 / 5.0)) + 32;
                    Console.WriteLine("The enterd temperature is:- "  + celsius + '̊' + "C And converted temperature is:- " + fahrenheit + '̊' +"F");
                    break;

                case 2:
                    Console.WriteLine("Enter the temperature in fahrenheit");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32.0) *(5.0/9.0);
                    Console.WriteLine("The enterd temperature is:- " + fahrenheit + '̊' + "F And converted temperature is:- " + celsius + '̊' + "C");
                    break;

                case 3:
                    Console.WriteLine("Enter the temperature in celsius");
                    celsius = double.Parse(Console.ReadLine());
                    kelvin = (celsius + 273.15);
                    Console.WriteLine("The enterd temperature is:- " + celsius + '̊' + "C And converted temperature is:- " + kelvin + "K");
                    break;

                default:
                    Console.WriteLine("Invalid choice!!!");
                    break;
            }
            Console.Read();
        }
    }
}
