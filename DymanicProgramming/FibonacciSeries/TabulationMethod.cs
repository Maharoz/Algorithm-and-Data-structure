using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
	public class TabulationMethod
	{
		public static int fibonaci(int num)
		{
			int[] dp = new int[num + 1];
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
