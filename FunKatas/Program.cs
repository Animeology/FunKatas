namespace FunKatas
{
    using FunKatas.Katas.Checkout;
    using Katas;

    public class Program
    {
        static void Main(string[] args) 
        {
            //FizzBuzz fizzBuzz = new FizzBuzz();
            //fizzBuzz.FizzBuzzGame();

            //Fibonacci fibonacci = new Fibonacci();
            //fibonacci.PrintFibonacci();

            CheckoutKata checkout = new CheckoutKata();
            checkout.Checkout();
        }
    }
}
