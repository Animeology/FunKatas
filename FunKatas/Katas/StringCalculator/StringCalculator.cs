using System.Text.RegularExpressions;

namespace FunKatas.Katas.StringCalculator
{
    using FunKatas.KataTest.StringCalculatorTests;

    public class StringCalculator
    {
        public void StartCalculator()
        {
            StringCalculatorTests tests = new StringCalculatorTests();
            tests.EmptyString_ReturnsZero();
            //tests.OneTwoThree_ReturnsSix();

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
                    if(!int.TryParse(num, out int parsedNum))
                    {
                        throw new Exception($"Invalid number format: {nums}");
                    }
                    if(parsedNum < 0)
                    {
                        throw new Exception($"Negatives not allowed: {nums}");
                    }
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
