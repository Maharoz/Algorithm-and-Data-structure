using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingATree
{
    public class Tree
    {
        private class Node
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

    }
}
