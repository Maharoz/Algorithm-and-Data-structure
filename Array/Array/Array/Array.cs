using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Array
    {
        private int[] items;
        private int count;
        public Array(int length)
        {
            items = new int[length];
        }

        public void insert(int item)
        {
            if(items.Length == count)
            {
                int[] newItems = new int[count * 2];
                for(int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                items = newItems;
            }
            items[count] = item;
            count++;
        }

        public void print()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
