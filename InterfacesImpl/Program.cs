using System;

namespace InterfacesImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalc tc = new TaxCalc(92000.00,7,15,26);

            Console.WriteLine("Gratuity: " + tc.Calculate());

            StackImpl stack = new StackImpl(10);
            int [] collection = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 110 };
            foreach (var item in collection) // directly passing the array like foreach (var item in {1,3,34,5}) not working :(
            {
                stack.Push(item);
            }
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());   //this stack.pop will result in a different result for the queue implementation below
            Console.WriteLine(stack.Peek());

            QueueImpl queueImpl = new QueueImpl(10,stack);
            queueImpl.Peep(); //using a single stack and recursion has another stack to behave it like a queue (I'm weird)
            //if the result for the above peep is not what you expected. (like one less item printed) then comment that stack.pop above

            //Enum implementation
            EnumImpl enumImpl = new EnumImpl();
            enumImpl.PlayEnum();

            //Struct implementation
            StructImpl structImpl = new StructImpl();
            structImpl.PlayStruct();
        }
    }
}
