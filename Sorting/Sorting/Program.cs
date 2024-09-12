namespace Sorting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[] {6,4,5,1,8,2,9,7,3,10};
			QuickSort.sort(array);
			for (int i = 0; i < array.Length; i++) {
				Console.WriteLine(array[i]);
			}
		}
	}
}
