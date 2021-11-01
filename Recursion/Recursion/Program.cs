using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(3));
        }

        
        public static int factorial(int n)
        {
            if (n == 0)
                return 1;

            return n * factorial(n - 1);
        }
    }
}
