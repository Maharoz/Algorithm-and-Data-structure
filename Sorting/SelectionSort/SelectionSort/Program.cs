using System;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 7, 3, 1, 4, 6, 2, 3 };
            var sorter = new SelectionSort();
            sorter.sort(numbers);
            numbers.ToList().ForEach(i => Console.WriteLine(i.ToString()));
        }
    }
}
