using _09.CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CollectionHierarchy.Models
{
    public class MyList : AddRemoveCollection, IMyList
    {
        public  override string Remove()
        {
            var indexToRemoveAt = 0;
            var removedEllement = this.data[indexToRemoveAt];
            this.data.RemoveAt(indexToRemoveAt);

            return removedEllement;
        }

        public int Used => this.data.Count;
    }
}
