namespace OddOccurenceRemovalProblem
{
    using System;
    using System.Linq;
    using LineraDataStructures.Inputs;

    public class OddOccurenceRemoval
    {
        public static int CurrentElement { get; set; }

        public static void Remove()
        {
            Console.WriteLine("-----------Problem 06----------");
            Console.WriteLine("Please enter integers separated by coma");
            var input = Console.ReadLine();

            var result = new InputProcession(input)
                .ConvertToListOfIntegers();

            var currentSequenceLenght = 0;

            for (int i = 0; i < result.Count(); i++)
            {
                CurrentElement = result.ElementAt(i);

                for (int k = 0; k < result.Count(); k++)
                {
                    var elemetToCheck = result.ElementAt(k);
                    if (result.ElementAt(k) == result.ElementAt(i))
                    {
                        currentSequenceLenght++;
                    }
                }

                if (currentSequenceLenght % 2 == 1)
                {
                    result.RemoveAll(IsEqual);
                    i = i - 1;
                }

                currentSequenceLenght = 0;
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static bool IsEqual(int s)
        {
            return s == CurrentElement;
        }
    }
}
