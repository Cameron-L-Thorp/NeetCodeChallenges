namespace ValidParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string input = "";
            Console.WriteLine(Solution.IsValid(input));
        }
    }

    public static class Solution
    {
        public static bool IsValid(string pars)
        {
            if (pars.Length % 2 != 0)
            {
                return false;
            }
            
            char[] parsChars = pars.ToCharArray();
            Dictionary<char, char> valid = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' }, { '{', '}' } };
            Stack<char> holdingOpen = new Stack<char>();

            foreach (char c in parsChars)
            {
                if (valid.ContainsKey(c))
                {
                    holdingOpen.Push(c);
                }
                else
                {
                    if (c == valid[holdingOpen.Peek()] && holdingOpen.Count != 0)
                    {
                        holdingOpen.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if(holdingOpen.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}