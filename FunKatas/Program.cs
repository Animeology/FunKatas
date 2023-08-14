namespace FunKatas
{
    using Katas.Checkout;
    using Katas.Fibonacci;
    using Katas.FizzBuzz;
    using Katas.StringCalculator;
    using Katas.BowlingGame;
    using Katas.WordWrap;

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

            //BowlingGame game = new BowlingGame();
            //game.Bowling();

            string input = "Hello World and Goodbye";
            Console.WriteLine(Wrapper.WordWrapper(input, 5));
        }
    }
}
