﻿using System;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 1, 4,6,2,3 };
            var sorter = new BubbleSort();
            sorter.sort(numbers);
            numbers.ToList().ForEach(i => Console.WriteLine(i.ToString()));
        }
    }
}
