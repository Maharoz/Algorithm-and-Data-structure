using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	public static class DeleteMiddleOfTheStack
	{
		public static void deleteMid(Stack<int> s, int sizeOfStack)
		{
			// code here
			if(sizeOfStack==0) return;

			void DeletemidRecursive(Stack<int> s, int mid, int current)
			{
				if(mid==current)
				{
					s.Pop();
					return;
				};

				int temp = s.Pop();

				DeletemidRecursive(s, mid, current+1);
				s.Push(temp);
			}


			int mid = sizeOfStack / 2;

			DeletemidRecursive(s, 0, mid);

		}
	}
}
