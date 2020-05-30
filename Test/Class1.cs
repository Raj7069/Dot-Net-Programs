using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Class1
    {
            public static void Main(string[] args)
            {
                Program cp = new Program();
                string file1 = @"e:\1.txt";
                string file2 = @"e:\2.txt";
                cp.copyFile(file1, file2);
            }

        
    }
}
