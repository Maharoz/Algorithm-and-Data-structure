using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Graph
{
    public class Graph
    {
        private class Node
        {
            public string _label;
            public Node(string label)
            {
                _label = label; 
            }
        }

        private Dictionary<string,Node> _nodes = new Dictionary<string, Node>();
        private Dictionary<string, List<Node>> _edges = new Dictionary<string, List<Node>>();
        public void addNode(string label)
        {
            var node = new Node(label);
            _nodes.Add(label, node);
            _edges.Add(label, new List<Node> { });
        }
        public void addEdge(string from , string to){
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


            if (_edges.ContainsKey(from))
            {
                List<Node> previouslyAddedNodes = _edges[from];
                previouslyAddedNodes.Add(nodeTo);
                _edges[from] = previouslyAddedNodes;
            }

           
        }
        public void removeNode(string label)
        {
            var node = _nodes.ContainsKey(label);
            if(node == false)
            {
                return;
            }

            foreach (KeyValuePair<string, List<Node>> kvp in _edges)
            {
                foreach (Node nodes in kvp.Value.ToList())
                {
                    if (nodes._label == label)
                    {
                        kvp.Value.Remove(nodes);
                    }
                }
            }

            _edges.Remove(label);
            _nodes.Remove(label);
        }
        public void removeEdge(string from,string to)
        {
            Node nodeFrom = new Node(from);
            var fromNode = _nodes.ContainsKey(from);

            if (fromNode == false)
            {
                return;
            }

            Node nodeTo = new Node(to);
            var toNode = _nodes.ContainsKey(to);

            if (toNode == false)
            {
                return;
            }


            foreach (KeyValuePair<string, List<Node>> kvp in _edges)
            {
                if (kvp.Key.Contains(from))
                {
                    foreach (Node nodes in kvp.Value.ToList())
                    {
                        if (nodes._label == to)
                        {
                            kvp.Value.Remove(nodes);
                        }
                    }
                }
            }

        }
        public void print()
        {
            foreach (KeyValuePair<string, List<Node>> kvp in _edges)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                foreach(Node node in kvp.Value)
                {
                    Console.WriteLine("Edge = {0} , Connected with {1}", node._label, kvp.Key);
                }
            }

        }

        List<Node> l = new List<Node>();
        public void traverseDepthFirst(string root)
        {
          var node=  _nodes.GetValueOrDefault(root);
            if (node == null)
            {
                return;
            }
            traverseDepthFirst(_nodes.GetValueOrDefault(root),l );
        }

        private void traverseDepthFirst(Node root, List<Node> visited)
        {
            Console.WriteLine(root._label);
            visited.Add(root);

            foreach(var x in _edges.GetValueOrDefault(root._label))
            {
                if (!visited.Contains(x))
                {
                    traverseDepthFirst(x, l);
                }
            }
        }
    }
}
