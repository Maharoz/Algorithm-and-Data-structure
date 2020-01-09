using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithm
{
   public class LinearSearch
    {
        public int linearSearch(int[] array, int target)
        {
            for(var i = 0; i < array.Length; i++)
            {
                if(array[i]== target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
