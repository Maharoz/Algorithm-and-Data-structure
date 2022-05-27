using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    public class CountingSort
    {
        public void sort(int[] array,int max)
        {
            int[] count = new int[max +1];

            foreach(var item in array)
            {
                count[item]++;
            }


            int k = 0;
            for(int i = 0; i < count.Length; i++)
            {
                for(int j = 0; j < count[i]; j++)
                {
                    array[k++] = i;
                }
            }
        }
    }
}
