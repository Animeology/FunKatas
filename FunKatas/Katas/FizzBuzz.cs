namespace FunKatas.Katas
{
    public class FizzBuzz
    {
        public void FizzBuzzGame()
        {
            Console.Write("Enter a number: ");
            int count = int.Parse(Console.ReadLine()!);

            for(int i = 1; i <= count; i++)
            {
                if(((i % DIVISIBLE_BY_THREE) == 0) && ((i % DIVISIBLE_BY_FIVE) == 0))
                {
                    Console.WriteLine($"{i} -> fizzbuzz");
                }

                else if ((i % DIVISIBLE_BY_THREE) == 0)
                {
                    Console.WriteLine($"{i} -> fizz");
                }

                else if((i % DIVISIBLE_BY_FIVE) == 0)
                {
                    Console.WriteLine($"{i} -> buzz");
                }

                else
                {
                    Console.WriteLine($"{i} -> {i}");
                }
            }
        }

        const int DIVISIBLE_BY_THREE = 3;
        const int DIVISIBLE_BY_FIVE = 5;
    }
}