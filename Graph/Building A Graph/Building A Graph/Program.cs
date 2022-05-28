using System;

namespace Building_A_Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           var graph = new Graph();
            graph.addNode("A");
            graph.addNode("B");
            graph.addNode("C");
            graph.addNode("D");
            graph.addEdge("A", "B");
            graph.addEdge("A", "C");
            graph.addEdge("B", "D");
            graph.addEdge("D", "C");
            // graph.removeNode("B");
            graph.traverseDepthFirst("A");
            graph.print();
        }
    }
}
