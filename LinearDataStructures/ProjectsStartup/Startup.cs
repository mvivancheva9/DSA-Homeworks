namespace ProjectsStartup
{
    using AdtQueueProblem;
    using AdtStackProblem;
    using LineraDataStructures.Inputs;
    using LinkedListProblem;
    using LongestSubesuenceProblem;
    using MajorantProblem;
    using NegativeRemovalProblem;
    using OccurenceCountProblem;
    using OddOccurenceRemovalProblem;
    using SequenceMemberFinderProblem;
    using ShortestSequenceOfOperationsProblem;
    using SortListProblem;
    using StackReverseProblem;
    using SumAndAverageProblem;

    public class Startup
    {
        public static void Main(string[] args)
        {
            SumAndAverage.CalculateSumAndAverage();
            StackReverse.Reverse();
            SortList.Sort();
            LongestSubsequence.FindLongestSubsequence();
            NegativeRemoval.Remove();
            OddOccurenceRemoval.Remove();
            OccurenceCounter.Count();
            Majorant.FindMajorant();
            SequenceMemberFinder.Find();
            ShortestSequenceOfOperations.Find();
            Client.Print();
            ClientAdtClient.Operate();
            ClientAdtQueue.Operate();
        }
    }
}
