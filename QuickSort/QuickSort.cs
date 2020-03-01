namespace QuickSort
{
    class QuickSort
    {
        internal int[] Sort(int[] arr, int lower, int upper)
        {
            if (upper > lower)
            {
                int pivot = Split(arr, lower, upper);
                if (pivot > 1)
                {
                    Sort(arr, lower, pivot - 1);
                }
                if (pivot + 1 < upper)
                {
                    Sort(arr, pivot + 1, upper);
                }
            }
            return arr;
        }

        private static int Split(int[] arr, int lower, int upper)
        {
            int pivot = arr[lower];
            while (true)
            {
                while (arr[lower] < pivot)
                {
                    lower++;
                }

                while (arr[upper] > pivot)
                {
                    upper--;
                }

                if (lower < upper)
                {
                    if (arr[lower] == arr[upper]) return upper;

                    int temp = arr[lower];
                    arr[lower] = arr[upper];
                    arr[upper] = temp;
                }
                else
                {
                    return upper;
                }
            }
        }
    }
}
