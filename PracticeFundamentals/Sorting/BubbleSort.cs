namespace PracticeFundamentals.Sorting
{
    class BubbleSort
    {
        public static int[] Bubblesort(int[] arr)
        {
            for (int i = arr.Length - 1;  i >= 1;  i--)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    if(arr[i] <arr[j])
                    {
                        arr[i] += arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] -= arr[j];
                    }
                }
            }
            return arr;
        }
    }
}
