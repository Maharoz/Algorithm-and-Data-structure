using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating the array
            int[] numbers = new int[3];

            numbers[0] = 10; //inserting the value at first index
            numbers[1] = 20; //inserting the value at second index
            numbers[2] = 30; //inserting the value at third index



            //Printing the array elements
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
