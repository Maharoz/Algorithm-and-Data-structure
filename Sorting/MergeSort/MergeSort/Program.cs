using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 7, 3, 5, 2, 3, 1, 5, 8 };
            MergeSort sorter = new MergeSort();
            sorter.sort(number);
        }
    }
}
