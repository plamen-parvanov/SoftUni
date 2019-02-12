namespace CustomStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StackOfStrings : List<string>
    {
        private List<string> data;

        public StackOfStrings()
        {
            this.data = new List<string>();
        }

        public void Push(string item)
        {
            this.data.Add(item);
        }

        public string Pop()
        {
            var lastElement = this.Peek();

            this.data.RemoveAt(this.data.Count - 1);

            return lastElement;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                throw new ArgumentNullException();
            }

            return  this.data.LastOrDefault();
        }

        public bool IsEmpty()
        {
            return this.data.Count == 0;
        }
    }
}
