namespace FunKatas.KataTest.FibonacciTests
{
    using Katas.Fibonacci;

    public class FibonacciTests
    {
        public void Fibonacci_ForNumber10()
        {
            Fibonacci fibonacci = new Fibonacci();

            int insertedNumber = 10;
            int expectedResult = 55;

            if(fibonacci.FibonacciKata(insertedNumber) != expectedResult)
            {
                throw new Exception("Didn't get the correct Fibonacci result");
            }
        }
    }
}
