using System;
delegate void Procedure();

namespace EventsAndDeligates
{
    public class DelegateDemo
    {
        public static void Method1()
        {
            Console.WriteLine("Inside Method1");
        }

        public static void Method2()
        {
            Console.WriteLine("inside Method2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Procedure someProcedures = null;
            someProcedures += new Procedure(DelegateDemo.Method1);
            //CODE-SMELL 
            //The below '-=' is a code smell if we do not know when to use it
            // if any other delegate object in the middle of the process added
            // the medthod to the delegate the '-=' can be used to remvoe that
            // method. Until then unnecessarily adding method to the deleage is
            // a code smell
            //someProcedures -= new Procedure(DelegateDemo.Method2);

            someProcedures();
        }
    }
}
