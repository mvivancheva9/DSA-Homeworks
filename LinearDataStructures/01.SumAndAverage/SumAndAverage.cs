/*
Write a program that reads from the console a sequence of positive integer numbers.

The sequence ends when empty line is entered.
Calculate and print the sum and average of the elements of the sequence.
Keep the sequence in List<int>.
*/
namespace SumAndAverageProblem
{
    using System;
    using System.Linq;
    using LineraDataStructures.Inputs;

    public class SumAndAverage
    {
        public static void CalculateSumAndAverage()
        {
            Console.WriteLine("-----------Problem 01----------");
            Console.WriteLine("Please enter integers separated by coma");
            var input = Console.ReadLine();

            var result = new InputProcession(input).ConvertToListOfIntegers();

            Console.WriteLine("Sum = {0}", result.Sum());
            Console.WriteLine("Average = {0}", result.Average());
        }
    }
}
