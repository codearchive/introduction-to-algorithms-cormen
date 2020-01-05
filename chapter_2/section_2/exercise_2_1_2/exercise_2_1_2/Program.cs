using System;

namespace exercise_2_1_2
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = new int[] { 1, 3, 5, 6, 4, 2 };

            inputArray = SortMethods.InsertionSortByDescending(inputArray);

            foreach (var i in inputArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
