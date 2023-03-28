using FibonacciLib;

namespace FibonacciCSharp
{
    public sealed class FibonacciUser
    {
        private const int StartValue1 = 1;
        private const int StartValue2 = 2;
        private const int MaxElements = 20;

        private readonly IFibonacci fibonacci;

        public FibonacciUser(IFibonacci fibonacci)
        {
            this.fibonacci = fibonacci ?? throw new ArgumentNullException(nameof(fibonacci));
        }

        public IEnumerable<int> TestRun()
        {
            return fibonacci.Run(StartValue1, StartValue2, MaxElements);
        }
    }
}
