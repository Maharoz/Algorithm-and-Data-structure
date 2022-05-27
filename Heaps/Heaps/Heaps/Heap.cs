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
        
        public void remove()
        {

            if (isEmpty())
            {
                throw new Exception();
            }
            items[0] = items[size - 1];
            size--;


            int index = 0;

            while (index<=size && !isvalidparent(index)){
                var largerChildIndex = largerChildindex(index);

                swap(index, largerChildIndex);
                index = largerChildIndex;
            }
        }

        private int largerChildindex(int index)
        {
            if (!hasLeftChild(index)){
                return index;
            };

            if (!hasRightChild(index))
            {
                return leftChildIndex(index);
            }
            return  leftChild(index) > rightChild(index) ?
                 leftChildIndex(index) : rightChildIndex(index);
        }
        private bool hasLeftChild(int index)
        {
            return leftChildIndex(index) <= size;

        }

        public bool isEmpty()
        {
            return size == 0;
        }
        private bool hasRightChild(int index)
        {
            return rightChildIndex(index) <= size;

        }
        private bool isvalidparent(int index)
        {

            if (!hasLeftChild(index))
            {
                return true;
            };

            var isvalid = items[index] >= leftChild(index);

            if (hasRightChild(index))
            {

                isvalid = isvalid && items[index] >= rightChild(index);
                return isvalid;
                //return items[index] >= leftChild(index);
            }
            return isvalid;
        }
        private int rightChild(int index)
        {
            return items[rightChildIndex(index)];

        }

        private int leftChild(int index)
        {
            return items[leftChildIndex(index)];

        }

        private int leftChildIndex(int index)
        {
            return index * 2 + 1;

        }

        private int rightChildIndex(int index)
        {
            return index * 2 + 2;

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
