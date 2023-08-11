namespace FunKatas.KataTest.StringCalculatorTests
{
    using FunKatas.Katas.String_Calculator;

    public class StringCalculatorTests
    {
        public void EmptyString_ReturnsZero()
        {
            StringCalculator calculator = new StringCalculator();

            string empty = String.Empty;

            if(calculator.Add(empty) != 0)
            {
                throw new Exception("Empty String doesn't return zero");
            }
        }

        public void OneTwoThree_ReturnsSix()
        {
            StringCalculator calculator = new StringCalculator();

            string input = "1,2,3";

            if(calculator.Add(input) != 6)
            {
                throw new Exception("1,2,3 doesn't return 6");
            }
        }
    }
}
