namespace StackReverseProblem
{
    using System;
    using LineraDataStructures.Inputs;

    public class StackReverse
    {
        public static void Reverse()
        {
            Console.WriteLine("-----------Problem 02----------");
            Console.WriteLine("Please enter integers separated by coma");
            var input = Console.ReadLine();

            var result = new InputProcession(input).ConvertToStaclOfIntegers();
            while (result.Count > 0)
            {
                Console.WriteLine(result.Pop());
            }
        }
    }
}
