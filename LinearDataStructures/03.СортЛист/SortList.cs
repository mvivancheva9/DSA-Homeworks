namespace SortListProblem
{
    using System;
    using System.Linq;
    using LineraDataStructures.Inputs;

    public class SortList
    { 
        public static void Sort()
        {
            Console.WriteLine("-----------Problem 03----------");
            Console.WriteLine("Please enter integers separated by coma");
            var input = Console.ReadLine();

            var result = new InputProcession(input)
                .ConvertToListOfIntegers()
                .OrderBy(r => r);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
