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


          
        }

        private Dictionary<string, Node> _nodes = new Dictionary<string, Node>();
        private Dictionary<string, List<Edge>> _adjacencyList = new Dictionary<string, List<Edge>>();

        public void addNode(string label)
        {
            var node = new Node(label);
            _nodes.Add(label, node);
            _adjacencyList.Add(label, new List<Edge> { });
        }
        public void addEdge(string from, string to, int weight)
        {
            Node nodeFrom = new Node(from);
            var fromNode = _nodes.ContainsKey(from);

            if (fromNode == false)
            {
                throw new Exception();
            }

            Node nodeTo = new Node(to);
            var toNode = _nodes.ContainsKey(to);

            if (toNode == false)
            {
                throw new Exception();
            }


            if (_adjacencyList.ContainsKey(from))
            {
                List<Edge> previouslyAddedNodes = _adjacencyList[from];
                previouslyAddedNodes.Add(new Edge(nodeFrom, nodeTo, weight));
                _adjacencyList[from] = previouslyAddedNodes;
            }

            if (_adjacencyList.ContainsKey(to))
            {
                List<Edge> previouslyAddedNodes = _adjacencyList[to];
                previouslyAddedNodes.Add(new Edge(nodeTo, nodeFrom, weight));
                _adjacencyList[to] = previouslyAddedNodes;
            }


        }

        public void print()
        {
            foreach (KeyValuePair<string, List<Edge>> kvp in _adjacencyList)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                //foreach (Node node in kvp.Value)
                //{
                //    Console.WriteLine("Edge = {0} , Connected with {1}", node._label, kvp.Key);
                //}
            }

        }
    }
}
