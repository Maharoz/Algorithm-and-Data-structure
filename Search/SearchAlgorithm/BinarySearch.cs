using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithm
{
    public class BinarySearch
    {
        public int binarySearch(int[] array, int target)
        {
            var left = 0;
            var right = array.Length - 1;
            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (array[middle] == target)
                {
                    return middle;
                }
                if (target < array[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}