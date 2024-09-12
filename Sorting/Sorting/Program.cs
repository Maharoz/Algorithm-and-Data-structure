namespace Sorting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[] {5,6,2,4,7,3,1};
			SelectionSort.Sort(array);
			for (int i = 0; i < array.Length; i++) {
				Console.WriteLine(array[i]);
			}
		}
	}
}
