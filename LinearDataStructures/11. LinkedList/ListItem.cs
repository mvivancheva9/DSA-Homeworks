﻿namespace LinkedListProblem
{
    public class ListItem<T>
    {
        public ListItem(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public ListItem<T> Next { get; set; }       
    }
}
