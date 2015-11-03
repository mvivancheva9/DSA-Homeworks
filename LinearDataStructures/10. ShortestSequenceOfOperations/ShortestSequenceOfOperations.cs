namespace ShortestSequenceOfOperationsProblem
{
    using System;
    using System.Collections.Generic;

    public class ShortestSequenceOfOperations
    {
        public static void Find()
        {
            int startElement = 5;
            var endElement = 16;
            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(endElement);
            int operations = 0;
            while (startElement < endElement)
            {
                int currentMember = sequence.Dequeue();
                if (currentMember == startElement)
                {
                    Console.WriteLine("Number of operations = {0}", operations);
                    return;
                }

                if (currentMember % 2 == 0 && currentMember / 2 >= startElement)
                {
                    sequence.Enqueue(currentMember / 2);
                }
                else if (currentMember - 1 == startElement || currentMember % 2 == 1)
                {
                    sequence.Enqueue(currentMember - 1);
                }
                else
                {
                    sequence.Enqueue(currentMember - 2);
                }

                operations++;
            }
        }
    }
}
