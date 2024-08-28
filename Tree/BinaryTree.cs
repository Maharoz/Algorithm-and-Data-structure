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

			root = BuildTree(arr, 0);
		}
		private TreeNode BuildTree(int[] array, int index)
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

			TreeNode node = new TreeNode(array[index]);

			node.left = BuildTree(array, 2 * index + 1);
			node.right = BuildTree(array, 2 * index + 2);
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

		public void PreOrderTraversal(TreeNode node)
		{
			if (root == null)
			{
				return;
			}
			Console.WriteLine(root.value);
			PreOrderTraversal(root.left);
			PreOrderTraversal(root.right);
		}

		public void PostOrderTraversal(TreeNode node)
		{
			if (root == null)
			{
				return;
			}

			PostOrderTraversal(root.left);
			PostOrderTraversal(root.right);
			Console.WriteLine(root.value);
		}

		public void PrintBreadthFirstSearch()
		{
			//         1
			///       / \
			//       2   3
			//      / \ / \
			//    4  5 6   7
			Queue<TreeNode> queue = new Queue<TreeNode>();
			TreeNode temp;

			if (root != null)
			{
				queue.Enqueue(root);
			}

			while (queue.Count > 0)
			{
				temp = queue.Dequeue();

				Console.WriteLine(temp.value);

				if (temp.left != null)
				{
					queue.Enqueue(temp.left);
				}
				if (temp.right != null)
				{

					queue.Enqueue(temp.right);

				}

			}
		}

		public void DFSWithoutRecursion()
		{
			Stack<TreeNode> stack = new Stack<TreeNode>();
			TreeNode temp;

			if (root != null)
			{
				stack.Push(root);
			}
			while (stack.Count > 0)
			{
				temp = stack.Pop();
				Console.WriteLine(temp.value);
				if(temp.left != null)
				{
					stack.Push(temp.left);
				}
				if(temp.right != null)
				{
					stack.Push(temp.right);
				}
			}
		}
	}
}
