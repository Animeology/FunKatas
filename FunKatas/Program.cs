namespace FunKatas
{
    using Katas.Checkout;
    using Katas.Fibonacci;
    using Katas.FizzBuzz;
    using Katas.String_Calculator;
    using Katas.BowlingGame;

    public class Program
    {
        static void Main(string[] args) 
        {
            //FizzBuzz fizzBuzz = new FizzBuzz();
            //fizzBuzz.FizzBuzzGame();

            //Fibonacci fibonacci = new Fibonacci();
            //fibonacci.PrintFibonacci();

            //CheckoutKata checkout = new CheckoutKata();
            //checkout.Checkout();

            //StringCalculator calculator = new StringCalculator();
            //calculator.StartCalculator();

            BowlingGame game = new BowlingGame();
            game.Bowling();
        }
    }
}
