using System;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var trie = new Trie();
            trie.insert("cat");
            trie.insert("can");
        }
    }
}
