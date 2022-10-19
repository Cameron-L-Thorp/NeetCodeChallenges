namespace Heap_PriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you are given an array of integers stone weight. On each turn, we choose the heaviest two stones and smash them together.
            //Suppose the heaviest two stones have weights x and y with x <= y. The result of this smash is:
            int[] stones = { 4, 8, 1, 100, 3, 1, 7 };
            int stone = StoneMethods.Smashem(stones);
            Console.WriteLine(stone);
        }
    }
    public static class StoneMethods
    {
        public static int Smashem(int[] stones)
        {
            PriorityQueue<int, int> heap = new();
            foreach (int i in stones)
            {
                heap.Enqueue(i, -i);
            }

            while (heap.Count > 1)
            {
                int rock1 = heap.Dequeue();
                int rock2 = heap.Dequeue();

                if ((rock1 - rock2) != 0)
                {
                    heap.Enqueue((rock1 - rock2), -(rock1 - rock2));
                }
            }
            if (heap.Count == 0)
            {
                return 0;
            }
            else
            {
                return heap.Dequeue();
            }
        }
    }
}