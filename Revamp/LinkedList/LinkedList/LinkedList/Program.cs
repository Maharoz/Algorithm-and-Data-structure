namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           LinkedList list = new LinkedList();
            list.addHead(1);
            list.addHead(2);
            list.addHead(3);
            list.Traverse();
    }
    }
}
