using System;
namespace InterfacesImpl
{
    struct PersonDataStructure
    {
        public string name;
        public DateTime dob;
        public int heightInCm;
        public int weightInKg;
    }

    public class StructImpl
    {
        public void PlayStruct()
        {
            PersonDataStructure person = new PersonDataStructure()
            {
                name = "caasi",
                dob = new DateTime(1987, 2, 25),
                heightInCm = 160,
                weightInKg = 55
            };
            
            //or
            //this can be done like person.name = 'master'
            //person.dob = '10-12-1988' and so on
            if (person.dob < DateTime.Now)
            {
                Console.WriteLine("Name: {0} dob: {1} height: {2} weight: {3}", person.name,person.dob,person.heightInCm,person.weightInKg);
            }
        }
    }
}