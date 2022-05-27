using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 7, 3, 1, 5, 2 };
            QuickSort q = new QuickSort();
            q.sort(number, 0, 4);
        }
    }
}
