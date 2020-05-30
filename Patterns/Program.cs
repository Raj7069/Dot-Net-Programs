using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern1();     //pattern 1
            pattern2();     //pattern 2
            pattern3();     //pattern 3
            pattern4();     //pattern 4
        }

        static void pattern1()
        {
            Console.WriteLine("pattern 1");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void pattern2()
        {
            Console.WriteLine("pattern 2");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void pattern3()
        {
            Console.WriteLine("pattern 3");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void pattern4()
        {
            Console.WriteLine("pattern 4");
            for (int i = 5; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Read();
        }


    }

}