using System.Linq;
internal class Anagram
{
    private static void Main(string[] args)
    {
        string s = "rat";
        string t = "cat";

        Console.WriteLine(Anagram.IsAnagram(s, t));
        
    }
    public bool IsAnagram(string s, string t)
        {
            bool pali = false;
            if (s.Length != t.Length)
            {
                return pali;
            }
            else
            {
                pali = true;
                s = s.OrderBy(c => c).ToString();
                t = t.OrderBy(c => c).ToString();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != t[i])
                    {
                        pali = false;
                    }
                }
                return pali;
            }
        }
}