namespace AdtStackProblem
{
    public class Stack<T>
    {
        private const int InitialStackSize = 4;
        private T[] elements;
        private int top;

        public Stack()
        {
            this.elements = new T[InitialStackSize];
            this.top = 0;
        }

        public int Length
        {
            get { return this.top; }
        }

        public void Push(params T[] values)
        {
            foreach (var value in values)
            {
                if (this.IsFull())
                {
                    var biggerElements = new T[this.elements.Length * 2];

                    for (int i = 0; i < this.elements.Length; i++)
                    {
                        biggerElements[i] = this.elements[i];
                    }

                    this.elements = biggerElements;
                }

                this.elements[this.top++] = value;
            }
        }

        public T Pop()
        {
            return this.elements[--this.top];
        }

        private bool IsFull()
        {
            return this.elements.Length == this.top;
        }

        private bool IsEmpty()
        {
            return this.top == 0;
        }
    }
}