using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class PriorityQueue
    {
        private int[] items = new int[5];
        private int count;
        public void add(int item)
        {
            if (count == items.Length) {
                throw new Exception();
            }
            int i;
            for( i = count - 1; i >= 0; i--)
            {
                if (items[i] > item)
                {
                    items[i + 1]=items[i];
                }
                else
                {
                    break;
                }
                
            }
            items[i + 1] = item;
            count++;
        }

        public int remove()
        {
            if (count == items.Length)
            {
                throw new Exception();
            }
            return items[--count];
        }
    }
}
