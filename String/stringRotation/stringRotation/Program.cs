using System;

namespace stringRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var x = areRotations("ABCD", "DABC");
            Console.WriteLine(x);
        }

        public static bool areRotations(
            string str1,string str2)
        {
            if(str1==null || str2 == null)
            {
                return false;
            }

            return (str1.Length == str2.Length) &&
                (str1 + str2).Contains(str2);
        }
    }
}
