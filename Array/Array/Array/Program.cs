using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Array numbers = new Array(3);
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);
            numbers.insert(50);
            numbers.removeAt(1);

            Console.WriteLine("Index of 30 is "+numbers.indexOf(30));
            numbers.print();
        }
    }
}
