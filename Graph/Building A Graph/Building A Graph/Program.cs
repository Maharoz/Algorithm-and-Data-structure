﻿using System;

namespace Building_A_Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var graph = new WeightedGraph();

            graph.addNode("A");
            graph.addNode("B");
            graph.addNode("C");
            graph.addEdge("A", "B",3);
            graph.addEdge("A", "C",2);
            graph.print();
        }
    }
}
