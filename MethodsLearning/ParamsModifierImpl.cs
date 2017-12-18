namespace MethodsLearning
{
    public class ParamsModifierImpl
    {
        public int AddItems( params int[] numbers)
        {
            int result = 0;
/*            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }*/

            //Using foreach now
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }
    }
}