using System;

namespace SearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 1, 3, 6, 5, 4, 8 };
            var search = new LinearSearch();
            var index = search.linearSearch(numbers, 2);
            Console.WriteLine(index);
        }
    }
}
