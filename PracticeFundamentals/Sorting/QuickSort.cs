
using System;
using System.Collections.Generic;

namespace PracticeFundamentals.Sorting
{
    public static class QuickSort
    {
        public static int[] Quicksort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;
            if(arr.Length == 2)
            {
                var isfirstSmaller = arr[0] < arr[1];
                return new int[] { isfirstSmaller ? arr[0] : arr[1], isfirstSmaller ? arr[1] : arr[0] };
            }
            var pivot = (int)Math.Ceiling((decimal)arr.Length / 2);
            var newArrLeft = new List<int>();
            var newArrRight = new List<int>();
            var elementAtPivot = arr[pivot - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == pivot - 1)
                    continue;
                if (arr[i] < elementAtPivot)
                {
                    newArrLeft.Add(arr[i]);
                }

                if(arr[i] >= elementAtPivot)
                {
                    newArrRight.Add(arr[i]);
                }
            }
            var newArr = new int[arr.Length];
            Array.Copy(Quicksort(newArrLeft.ToArray()), newArr, newArrLeft.Count);
            newArr[newArrLeft.Count] = elementAtPivot;
            Array.Copy(Quicksort(newArrRight.ToArray()), 0, newArr, newArrLeft.Count + 1, newArrRight.Count);

            return newArr;
        }
    }
}
