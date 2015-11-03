namespace NegativeRemovalProblem
{
    using System;
    using System.Linq;
    using LineraDataStructures.Inputs;

    public class NegativeRemoval
    {
        public static void Remove()
        {
            Console.WriteLine("-----------Problem 05----------");
            Console.WriteLine("Please enter integers separated by coma");
            var input = Console.ReadLine();

            var result = new InputProcession(input)
                .ConvertToListOfIntegers();

            for (int i = 0; i < result.Count(); i++)
            {
                if (result.ElementAt(i) < 0)
                {
                    result.RemoveAt(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
