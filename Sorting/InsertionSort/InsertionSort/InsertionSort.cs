using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    public class InsertionSort
    {
        //7, 3, 1, 4, 6, 2, 3
        public void sort(int[] array)
        {
            for(var i =1; i < array.Length; i++)
            {
                var current = array[i];
                var j = i - 1;
                while(j>=0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }
        }
    }
}
