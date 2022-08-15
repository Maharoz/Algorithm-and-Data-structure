using System;
using System.ComponentModel;

namespace BuildingATree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.insert(7);
            tree.insert(9);
            tree.insert(1);
            tree.insert(6);
            tree.insert(8);
            tree.insert(10);
            //tree.insert(4);
            //tree.insert(10);
          //  tree.traversePreOrder();
            var list = tree.printNodesAtDistance(1);
            //Console.WriteLine(tree.isBinarySwarchTree());
            //Console.WriteLine(tree.height());
            //Console.WriteLine(tree.find(10));
        }
    }
}
