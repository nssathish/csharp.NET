namespace MethodsLearning
{
    public class ParamsModifierImpl
    {
        public int AddItems( params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            return result;
        }
    }
}