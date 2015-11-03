namespace LinkedListProblem
{
    using System;

    public class Client
    {
        public static void Print()
        {
            LinkedList<int> numbers = new LinkedList<int>();
            var first = new ListItem<int>(1);
            var next = new ListItem<int>(10);
            first.Next = next;
            numbers.FirstElement = first;

            Console.WriteLine("First item in the list: {0}", numbers.FirstElement.Value);
            Console.WriteLine("Next item: {0}", first.Next.Value);
        }
    }
}
