namespace AdtStackProblem
{
    using System;

    public class ClientAdtClient
    {
        public static void Operate()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(5, 8, 55, 69, 4);

            while (stack.Length > 0)
            {
                Console.Write(stack.Pop() + (stack.Length != 0 ? " -> " : string.Empty));
            }

            Console.WriteLine();
        }
    }
}
