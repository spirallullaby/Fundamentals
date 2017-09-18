namespace PracticeFundamentals.Sorting
{
    static class SelectionSort
    {
        //public static int[] TestCase1 = new int[] { 0, 5, -6, 4, -20, 9, 2 };
        //public static int[] Selectionsort(int[] arr)
        //{
        //    if (arr.Length <= 1)
        //        return arr;
        //    var result = new int[arr.Length];
        //    var resultIndex = 0;
        //    var minValueIndex = 0;
        //    while(resultIndex < arr.Length)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if(arr[minValueIndex] >= arr[i])
        //            {
        //                minValueIndex = i;
        //            }
        //        }
        //        result[resultIndex] = arr[minValueIndex];
        //        arr[minValueIndex] = int.MaxValue;
        //        resultIndex++;
        //    }
        //    return result;
        //}

        public static int[] Selectionsort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var minValueIndex = i;
                var minValue = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] < minValue)
                    {
                        minValue = arr[j];
                        minValueIndex = j;
                    }
                }
                arr[minValueIndex] = arr[i];
                arr[i] = minValue;
            }
            return arr;
        }
    }
}
