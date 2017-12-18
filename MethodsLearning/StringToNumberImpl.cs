using System;
using System.Runtime.InteropServices;

namespace MethodsLearning
{
    public class StringToNumberImpl
    {
        public static void StringToNum(string name)
        {
            //from the tutorial there are two ways we can do this
            //            int result = int.Parse(name);

            int result = 0;

            //1-way
            try
            {
                result = int.Parse(name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
//                throw;
            }

            //2nd - way
            var parseResult = int.TryParse(name, out result);
            if (parseResult)
                Console.WriteLine(result);
            else
                Console.WriteLine("Conversion failed!!");
        }
    }
}