using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class TryCatchDemo
    {
        public void TryCatchSample(string number)
        {
            try
            {
                Console.WriteLine("String --> Boolean conversion: ");
                string str = "true";
                bool isConverted = Convert.ToBoolean(str);
                Console.WriteLine(isConverted);
                Console.WriteLine();
                Console.WriteLine("String --> byte conversion:");
                byte b = Convert.ToByte(number);
                //byte b = (byte)num; // explicit/implicit type conversion not possible here
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number cannot be converted to a byte.");
                Console.WriteLine();
                //throw;
            }
        }
    }
}
