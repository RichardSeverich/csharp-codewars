namespace csharp_codewars
{
    class SplitString
    {
        public static string[] SplitNCases(string input, int cases)
        {
            return (input.Length % cases > 0) ? getError() :
                                                getResult(input, cases);
        }

        private static string[] getError()
        {
            string[] error = new string[] { "Error" };
            return error;
        }

        private static string[] getResult(string input, int cases)
        {
            int numWords = input.Length / cases;
            string[] result = new string[cases];
            for (int i = 0; i < cases; i++)
            {
                result[i] = input.Substring(i * numWords, numWords);
            }
            return result;
        }
    }
}
