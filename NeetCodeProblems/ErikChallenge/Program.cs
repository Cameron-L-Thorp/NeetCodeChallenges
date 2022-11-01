namespace ErikChallenge
{
    internal class Program
    {
        //Create code to add two numbers, (no methods, no UI)
        //Use tools to extract code for adding two numbers to a method
        //Call method from main and output results in main
        //Use data Structure to store 100 #s
        //Populate structure with 100 numbers - quick / efficient
        //Output the result of adding each number to the previous number within the data structure
        //Generate a randome number using the random math 
        //Call a method that returns a array with 100 random numbers
        //Use similar code to the append to show all numbers and convert the array to a list
        //Use the following code to sort the list in place prior to outputing the numbers Sort
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleAdd(1, 2));

            int[] hundredNums = new int[100];
            for ( int i = 0; i < hundredNums.Length; i++ )
            {
                hundredNums[i] = i;
            }

            int totalArray = 0;
            foreach ( int num in hundredNums)
            {
                totalArray += num;
            }
            Console.WriteLine(totalArray);

            //Random random = new Random(100);
            //Console.WriteLine(random.NextInt64());

            //int[] randomArr = RandomArr();

            //List<int> randomList = randomArr.ToList();

            //randomList = randomList.OrderBy(n => n).ToList();
            //foreach (int num in randomList)
            //{
            //    Console.WriteLine(num);
            //}


            //List<int> sequenceList = SequenceGenerator.ReturnSequence(10, 10);
            //foreach ( int num in sequenceList )
            //{
            //    Console.WriteLine(num);
            //}
            RandomSequence rand = new RandomSequence();
            List<int> randomList = rand.RandomResult(15);
            foreach (int num in randomList)
            {
                Console.WriteLine(num);
            }
        }

        private static int SimpleAdd(int x, int y)
        {
             return x + y;
        }

        public static int[] RandomArr()
        {
            Random random = new Random();
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 101);
            }
            return arr;
        }
    }
}