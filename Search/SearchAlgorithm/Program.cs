using System;

namespace SearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 1, 3, 6, 5, 4, 8 };
            var search = new BinarySearch();
            var index = search.binarySearch(numbers, 1);
            Console.WriteLine(index);
        }
    }
}
