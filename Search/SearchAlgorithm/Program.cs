using System;

namespace SearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3,5,6,9,11,18,20,21,24,30 };
            var search = new BinarySearch();
            var index = search.binarySearch(numbers, 6);
            Console.WriteLine(index);
        }
    }
}
