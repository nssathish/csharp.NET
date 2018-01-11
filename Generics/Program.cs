using System;

namespace Generics
{
    public static class MyExtensions
    {
        public static string[] ToStringArray<T>(this T[] array)
        {
            string[] newArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i].ToString();
            }

            return newArray;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SomeObjectContainer container1 = new SomeObjectContainer(25);
            SomeObjectContainer container2 = new SomeObjectContainer(5);

            Console.WriteLine("Container 1 has : {0}", (int)container1.GetObject());
            Console.WriteLine("Container 2 has : {0}", (int)container2.GetObject());

            GenericObjectContainer<int> gContainer1 = new GenericObjectContainer<int>(10);
            GenericObjectContainer<string> gContainer2 = new GenericObjectContainer<string>("Sathish");

            Console.WriteLine("gcontainer1 val: {0}", gContainer1.getObject());
            Console.WriteLine("gcontainer2 val: {0}", gContainer2.getObject());


            IntegerClassImpl ici = new IntegerClassImpl();
            ici.SetObject(10);

            StringClassImpl sci = new StringClassImpl();
            sci.SetObject("Kumar");

            Console.WriteLine("Integer class implementation: obj = {0}", ici.GetObject());
            Console.WriteLine("String class implementation: obj = {0}", sci.GetObject());

            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Is {0} existing?  {1}", 2, GenericMethodImpl.ArrayContains<int>(array, 2));
            Console.WriteLine("Is {0} existing?  {1}", 100, GenericMethodImpl.ArrayContains<int>(array, 100));

            //Extension method - new feature in C# 3.0
            // 1. The extension method should be defined in a static class
            // 2. The extension method should be a static method
            // 3. The first parameter should be preceded by the 'this' keyword
            string[] list = { "sathish", "thish", "kumar", "kum", "ar" };
            list = list.ToStringArray<string>();
            Console.WriteLine("Extension method:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}