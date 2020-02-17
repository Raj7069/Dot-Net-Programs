using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Re
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Country;
            do{
            Console.WriteLine("Please, Enter your Name:-");
            Name = Console.ReadLine();
            }while(!Regex.IsMatch(Name,"^[a-zA-Z]+$"));

            do{
                Console.WriteLine("Please, Enter your Country:-");
                Country = Console.ReadLine();

            }while(!Regex.IsMatch(Country,"^[a-zA-Z]+$"));

            Console.WriteLine("Hello, Your Name is "+Name+" and you from Country "+Country);
            Console.Read();
        }
    }
}
