namespace Generics
{
    public class SomeObjectContainer
    {
        private object _obj;

        public SomeObjectContainer(object obj)
        {
            this._obj = obj;
        }

        public object GetObject()
        {
            return this._obj;
        }
    }
}
