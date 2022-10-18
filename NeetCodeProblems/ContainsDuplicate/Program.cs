using System.Threading.Channels;
using System.Xml.Serialization;

namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 1, 2, 3, 4 };
            Solution.PrintSol(nums);
        }
    }

    public static class Solution
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            List<int> distNums = new();
            bool duplicate = false;
            foreach (int i in nums)
            {
                if (distNums.Contains(i))
                {
                    duplicate = true;
                }
                distNums.Add(i);
            }

            return duplicate;
        }

        public static void PrintSol(int[] nums)
        {
            Console.WriteLine(Solution.ContainsDuplicate(nums));
        }
    }
}