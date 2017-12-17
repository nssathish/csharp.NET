using System;

namespace MethodsLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new calculator();
            int[] input =
            {
                1, 2, 3, 4
            };
            ;
            int result = calculator.Add(input);
            Console.WriteLine("Result: " + result);
            
            var paramsModifier = new ParamsModifierImpl();
            result = paramsModifier.AddItems(1, 2, 3, 4, 5);
            Console.WriteLine("Param modifier implementation result: " + result);
        }
    }
}
