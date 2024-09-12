using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	public class BubbleSort
	{
		private static bool more(int value1,int value2)
		{
			return value1 > value2;
		}

		public static void bubblesort(int[] arr)
		{
			int size= arr.Length;
			int i, j, temp;

			for ( i = 0; i < (size-1); i++) {
				for (j = 0; j < size - i - 1; j++) {
					if (more(arr[j], arr[j+1])) { 
					 temp = arr[j];
					 arr[j] = arr[j+1];
						arr[j+1] = temp;
					}
				}
			}
		}
	}
}
