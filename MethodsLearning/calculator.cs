namespace MethodsLearning
{
    public class Calculator
    {
        public int Add(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            return result;
        }

        // public int multiplyByTwo(int num)
        // using the 'ref' modifier
        public void MultiplyByTwo(ref int num)   
        {
            num *= 2;
        }

        // using the 'out' modifier
        // good example could be 'bool' data type
        public int ReturnResult(out int result)
        {
            result = 1;
            return result;
        }
    }
}