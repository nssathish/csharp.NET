using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte height = 4;
            byte breadth = 4;
            byte area = (byte) ((int)height + (int) breadth);

            Console.WriteLine("area by byte: " + area);
            int a = 4;
            int b = 4;
            int c = a + b;

            float d = 1.2f;
            float e = 2.4f;

            float f = d + e;
            Console.WriteLine("f: " + f);
            Console.WriteLine("c: " + c);
            Console.WriteLine("Hello World!");
            checked
            {
                height = 255;
                height += 1;
            }
            Console.WriteLine("Height: " + height);
        }
    }
}
