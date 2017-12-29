using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            var exec = new Executive();
            //employee.Work();
            //exec.Work();

            var res = new Resource();
            var anotherResource = new AnotherTypeOfResource();

            res.Dispose();
            anotherResource.Dispose();
        }
    }
}