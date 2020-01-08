using System;

namespace exercise_2_1_1
{
    class Program
    {
        static void Main()
        {
            
            int[] array = new int[6] { 5, 2, 4, 6, 1, 3 };

            array = SortMethod.InsertionSort(array);

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
