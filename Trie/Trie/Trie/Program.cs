using System;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var trie = new Trie();
            trie.insert("care");
            trie.insert("car");
            trie.remove("car");
           // trie.traverse();
            Console.WriteLine(trie.contains("car"));
            Console.WriteLine(trie.contains("care"));
        }
    }
}
