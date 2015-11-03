namespace MajorantProblem
{
    using System;
    using System.Collections.Generic;
    using LineraDataStructures.Inputs;

    public class Majorant
    {
        public static void FindMajorant()
        {
            Console.WriteLine("-----------Problem 08----------");
            Console.WriteLine("Please enter integers separated by coma");
            var input = Console.ReadLine();

            var result = new InputProcession(input).ConverToArray();

            Dictionary<int, int> majorantNumbers = new Dictionary<int, int>();

            for (int i = 0; i < result.Length; i++)
            {
                if (!majorantNumbers.ContainsKey(result[i]))
                {
                    majorantNumbers.Add(result[i], 1);
                }
                else
                {
                    majorantNumbers[result[i]]++;
                }
            }

            PrintArray(majorantNumbers, result.Length);
        }

        private static void PrintArray(Dictionary<int, int> dictionary, int size)
        {
            foreach (KeyValuePair<int, int> item in dictionary)
            {
                if (item.Value >= (size / 2) + 1)
                {
                    Console.WriteLine("{0} is majorant", item.Key);
                }
            }
        }
    }
}
