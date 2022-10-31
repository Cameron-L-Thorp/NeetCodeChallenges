namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "jordan";
            string t = "jornad";
            string f = "J-Dawg";
            Console.WriteLine(Solution.IsAnagram(s, t));
            Console.WriteLine(Solution.IsAnagram(f, t));
        }

        public static class Solution
        {
            public static bool IsAnagram(string s, string t)
            {
                bool result = true;
                char[] sArr = s.ToCharArray();
                char[] tArr = t.ToCharArray();
                sArr = sArr.OrderBy(c => c).ToArray();
                tArr = tArr.OrderBy(c => c).ToArray();
                for (int i = 0; i < sArr.Length; i++)
                {
                    if (sArr[i] != tArr[i])
                    {
                        result = false;
                    }
                }

                if (sArr.Length != tArr.Length)
                    return false;
                
                return result;

                //if (s.Length == t.Length)
                //{
                //    char[] sArr = s.OrderBy(c => c).ToArray();
                //    char[] tArr = t.OrderBy(c => c).ToArray();
                //    int i = 0;
                //    foreach (char c in sArr)
                //    {
                //        if (sArr[i] != tArr[i])
                //        {
                //            return false;
                //            break;
                //        }
                //        i++;
                //    }
                //    return true;

                //}

                //else
                //{
                //    return false;
                //}
            }
        }
    }
}