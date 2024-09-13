namespace ArrayOperation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			long[] arr = { 0, 3, 1, 2 };
			List<int> x = ArrayDuplicate.duplicates(arr, 6);
			foreach (int i in x) {
                Console.WriteLine(i);
			}
		}
	}
}
