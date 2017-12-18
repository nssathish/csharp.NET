using System;

namespace InterfacesImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalc tc = new TaxCalc(92000.00,7,15,26);

            Console.WriteLine("Gratuity: " + tc.Calculate());
        }
    }
}
