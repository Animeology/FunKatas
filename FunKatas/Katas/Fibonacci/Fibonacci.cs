namespace FunKatas.Katas.Fibonacci
{
    using KataTest.FibonacciTests;    

    public class Fibonacci
    {
        public void PrintFibonacci()
        {
            FibonacciTests tests = new FibonacciTests();
            tests.Fibonacci_ForNumber10();
            Console.WriteLine(FibonacciKata(10));
        }

        public int FibonacciKata(int num)
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
