using System;
using System.Runtime.CompilerServices;

namespace MethodsLearning
{
    public class MethodOverloading
    {
        public int x;
        public int y;

        public MethodOverloading(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public void Move(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public void Move(MethodOverloading overLoad)
        {
            try
            {
                if (overLoad == null)
                    throw new ArgumentException("MethodOverloading obj is null");
                Move(overLoad.x, overLoad.y);
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
//                throw;
            }
        }
    }
}