using System;

namespace LearningCSharp
{
    public class Person
    {
        public string personName;

        public Person()
        {
            personName = "Orange";
        }

        public Person(string name)
        {
            this.personName = name;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}.. I am {1}", to, personName);
        }
        //public Person clone (string name)
        public static Person clone(string name)
        {
            var personObj = new Person();
            personObj.personName = name;

            return personObj;
        }
    }
}
