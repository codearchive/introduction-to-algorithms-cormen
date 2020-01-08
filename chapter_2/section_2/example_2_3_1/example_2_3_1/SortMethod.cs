namespace example_2_3_1
{
    public class SortMethod
    {
        public int[] MergeSortedSubArrays(int[] array, int left, int middle, int right)
        {
            int i;
            int j;

            int arraySizeLeft = middle - left + 1;
            int arraySizeRight = right - middle;

            int[] arrayLeft = new int[arraySizeLeft];
            int[] arrayRight = new int[arraySizeRight];

            
            for (i = 0; i < arraySizeLeft; i++)
            {
                arrayLeft[i] = array[left + i];
            }

            for (j = 0; j < arraySizeRight; j++)
            {
                arrayRight[j] = array[middle + 1 + j];
            }

            i = 0;
            j = 0;
            for (int k = left; k <= right; k++)
            {
                if (i == arraySizeLeft)
                {
                    array[k] = arrayRight[j];
                    j++;
                }
                else if (j == arraySizeRight)
                {
                    array[k] = arrayLeft[i];
                    i++;
                }
                else if (arrayLeft[i] <= arrayRight[j])
                {
                    array[k] = arrayLeft[i];
                    i++;
                }
                else
                {
                    array[k] = arrayRight[j];
                    j++;
                }
            }
            
            return array;
        }

        public int[] MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                MergeSortedSubArrays(array, left, middle, right);
            }

            return array;
        }
    }
}
