using System;

namespace CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] numbers = { 5, 1, 7, 2, 6, 4,20,20 };

            CountingSort sorter = new CountingSort();

            sorter.sort(numbers,20);
        }
    }
}
