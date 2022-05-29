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
            public Node[] children = new Node[ALPHABET_SIZE];
            public bool isEndOfWord;

            public Node(char value)
            {
                this.value = value;

            }


        }

        private Node root = new Node(' ');

        
        public void insert(string word)
        {
            Node current = root;


            foreach (var ch in word.ToCharArray())
            {
                var index = ch - 'a';
                if (current.children[index] == null)
                {
                    current.children[index] = new Node(ch);
                    
                }
                current = current.children[index];
            }

            current.isEndOfWord = true;
        }
    }
}
