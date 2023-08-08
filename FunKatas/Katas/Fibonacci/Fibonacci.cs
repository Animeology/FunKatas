namespace FunKatas.Katas.Fibonacci
{
    public class Fibonacci
    {
        public void PrintFibonacci()
        {
            Console.WriteLine(FibonacciKata(10));
        }

        int FibonacciKata(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            if (num == 1 || num == 2)
            {
                return 1;
            }
            else
            {
                return FibonacciKata(num - 1) + FibonacciKata(num - 2);
            }
        }
    }
}
