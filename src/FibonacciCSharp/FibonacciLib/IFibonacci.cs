namespace FibonacciLib
{
    public interface IFibonacci
    {
        IEnumerable<int> Run(int value1, int value2, int count);
    }
}
