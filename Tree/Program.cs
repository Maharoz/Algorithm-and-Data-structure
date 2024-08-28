namespace Tree
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 1, 2, 3, 4, 5, 6, 7 };
			BinaryTree tree = new BinaryTree(array);
			//tree.InOrderTraversal(tree.root);
			tree.PrintBreadthFirstSearch();
		}
	}
}
