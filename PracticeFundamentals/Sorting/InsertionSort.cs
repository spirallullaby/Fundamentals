namespace PracticeFundamentals.Sorting
{
    class InsertionSort
    {
        public static int[] Insertionsort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                while(j>=0 && arr[j]>arr[i])
                {
                    var temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    j--;
                }
            }
            return arr;
        }
    }
}
