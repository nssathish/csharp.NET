using System;
namespace CSharpAdvanced
{
    public class Employee
    {
        protected virtual void GetPayCheck() => Console.WriteLine("Employee's paycheck method is called");
        public void Work()
        {
            GetPayCheck();
            Console.WriteLine("Base class's Work method is called");
        }
    }

    public class Executive : Employee
    {
        protected override void GetPayCheck() => Console.WriteLine("Executive's Paycheck method is called");
    }
}
