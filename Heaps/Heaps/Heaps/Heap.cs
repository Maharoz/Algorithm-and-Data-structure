using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
   public class Heap
    {
        private int[] items = new int[10];
        private int size;

        public void insert(int value)
        {

            if (isFull())
            {
                throw new Exception();
            }
            items[size++] = value;

            //newItem >parent
            bubbleUp();

        }

        public bool isFull()
        {
            return size == items.Length;
        }
        private void bubbleUp()
        {
            int index = size - 1;
            //int parentIndex = (index - 1) / 2;

            while (index > 0 && items[index] > items[parent(index)])
            {
                swap(index, parent(index));
                index = parent(index);
            }
        }
        private int parent(int index)
        {
            int x = (index - 1) / 2;
            return (index - 1) / 2;
        }

        private void swap(int first,int second)
        {
            int temp = items[first];
            items[first] = items[second];
            items[second] = temp;

        }
    }
}
