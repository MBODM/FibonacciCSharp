namespace FibonacciLib
{
    public sealed class Fibonacci : IFibonacci
    {
        public IEnumerable<int> Run(int value1, int value2, int count)
        {
            var result = new List<int> { value1, value2 };

            int value3;

            for (int i = 1; i <= count; i++)
            {
                value3 = value1 + value2;

                result.Add(value3);

                value1 = value2;
                value2 = value3;
            }

            return result;
        }
    }
}
