﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    public class Trie
    {
        public static int ALPHABET_SIZE = 26;
        public class Node
        {
            public char value;
          //  public Node[] children = new Node[ALPHABET_SIZE];
            public Dictionary<char,Node> children = new Dictionary<char, Node>();
            public bool isEndOfWord;

            public Node(char value)
            {
                this.value = value;

            }

            public bool hasChild(char ch)
            {
                return children.ContainsKey(ch);
            }

            public void addChild(char ch)
            {
                children.Add(ch, new Node(ch));
            }

            public Node getChild(char ch)
            {
                return children[ch];
            }
        }

        private Node root = new Node(' ');

        
        public void insert(string word)
        {
            Node current = root;


            foreach (var ch in word.ToCharArray())
            {
                if (!current.hasChild(ch))
                {
                    current.addChild(ch);
                    
                }
                current = current.getChild(ch);
            }

            current.isEndOfWord = true;
        }
    }
}
