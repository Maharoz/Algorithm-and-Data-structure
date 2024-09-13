using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayOperation
{
	public class ArrayDuplicate
	{
		public static List<int> duplicates(long[] arr, int n)
		{
			// Your code here
			List<int> list = new List<int>();
			Array.Sort(arr);
			long? temp = null;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == temp && !list.Contains((int)arr[i]))
				{
					list.Add((int)arr[i]);

				}
				temp = arr[i];
			}

			if (list.Count == 0)
			{
				list.Add(-1);
			}

			return list;
		}
	}
}
