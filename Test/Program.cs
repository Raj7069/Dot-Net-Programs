using System;

namespace Test
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    class Ractangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Ractangle r = new Ractangle();
            r.setHeight(5);
            r.setWidth(6);
            Console.WriteLine(r.getArea());
            Console.ReadKey();
            int x = 42;
            int y = 12;
            int w;
            object o;
            o = x;
            w = y * (int)o;
            Console.WriteLine(w);
        }
    }
}
