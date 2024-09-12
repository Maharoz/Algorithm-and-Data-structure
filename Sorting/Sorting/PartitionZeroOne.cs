using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	public class PartitionZeroOne
	{
		public static int Partition01(int[] arr, int size)
		{
			int left = 0;
			int right = size - 1;
			int count = 0;

			while (left < right)
			{
				while (arr[left] == 0)
				{
					left += 1;
				}
				while (arr[right] == 1)
				{
					right -= 1;
				}

				if (left < right)
				{
					swap(arr, left, right);
					count += 1;
				}
			}
			return count;
		}

		private static void swap(int[] arr, int first, int second)
		{

			int temp = arr[first];
			arr[first] = arr[second];
			arr[second] = temp;
		}
	}
}
