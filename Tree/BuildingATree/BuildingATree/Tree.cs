using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingATree
{
    public class Tree
    {
        public class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;

            public Node(int value)
            {
                this.value=value;
            }
        }

        private Node root;
        public void insert(int value)
        {
            var node = new Node(value);
            if(root == null)
            {
                root = node;
                return;
            }

            Node current = root;
            while (true)
            {
                if(value < current.value)
                {
                    if(current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = node;
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }
        public bool find(int value)
        {
            var current = root;

            while (current != null)
            {
                if (value < current.value)
                    current = current.leftChild;
                else if (value > current.value)
                {
                    current = current.rightChild;
                }
                else
                    return true;
            }
            return false;
        }
        public void traversePreOrder()
        {
            traversePreOrder(root);
        }
        private void traversePreOrder(Node root)
        {
            //root
            //left
            //right
            if (root == null)
                return;

            Console.WriteLine(root.value);
            traversePreOrder(root.leftChild);
            traversePreOrder(root.rightChild);

        }
        public int height()
        {
            return height(root);
        }
        private int height(Node root)
        {
            if (root == null) 
            return -1;

            if(root.leftChild == null&& root.rightChild == null)
            {
                return 0;
            }  
            return 1 + Math.Max(height(root.leftChild), height(root.rightChild));
        }
        public int min()
        {
            return min(root);
        }
        private bool isLeaf(Node node)
        {
            return node.leftChild == null && node.rightChild == null;   
        }
        private int min(Node root)
        {
            if (root.leftChild == null && root.rightChild == null)
            {
                return root.value;
            }
            var left = root.leftChild!=null? min(root.leftChild):root.value;
            var right = root.rightChild != null ? min(root.rightChild) : root.value; 

            return Math.Min(Math.Min(left, right), root.value);
           
        }
        public bool equals(Tree other)
        {
            if(other == null)
                return false;
            return equals( root,other.root);
        }
        private bool equals(Node first,Node second)
        {
            if(first== null && second == null)
            {
                return true;
            }
            if(first!=null && second != null)
            {
                return first.value == second.value
                    && equals(first.leftChild,second.leftChild)
                     && equals(first.rightChild, second.rightChild);

            }
            return false;
        }

        public bool isBinarySwarchTree()
        {
            return isBinarySearchTree(root, int.MinValue, int.MaxValue);
        }
        private bool isBinarySearchTree(Node root,int min ,int max)
        {
            if (root == null)
            {
                return true;
            }
            if (root.value < min || root.value > max)
            {
                return false;
            }

            return isBinarySearchTree(root.leftChild,min,root.value-1)
                && isBinarySearchTree(root.rightChild, root.value+ 1,max);
        }

        public List<int> printNodesAtDistance(int distance)
        {
            List<int> list = new List<int>();
            printNodesAtDistance(root, distance,list);
            return list;
        }
        private void printNodesAtDistance(Node root,int distance, List<int> list)
        {
            if(root == null)
            {
                return;
            }
            if (distance == 0)
            {
                list.Add(root.value);
                Console.WriteLine(root.value);
                return;
            }

            printNodesAtDistance(root.leftChild, distance - 1,list);
            printNodesAtDistance(root.rightChild, distance - 1, list);
            }

        //public void travelLevelOrder()
        //{
        //    for(int i = 0; i <= height(); i++)
        //    {
        //        int list = printNodesAtDistance(i);

        //    }
        //}

        }
    }

