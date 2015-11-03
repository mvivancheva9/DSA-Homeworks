namespace LineraDataStructures.Inputs
{
    using System.Collections.Generic;
    using System.Linq;

    public class InputProcession
    {
        private string input;

        public InputProcession(string input)
        {
            this.Input = input;
        }

        public string Input
        {
            get
            {
                return this.input;
            }

            set
            {
                this.input = value;
            }
        }

        public List<int> ConvertToListOfIntegers()
        {
            var result = this.input.Split(',').Select(int.Parse).ToList();

            return result;
        }

        public Stack<int> ConvertToStaclOfIntegers()
        {
            var result = new Stack<int>();

            var inputNumbers = this.input.Split(',').Select(int.Parse);

            foreach (var inputNumber in inputNumbers)
            {
                result.Push(inputNumber);
            }

            return result;
        }

        public int[] ConverToArray()
        {
            var inputNumbers = this.input.Split(',');
            var result = new int[inputNumbers.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                result[i] = int.Parse(inputNumbers[i]);
            }

            return result;
        }
    }
}
