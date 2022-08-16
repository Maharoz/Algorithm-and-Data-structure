using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string x = removeDuplicate("Trees are beatiful");
            Console.WriteLine(x);
        }

        public static string removeDuplicate(string input)
        {
            if(input == null)
            {
                return "";
            }
            StringBuilder output = new StringBuilder();
            List<char> seen = new List<char>();

            foreach(var ch in input.ToCharArray())
            {
                if (!seen.Contains(ch))
                {
                    seen.Add(ch);
                    output.Append(ch);
                }
            }
            return output.ToString();
        }
    }
}
