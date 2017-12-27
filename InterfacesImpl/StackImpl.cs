using System;

namespace InterfacesImpl
{
    class StackImpl : IStack
    {
        public int[] Stack = { };
        public int top;
        public StackImpl(int weight)
        {
            Stack = new int[weight];
            top = -1;
        }
        public int Peek()
        {
            try
            {
                return Stack[top];
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
            }
            return -1;
        }

        public int Pop()
        {
            try
            {
                return Stack[top--];
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message + "Stack empty");
                throw;
            }
        }

        public void Push(int item)
        {
            try
            {
                Stack[++top] = item;
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message + "Stack Overflow");
            }
        }
    }
}