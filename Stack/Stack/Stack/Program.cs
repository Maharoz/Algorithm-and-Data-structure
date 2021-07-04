using System;
using System.Collections;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcd";
            StringReverser reverser = new StringReverser();
            var result = reverser.reverse(str);
            Console.WriteLine(result);
        }
    }
}
