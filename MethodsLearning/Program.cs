using System;
using System.Collections;

namespace MethodsLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int[] input =
            {
                1, 2, 3, 4
            };
            /*
             * LABEL: CODE-SMELL
             * 
             * This is kind of weird even with the use of ref modifier
             * i thought the other way but ref doesn't do much big. 
             * Teacher opinion: "code smell"
            int num = input[3];
            input[3] = 5;
            */
            int result = calculator.Add(input);
            Console.WriteLine("Result: " + result);
            
            var paramsModifier = new ParamsModifierImpl();
            result = paramsModifier.AddItems(1, 2, 3, 4, 5);
            Console.WriteLine("Param modifier implementation result: " + result);

            Console.WriteLine("ref modifier test: ");
//            result = calculator.MultiplyByTwo(ref num); // goto CODE-SMELL
            calculator.MultiplyByTwo(ref input[3]); // goto CODE-SMELL
            Console.WriteLine("{0} * 2 = {1}",input[3],result);
            Console.WriteLine("out modifier test: ");
            Console.WriteLine("Result: " + calculator.ReturnResult(out input[3]));

            var methodOverload = new MethodOverloading(40,60);
            methodOverload.Move(methodOverload);
            Console.WriteLine("Moved to location: ({0}, {1})", methodOverload.x, methodOverload.y);
            methodOverload.Move(new MethodOverloading(100,200));
            Console.WriteLine("Moved to location: ({0}, {1})", methodOverload.x, methodOverload.y);
            methodOverload.Move(null);
            Console.WriteLine("Are we reaching here??");

            //String to Numeric value test
            StringToNumberImpl.StringToNum("abc");
        }
    }
}
