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
            graph.addEdge("A", "B");
            graph.addEdge("B", "C");
            graph.addEdge("C", "A");
            // graph.removeNode("B");
            //var list= graph.topologicalSort();
            bool x= graph.hasCycle();
            Console.WriteLine(x);
            graph.print();
        }
    }
}
