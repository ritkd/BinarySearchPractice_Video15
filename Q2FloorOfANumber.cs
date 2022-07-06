using System;

namespace BinarySearchPractice_Video15
{
    internal class Q2FloorOfANumber
    {
        internal int GetFloorOfNumber(int[] arr1, int inp)
        {
            int start = 0;
            int end = arr1.Length - 1;
            int mid;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (arr1[mid] < inp)
                {
                    start = mid + 1;
                }
                else if (arr1[mid] > inp)
                {
                    end = mid - 1;
                }
                else
                {
                    return arr1[mid];
                }
            }
            return arr1[end];
        }
    }
}