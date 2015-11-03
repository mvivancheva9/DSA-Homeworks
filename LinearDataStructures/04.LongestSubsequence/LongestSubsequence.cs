namespace LongestSubesuenceProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LineraDataStructures.Inputs;

    public class LongestSubsequence
    {
        public static void FindLongestSubsequence()
        {
            Console.WriteLine("-----------Problem 04----------");
            Console.WriteLine("Please enter integers separated by coma");
            var input = Console.ReadLine();

            var result = new InputProcession(input)
                .ConvertToListOfIntegers();

            var currentSequenceLenght = 1;
            var overallSequenceLenght = 1;
            var elementWithLongestSequence = 0;

            for (int i = 1; i < result.Count(); i++)
            {
                var currentElement = result.ElementAt(i);

                if (currentElement == result.ElementAt(i - 1))
                {
                    currentSequenceLenght++;
                }
                else
                {
                    currentSequenceLenght = 1;
                }

                if (currentSequenceLenght > overallSequenceLenght)
                {
                    elementWithLongestSequence = currentElement;
                    overallSequenceLenght = currentSequenceLenght;
                }
            }

            List<int> longestSequence = new List<int>();

            for (int i = 0; i < overallSequenceLenght; i++)
            {
                longestSequence.Add(elementWithLongestSequence);
                Console.WriteLine(longestSequence.ElementAt(i));
            }
        }
    }
}
