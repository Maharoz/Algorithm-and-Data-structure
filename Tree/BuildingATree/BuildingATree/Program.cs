using System;

namespace BuildingATree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.insert(7);
            tree.insert(4);
            tree.insert(9);
            tree.insert(1);
            tree.insert(6);
            tree.insert(8);
            tree.insert(10);


            Console.WriteLine("Done");
        }
    }
}
