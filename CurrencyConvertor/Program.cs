using System;

namespace CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Enter the Currency in Rupee : ");
            double currency = double.Parse(Console.ReadLine());
            Console.WriteLine("You enter amount:- "+currency+ '\u20B9' + " and equivalent output is:- " + currency / 71.42 +'\u0024');
            Console.WriteLine("You enter amount:- " + currency + '\u20B9' + " and equivalent output is:- " + currency / 0.68 + '\u00A5');
            Console.WriteLine("You enter amount:- " + currency + '\u20B9' + " and equivalent output is:- " + currency / 82.84 + '\u20AC');
            Console.ReadKey();
            Console.Read();
        }
    }
}
