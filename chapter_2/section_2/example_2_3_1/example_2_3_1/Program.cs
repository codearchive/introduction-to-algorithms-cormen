using System;

namespace example_2_3_1
{
    class Program
    {
        static void Main()
        {
            SortMethod sortMethod = new SortMethod();

            int[] inputArray = new int[] { 4, 3, 2, 1 }; //1, 2, 5, 6, 9, 1, 3, 4, 7

            inputArray = sortMethod.MergeSort(inputArray, 0, inputArray.Length - 1);

            foreach (var i in inputArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
