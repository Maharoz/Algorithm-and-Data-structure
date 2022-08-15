using System;
using System.Text;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = reverse("Hello");
            Console.WriteLine(x);
        }

        public static String reverse(string s)
        {
            StringBuilder rev = new StringBuilder();

            for(int i = s.Length; i > 0; i--)
            {
                rev.Append(s.ToCharArray()[i-1]);
            }
            return rev.ToString();
        }
    }
}
