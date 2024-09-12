using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	public class SelectionSort
	{
		public static void Sort(int[] arr)
		{
			int size = arr.Length;
			int i, j, maxIndex, temp;

			for (i = 0; i < size - 1; i++)
			{
				// Initialize maxIndex to the index of the last unsorted element
				maxIndex = 0;

				// Find the maximum element in the unsorted portion
				for (j = 1; j < size - i; j++)
				{
					if (arr[j] > arr[maxIndex])
					{
						maxIndex = j;
					}
				}

				// Swap the found maximum element with the last unsorted element
				temp = arr[size - 1 - i];
				arr[size - 1 - i] = arr[maxIndex];
				arr[maxIndex] = temp;
			}
		}
	}
}
