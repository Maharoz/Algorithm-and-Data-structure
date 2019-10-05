using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Array
    {
        private int[] items;
        public Array(int length)
        {
            items = new int[length];
        }

        public void print()
        {
            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
