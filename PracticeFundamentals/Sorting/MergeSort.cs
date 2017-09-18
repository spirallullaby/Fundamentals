using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeFundamentals.Sorting
{
    class MergeSort
    {
        public static int[] Mergesort(int[] arr)
        {
            var split = Split(arr);
            var cache = new List<int[]>();
            do
            {
                var currentTwo = split.Take(2);
                split = split.Skip(2).ToArray();
                //cache.Add(Merge(currentTwo.ElementAt(0), currentTwo.ElementAt(1) ?? null));
                //split = cache.ToArray();
            } while (split.Length != 1);
            return split[0];
        }
        public static int[] Merge(int[] leftArr, int[] rightArr)
        {
            var leftArrLength = leftArr?.Length ?? 0;
            var rightArrLength = rightArr?.Length ?? 0;
            var result = new int[leftArrLength + rightArrLength];
            var leftArrCount = 0;
            var rightArrCount = 0;
            var resultCount = 0;
            while(leftArrCount < leftArrLength && rightArrCount < rightArrLength)
            {
                if(leftArr[leftArrCount] < rightArr[rightArrCount])
                {
                    result[resultCount] = leftArr[leftArrCount];
                    leftArrCount++;
                }
                else
                {
                    result[resultCount] = rightArr[rightArrCount];
                    rightArrCount++;
                }
                resultCount++;
            }
            if(resultCount != result.Count())
            {
                if(rightArrCount < rightArrLength - 1)
                {
                    while(rightArrCount < rightArrLength)
                    {
                        result[resultCount] = rightArr[rightArrCount];
                    }
                }
                if (leftArrCount < leftArrLength - 1)
                {
                    while (leftArrCount < leftArrLength)
                    {
                        result[resultCount] = leftArr[leftArrCount];
                    }
                }
            }
            return result;
        }

        public static int[][] Split(int[] arr)
        {
            if (arr.Length == 2)
            {
                var res = new int[2][]
                {
                   new int[] { arr[0] },
                   new int[] { arr[1] }
                };
                return res;
            }
            if(arr.Length == 1)
            {
                return new int[][]
                {
                    new int[] {arr[0]}
                };
            }
            var mid = (int)Math.Round((float)arr.Length / 2);
            var result = Split(arr.Take(mid).ToArray()).Concat(Split(arr.Skip(mid + 1).ToArray()));
            return result.ToArray();            
        }
    }
}
