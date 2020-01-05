namespace exercise_2_1_1
{
    public static class SortMethods
    {
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }

                array[j + 1] = key;
            }

            return array;
        }
    }
}
