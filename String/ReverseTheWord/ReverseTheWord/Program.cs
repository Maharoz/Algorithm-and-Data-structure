using System;

namespace ReverseTheWord
{
    class Program
    {
        static void Main(string[] args)
        {
           string res= rev("Hello World!");
           Console.WriteLine(res);
        }
        public static string rev(string s)
        {
            if(s == null)
            {
                return "";
            }
            string res = "";
            string[] x = s.Trim().Split(" ");
            Array.Reverse(x);

            foreach(var a in x)
            {
                res = res + a + " ";
            }
            return res.Trim();
        }
    }
}
