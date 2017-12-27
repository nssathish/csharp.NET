using System;

namespace InterfacesImpl
{
    class QueueImpl
    {
        int top;
        int queueWeight;
        StackImpl stackImpl;

        public QueueImpl(int weight, StackImpl stack)
        {
            this.queueWeight = weight;
            this.stackImpl = stack;
            this.top = stackImpl.top;
        }
        public void Peep()
        {
            if (stackImpl.top > 0)
            {
                stackImpl.top--;
                Peep();
            }
            Console.WriteLine(stackImpl.Peek());
            stackImpl.top++;
        }
    }
}
