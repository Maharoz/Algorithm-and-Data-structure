using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tree
{
	public class BinaryTree
	{
		public TreeNode root;
		public BinaryTree(int[] arr)
		{
			if (arr == null || arr.Length == 0)
			{
				return;
			}

			root = buildtree(arr, 0);
		}
		private TreeNode buildtree(int[] array,int index)
		{
			//int[] array = { 1, 2, 3, 4, 5, 6, 7 };

				//         1
				///       / \
				//       2   3
				//      / \ / \
				 //    4  5 6  7
			if (index >= array.Length)
			{
				return null;
			}

			TreeNode node= new TreeNode(array[index]);	

			node.left=buildtree(array, 2*index+1) ;
			node.right=buildtree(array, 2*index+2);
			return node;
		}

		public void InOrderTraversal(TreeNode root)
		{

			if (root == null)
			{
				return;
			}

			InOrderTraversal(root.left);
            Console.WriteLine(root.value);
            InOrderTraversal(root.right);
		}

		public void PreOrder(TreeNode node)
		{
			if (root == null)
			{
				return;
			}

			Console.WriteLine(root.value);
			PreOrder(root.left);
			PreOrder(root.right);
		}
	}
}
