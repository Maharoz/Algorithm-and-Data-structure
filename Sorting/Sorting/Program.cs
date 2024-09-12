namespace Sorting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[] { 9,8,7,6,9,1,5,2 };
			BubbleSort.bubblesort(array);
			for (int i = 0; i < array.Length; i++) {
				Console.WriteLine(array[i]);
			}
		}
	}
}
