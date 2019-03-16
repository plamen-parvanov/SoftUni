namespace _04.Froggy.Models
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private readonly IList<int> stones;

        public Lake(IEnumerable<int> stones)
        {
            this.stones = new List<int>(stones);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i+=2)
            {
                yield return this.stones[i];
            }

            var lastIndex = this.stones.Count -1;
            var lastOddIndex = lastIndex % 2 == 0 ? --lastIndex : lastIndex;

            for (int i = lastOddIndex; i > 0; i-=2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
