using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating the array with object initialization syntax
            int[] numbers = {10,20,30};

            
            //Printing the array elements
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //Printing the length
            Console.WriteLine("Array length is " + numbers.Length);
        }
    }
}
