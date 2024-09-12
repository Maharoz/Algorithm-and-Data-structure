using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	public class QuickSort
	{

		private static void quickSort(int[] arr , int lower,int upper)
		{
			if(upper<=lower)
			{
				return;
			}

			int pivot=arr[lower];
			int start = lower;
			int stop = upper;

			while (lower < upper)
			{
				while (arr[lower]<=pivot && lower < upper)
				{
					lower++;
				}
				while (arr[upper]>pivot && lower <= upper)
				{
					upper--;
				}
				if (lower < upper)
				{
					swap(arr,upper,lower);
				}
			}
			swap(arr,upper,start);
			quickSort(arr, start, upper - 1);
			quickSort(arr, upper+1,stop);
		}

		public static void sort(int[] arr)
		{
			int size =arr.Length;
			quickSort(arr, 0, size-1);
		}

		private static void swap(int[] arr, int first, int second) {

			int temp = arr[first];
			arr[first] = arr[second];
			arr[second] = temp;
		}
	}
}
