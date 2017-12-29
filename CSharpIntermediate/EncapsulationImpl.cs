using System;

namespace CSharpIntermediate
{
    public class EncapsulationImpl
    {
        //this class creates instances of employees
        private int _Age;
        private string _Name;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public void GetPayCheck()
        {
            Age = 52;
            Name = "Sathish";
            Console.WriteLine("Age: " + Age);
        }
    }
}
