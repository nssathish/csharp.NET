namespace Generics
{
    public interface IContainer<T>
    {
        T GetObject();
        void SetObject(T obj);
    }
}
