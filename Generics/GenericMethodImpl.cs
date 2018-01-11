namespace Generics
{
    public class GenericMethodImpl
    {
        public static bool ArrayContains<T>(T[] array, T obj)
        {
            foreach (var item in array)
            {
                if (item.Equals(obj))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
