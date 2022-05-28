using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Graph
{
    public class WeightedGraph
    {

        private class Node
        {
            public string _label;
            public Node(string label)
            {
                _label = label;
            }
        }

        private class Edge
        {
            private Node from;
            private Node to;
            private int weight;


            public Edge(Node from , Node to, int weight)
            {
                this.from = from;
                this.to = to;
                this.weight = weight;
            }


            private Dictionary<string, Node> _nodes = new Dictionary<string, Node>();
            private Dictionary<string, List<Edge>> _adjacencyList = new Dictionary<string, List<Edge>>();

            //public void addNode(string label)
            //{
            //    var node = new Node(label);
            //    _nodes.Add(label, node);
            //    _edges.Add(label, new List<Node> { });
            //}
            //public void addEdge(string from, string to,int weight)
            //{
            //    Node nodeFrom = new Node(from);
            //    var fromNode = _nodes.ContainsKey(from);

            //    if (fromNode == false)
            //    {
            //        throw new Exception();
            //    }

            //    Node nodeTo = new Node(to);
            //    var toNode = _nodes.ContainsKey(to);

            //    if (toNode == false)
            //    {
            //        throw new Exception();
            //    }


            //    if (_adjacencyList.ContainsKey(from))
            //    {
            //        List<Node> previouslyAddedNodes = _adjacencyList[from];
            //        previouslyAddedNodes.Add(nodeTo);
            //        _edges[from] = previouslyAddedNodes;
            //    }


            //}
        }
    }
}
