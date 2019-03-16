namespace _07._Custom_List.CustomLists
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;

    public class CustomList<T> : ICustomList<T>, IComparable<T>, IEnumerable<T>
        where T : IComparable
    {
        private readonly List<T> data;

        public CustomList()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public bool Contains(T element)
        {
            return this.data.Contains(element);
        }

        public int CountGreaterThan(T element)
        {
            var greaterElements = this.data
                                      .Where(e => (e.CompareTo(element)) > 0)
                                      .Count();

            return greaterElements;
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public T Remove(int index)
        {
            var removed = this.data[index];

            this.data.RemoveAt(index);

            return removed;
        }

        public void Swap(int index1, int index2)
        {
            var temp = this.data[index1];

            this.data[index1] = this.data[index2];
            this.data[index2] = temp;
        }

        public int CompareTo(T other)
        {
            return this.CompareTo(other);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
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
