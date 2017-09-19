using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeFundamentals.Sorting
{
    class MergeSort
    {
        public static void DoMerge(int[] numbers, int left, int middle, int right)
        {
            var elementsCount = (right - left + 1);
            var cache = new int[elementsCount];
            
            var leftEnd = (middle - 1);
            var currentPosition = 0;
            var cacheLeft = left;
            //while there are elements within the left and the right split
            while ((left <= leftEnd) && (middle <= right))
            {
                if (numbers[left] <= numbers[middle])
                {
                    cache[currentPosition++] = numbers[left++];
                }
                else
                {
                    cache[currentPosition++] = numbers[middle++];
                }
            }

            //if there are leftout elements in the left split
            while (left <= leftEnd)
            {
                cache[currentPosition++] = numbers[left++];
            }
            //if there are leftout elements in the right split
            while (middle <= right)
            {
                cache[currentPosition++] = numbers[middle++];
            }

            for (var i = 0; i < currentPosition; i++)
            {
                numbers[cacheLeft] = cache[i];
                cacheLeft++;
            }
        }

        public static int[] Mergesort(int[] numbers, int left = 0, int right = int.MinValue)
        {
            if (right == int.MinValue)
            {
                right = numbers.Length - 1;
            }
            if (right > left)
            {
                var mid = (right + left) / 2;
                Mergesort(numbers, left, mid);
                Mergesort(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
            return numbers;
        }

    }
}
