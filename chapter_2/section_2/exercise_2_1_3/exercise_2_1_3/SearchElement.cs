namespace exercise_2_1_3
{
    public static class SearchElement
    {
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && key < array[j])
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }

                array[j + 1] = key;
            }

            return array;
        }

        public static int SearchIndex(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value == array[i]) return i;
            }

            return -1;
        }
    }
}
