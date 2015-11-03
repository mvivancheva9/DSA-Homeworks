namespace AdtQueueProblem
{
    using System;

    public class ClientAdtQueue
    {
        public static void Operate()
        {
            var testQueue = new Queue<int>();

            testQueue.Enqueue(10);
            testQueue.Enqueue(20);
            testQueue.Enqueue(30);

            while (testQueue.HasElements())
            {
                Console.WriteLine(testQueue.Dequeue());
            }
        }
    }
}
