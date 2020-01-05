using System;

namespace exercise_2_1_3
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = new int[] { 5, 6, 7, 3, 2, 1, 4, 8, 9 };
            int value = 7;

            inputArray = SearchElement.InsertionSort(inputArray);
            Console.WriteLine(SearchElement.SearchIndex(value, inputArray));

            Console.ReadLine();
        }
    }
}
