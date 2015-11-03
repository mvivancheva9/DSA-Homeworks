namespace OccurenceCountProblem
{
    using System;
    using System.Collections.Generic;
    using LineraDataStructures.Inputs;

    public class OccurenceCounter
    {
        public static void Count()
        {
            Console.WriteLine("-----------Problem 07----------");
            Console.WriteLine("Please enter integers separated by coma");
            var input = Console.ReadLine();

            var result = new InputProcession(input).ConverToArray();
            var occurences = new Dictionary<int, int>();
            for (int i = 0; i < result.Length; i++)
            {
                if (!occurences.ContainsKey(result[i]))
                {
                    occurences.Add(result[i], 1);
                }
                else
                {
                    occurences[result[i]]++;
                }
            }

            PrintArray(occurences);
        }

        private static void PrintArray(Dictionary<int, int> dictionary)
        {
            foreach (KeyValuePair<int, int> item in dictionary)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
