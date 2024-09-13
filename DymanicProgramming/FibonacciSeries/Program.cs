namespace FibonacciSeries
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x= fibonaci(6);
            Console.WriteLine(x);
		}

		public static int fibonaci(int num)
		{
			int[] dp = new int[num+1];
			dp[0] = 0;
			dp[1] = 1;


			for (int i = 2; i <= num; i++)
			{
				dp[i] = dp[i - 1] + dp[i - 2];
			}
			return dp[num];
		}
	}
}
