namespace FunKatas.Katas.WordWrap
{
    public class Wrapper
    {        
        public static string WordWrapper(string input, int column)
        {
            if (input.Length <= column)
            {
                return input;
            }

            if (input[column] == ' ')
            {
                return SplitWord(input, column, 1);
            }

            return SplitWord(input, column);
        }

        static string SplitWord(string input, int position, int offset = 0)
        {
            return input.Substring(0, position) + '\n' + WordWrapper(input.Substring(position + offset), position);
        }
    }
}
