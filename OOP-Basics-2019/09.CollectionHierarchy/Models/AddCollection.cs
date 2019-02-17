namespace _09.CollectionHierarchy.Models
{
    using Contracts;
    using System.Collections.Generic;

    public class AddCollection : IAddCollection
    {
        protected readonly List<string> data;

        public AddCollection()
        {
            this.data = new List<string>();
        }

        public IReadOnlyCollection<string> Data => this.data;      

        public virtual int Add(string item)
        {
            var indexItemAdded = this.data.Count;

            this.data.Add(item);

            return indexItemAdded;
        }
    }
}
