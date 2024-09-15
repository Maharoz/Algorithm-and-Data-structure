namespace KadaneAlgorithm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] input = { 1, 2, 3, -2, 5 };
			maxSubarraySum(input);
		}

		public static int maxSubarraySum(int[] arr)
		{

			// Your code here
			int maxSoFar = arr[0];
			int maxEndingHere = arr[0];

			for (int i = 1; i < arr.Length; i++)
			{
				maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);

				maxSoFar = Math.Max(maxSoFar, maxEndingHere);
			}
			return maxSoFar;
		}
	}
}
