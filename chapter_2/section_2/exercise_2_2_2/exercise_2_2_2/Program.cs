using System;

namespace exercise_2_2_2
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = new int[] { 4, 3, 1, 2, 6, 5 };

            inputArray = SortMethod.SelectionSort(inputArray);
            foreach (var i in inputArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
