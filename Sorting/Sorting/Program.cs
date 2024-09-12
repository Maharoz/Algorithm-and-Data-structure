using System.Collections.Concurrent;

namespace Sorting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[] {0,1,1,0,1,0,1,1,0,0,0,1};
			int result= PartitionZeroOne.Partition01(array,array.Length);
		
		}
	}
}
