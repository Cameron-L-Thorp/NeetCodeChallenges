using System.Globalization;
using System.Threading.Channels;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 1, 2, 3 , 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine(Solution.Search(nums, 11));
        }
    }

    //public static class Solution
    //{
    //    public static int BinarySearch(int[] nums, int left, int middle, int right, int goal)
    //    {
    //        if (nums[middle] == goal)
    //        {
    //            return middle;
    //        }
    //        else if (nums[middle] > goal)
    //        {
    //            left = middle + 1;
    //            middle = (left + right)/2;
    //            BinarySearch(nums, left, middle, right, goal);
    //        }
    //        else if (nums[middle] < goal)
    //        {
    //            right = middle - 1;
    //            middle = (left + right) / 2;
    //            BinarySearch(nums, left, middle, right, goal);
    //        }

    //        return -1;
    //    }
    //}
    public static class Solution
    {
        public static int Search(int[] nums, int target)
        {
            return BinarySearch(0, nums.Length - 1);

            int BinarySearch(int low, int high)
            {
                if (low > high) return -1;

                var mid = low + (high - low) / 2;

                if (nums[mid] == target)
                    return mid;
                if (nums[mid] > target)
                    return BinarySearch(low, mid - 1);
                return BinarySearch(mid + 1, high);
            }
        }

        public static int SearchTwo(int[] nums, int target)
        {
            int first = 0;
            int last = nums.Length - 1;
            while (first <= last)
            {
                int middle = first + (last - first) / 2;
                if (nums[middle] == target) return middle;
                if (nums[middle] < target) first = middle + 1;
                else last = middle - 1;
            }
            return first;
        }
    }
    
}