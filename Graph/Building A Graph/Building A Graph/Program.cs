using System;

namespace Building_A_Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           var graph = new Graph();
            graph.addNode("X");
            graph.addNode("A");
            graph.addNode("B");
            graph.addNode("P");
            graph.addEdge("X", "A");
            graph.addEdge("X", "B");
            graph.addEdge("A", "P");
            graph.addEdge("B", "P");
            // graph.removeNode("B");
            var list= graph.topologicalSort();
            graph.print();
        }
    }
}
