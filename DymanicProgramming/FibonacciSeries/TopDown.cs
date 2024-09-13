using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
	public class TopDown
	{
		public static int fibonaci(int n, int[] dp)
		{
			//base case 
			if (n < 1)
			{
				return n;
			}
			if (dp[n] != -1)
			{
				return dp[n];
			}
			dp[n]=fibonaci(n-1,dp)+fibonaci(n-2,dp);
			return dp[n];

		}
		}
}
