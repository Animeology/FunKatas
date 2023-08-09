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
            string[] numbers = nums.Split(DELIMITER.ToCharArray());   

            if(IsEmptyString(nums))
            {
                return sum;
            }

            if(HasDelimiter(nums))
            {
                foreach (var num in numbers)
                {
                    sum += int.Parse(num);
                }
            }

            Console.WriteLine($"Sum: {sum}");
            return sum;
        }

        bool IsEmptyString(string input)
        {
            return input.Length == 0;
        }

        bool HasDelimiter(string input)
        {
            return input.IndexOf(DELIMITER) > 0;
        }

        const string DELIMITER = ",";
    }
}
