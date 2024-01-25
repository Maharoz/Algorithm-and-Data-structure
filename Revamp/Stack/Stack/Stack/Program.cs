namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.push(1);
            s.push(2);
            s.push(3);
            s.push(5);
            s.push(6);
            // s.bottomInsert(s,4);
            s.ReverseStack(s);
            s.print();
        }
     
    }
}
