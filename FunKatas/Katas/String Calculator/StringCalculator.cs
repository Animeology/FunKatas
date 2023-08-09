using System.Text.RegularExpressions;

namespace FunKatas.Katas.String_Calculator
{
    using FunKatas.KataTest.StringCalculatorTests;

    public class StringCalculator
    {
        public void StartCalculator()
        {
            StringCalculatorTests tests = new StringCalculatorTests();
            tests.EmptyString_ReturnsZero();

            Console.Write("String input: ");
            string input = Console.ReadLine()!;

            Add(input);
        }


        public int Add(string nums)
        {
            int sum = 0;

            MatchCollection matches = Regex.Matches(nums, @"\d+");

            foreach (Match match in matches)
            {
                int number;
                if (int.TryParse(match.Value, out number))
                {
                    sum += number;
                }
            }
            Console.WriteLine($"Sum: {sum}");
            return sum;
        }
    }
}
