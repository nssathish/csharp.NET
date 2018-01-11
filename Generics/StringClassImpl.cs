namespace Generics
{
    public class StringClassImpl : IContainer<string>
    {
        private string _obj;

        public string GetObject()
        {
            return _obj;
        }

        public void SetObject(string obj)
        {
            _obj = obj;
        }
    }
}
