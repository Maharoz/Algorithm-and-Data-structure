using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
	public class TreeNode
	{
		public int value;
		public TreeNode right;
		public TreeNode left;

		public TreeNode(int value) { 
		 this.value = value;
		this.right = null;
		this.left = null;
		}
	}
}
