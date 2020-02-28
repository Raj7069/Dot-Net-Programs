using System;

namespace InfixToPostfix
{
    class class1
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter infix string: ");
            string infix = Console.ReadLine();
            string postfix;
            Program converter = new Program();
            converter.infixtopostfix(infix, out postfix); 
            Console.WriteLine("\nInfix Expression is: " + infix);
            Console.WriteLine("Postfix Expression is: " + postfix);
            Console.ReadKey();
        }
    }
}
