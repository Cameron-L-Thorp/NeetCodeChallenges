using System.Security.Cryptography;

namespace RickysProblem
{
    //Given a list of lists of integer that represent coordinates of restaurants, find the restaurant that is closest to you.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<List<int>> restaurantCoordinates = new List<List<int>>();
            restaurantCoordinates.Add(new List<int>() { -1, -1 });
            restaurantCoordinates.Add(new List<int>() { 5, 8 });
            restaurantCoordinates.Add(new List<int>() { 4, 30 });
            restaurantCoordinates.Add(new List<int>() { 2, 1 });
            restaurantCoordinates.Add(new List<int>() { -10, -10 });
            restaurantCoordinates.Add(new List<int>() { -4, 4 });

            List<int> result = Solution.ClosestRest(restaurantCoordinates);

            Console.WriteLine($"{result[0]}, {result[1]} Distance from 0,0 on grid:" + (Math.Abs(result[0]) + Math.Abs(result[1])));

            List<int> result2 = Solution.ClosestHippopotamus(restaurantCoordinates);

            Console.WriteLine($"{result2[0]}, {result2[1]} Distance from 0,0 on grid:" + Math.Sqrt(((int)Math.Pow(result2[0], 2)) + ((int)Math.Pow(result2[1], 2))));
        }
    }

    public static class Solution
    {
        public static List<int> ClosestRest(List<List<int>> coordinates)
        {
            int original = Math.Abs(coordinates[0][0]) + Math.Abs(coordinates[0][1]);
            List<int> result = new List<int>() ;

            foreach (List<int> coordinate in coordinates)
            {
                int distance = Math.Abs(coordinate[0]) + Math.Abs(coordinate[1]);

                if (distance <= original)
                {
                    original = distance;
                    result = coordinate;
                }
            }

            return result;
        }

        public static List<int> ClosestHippopotamus(List<List<int>> coordinates)
        {
            double original = Math.Sqrt((Math.Pow(coordinates[0][0], 2)) + (Math.Pow(coordinates[0][1], 2)));
            List<int> result = new List<int>() ;

            foreach (List<int> coordinate in coordinates)
            {
                double distance = Math.Sqrt((Math.Pow(coordinate[0], 2)) + (Math.Pow(coordinate[1], 2)));

                if (distance <= original)
                {
                    original = distance;
                    result = coordinate;
                }
            }

            //coordinates.ForEach(coordinate =>
            //{
            //    double distance = Math.Sqrt((Math.Pow(coordinate[0], 2)) + (Math.Pow(coordinate[1], 2)));

            //    if (distance <= original)
            //    {
            //        original = distance;
            //        result = coordinate;
            //    }
            //});

            return result;
        }
    }
}