namespace SequenceMemberFinderProblem
{
    using System;
    using System.Collections.Generic;

    public class SequenceMemberFinder
    {
        public static void Find()
        {
            int n = 2;
            var elementToFind = 50;
            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(n);
            int member = 0;
            while (sequence.Count > 0)
            {
                int currentMember = sequence.Dequeue();
                member++;
                if (currentMember == elementToFind)
                {
                    Console.WriteLine("Sequence Member = {0}", member);
                    return;
                }

                sequence.Enqueue(currentMember + 1);
                sequence.Enqueue(2 * currentMember);
            }
        }
    }
}
