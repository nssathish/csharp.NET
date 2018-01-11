namespace Generics
{
    public class GenericObjectContainer<T>
    {
        private T _obj;
        public GenericObjectContainer(T obj)
        {
            this._obj = obj;
        }

        public T getObject()
        {
            return this._obj;
        }
    }
}
