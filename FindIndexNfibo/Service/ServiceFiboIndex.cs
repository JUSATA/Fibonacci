using FindIndexNfibo.Model;

namespace FindIndexNfibo.Service
{
    public interface IFiboService
    {
        CalculeIndexvalue CalculateFibonacci(int n);
    }

    public class FibonacciService : IFiboService
    {
        public CalculeIndexvalue CalculateFibonacci(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Index must be a positive number.");
            }

            int prev1 = 0;
            int prev2 = 1;
            int current = 0;

            for (int i = 2; i <= n; i++)
            {
                current = prev1 + prev2;
                prev1 = prev2;
                prev2 = current;
            }

            return new CalculeIndexvalue { Index = n, Value = current };
        }
    }


}
