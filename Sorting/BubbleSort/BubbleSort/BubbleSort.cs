using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public class BubbleSort
    {
        public void sort(int[] array)
        {
            for(var i = 0; i < array.Length; i++)
            {
                for(var j = 1;j<array.Length;j++)
                {
                    if(array[j] < array[j - 1])
                    {
                        // var temp = array[j];
                        //array[j] = array[j - 1];
                        //array[j - 1] = temp;

                        swap(array, j, j - 1);


                    }
                }
            }
        }

        private void swap(int[] array,int index1,int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
