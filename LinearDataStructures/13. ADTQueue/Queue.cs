namespace AdtQueueProblem
{
    using System.Collections.Generic;

    public class Queue<T>
    {
        private const int InitalListLength = 4;

        private readonly LinkedList<T> elements;

        public Queue()
        {
            this.elements = new LinkedList<T>();
        }

        public void Enqueue(T value)
        {
            if (this.elements.First == null)
            {
                this.elements.AddFirst(value);
                return;
            }

            this.elements.AddBefore(this.elements.First, value);
        }

        public T Dequeue()
        {
            var last = this.elements.Last;
            this.elements.RemoveLast();

            return last.Value;
        }

        public bool HasElements()
        {
            return this.elements.Count != 0;
        }
    }
}