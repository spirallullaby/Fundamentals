namespace PracticeFundamentals.Sorting
{
    static class SelectionSort
    {
        public static int[] TestCase4 = new int[] { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue };
        public static int[] TestCase5 = new int[] { int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue, int.MinValue };

        //public static int[] TestCase1 = new int[] { 0, 5, -6, 4, -20, 9, 2 };
        public static int[] Selectionsort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;
            var result = new int[arr.Length];
            var resultIndex = 0;
            var minValueIndex = 0;
            while(resultIndex < arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[minValueIndex] >= arr[i])
                    {
                        minValueIndex = i;
                    }
                }
                result[resultIndex] = arr[minValueIndex];
                arr[minValueIndex] = int.MaxValue;
                resultIndex++;
            }
            return result;
        }
    }
}
