namespace _09.CollectionHierarchy.Models
{
    using Contracts;

    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
        public override int Add(string item)
        {
            var indexItemAdded = 0;

            this.data.Insert(indexItemAdded, item);

            return indexItemAdded;
        }

        public virtual string Remove()
        {
            var lastIndex = this.data.Count - 1;
            var removedEllement = this.data[lastIndex];
            this.data.RemoveAt(lastIndex);

            return removedEllement;
        }
    }
}
