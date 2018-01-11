namespace Generics
{
    public class IntegerClassImpl : IContainer<int>
    {
        private int _obj;

        public int GetObject()
        {
            return this._obj;
        }

        public void SetObject(int obj)
        {
            _obj = obj;
        }
    }
}
