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
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.print();
        }
    }
}
