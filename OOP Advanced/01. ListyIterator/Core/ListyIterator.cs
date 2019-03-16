namespace _01._ListyIterator.Core
{
    using _01._ListyIterator.Validators;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly T[] data;
        private int index;

        public ListyIterator(T[] data)
        {
            this.data = data;
            this.index = 0;
        }

        

        public bool HasNext()
        {
            return this.data.Length - 1 > this.index;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.index++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            Validator.CheckForEmptyCollection(this.data.Length);

            Console.WriteLine(this.data[this.index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Length; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
