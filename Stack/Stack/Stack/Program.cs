using System;
using System.Collections;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "(1+2>";
            Expression ex = new Expression();
            var result = ex.isBalanced(str);
            Console.WriteLine(result);
        }
    }
}
