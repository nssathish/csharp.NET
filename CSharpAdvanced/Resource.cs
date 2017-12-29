using System;

namespace CSharpAdvanced
{
    public class Resource : IDisposable
    {
        public Resource()
        {
            Console.WriteLine("Resource class constructor");
        }
        private bool _isClosed = false;
        protected virtual void Close()
        {
            Console.WriteLine("Base resource closer called!!");
        }

        ~Resource() {
            Dispose();
        }
        public void Dispose()
        {
            if(!_isClosed)
            {
                Console.WriteLine("Disposing resource and calling the Close() method");
                _isClosed = true;
                Close();
            }
        }
    }

    public class AnotherTypeOfResource : Resource
    {
        public AnotherTypeOfResource() : base()
        {

        }
        protected override void Close()
        {
            Console.WriteLine("Another type of resource closer called");
        }
    }
}