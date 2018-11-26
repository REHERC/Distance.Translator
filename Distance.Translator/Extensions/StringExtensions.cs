namespace Distance.Translator.Extensions
{
    public static class StringExtensions
    {
        public static string UP(this string input)
        {
            return input.ToUpperInvariant();
        }

        public static string DOWN(this string input)
        {
            return input.ToLowerInvariant();
        }

        public static string SPACE(this string input, int spacing)
        {
            string result = "";
            foreach (char c in input)
            {
                result += c;
                for (int i = 0;i < spacing; i++)
                {
                    result += " ";
                }
            }
            while (result.EndsWith(" "))
            {
                result = result.TrimEnd(' ');
            }

            return result;
        }
    }
}
