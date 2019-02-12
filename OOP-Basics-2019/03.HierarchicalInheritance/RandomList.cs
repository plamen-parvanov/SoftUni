namespace RandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        public string RandomString()
        {
            var randomPosition = new Random().Next(0, this.Count);
            var removedString = this[randomPosition];
            this.RemoveAt(randomPosition);

            return removedString;
        }
    }
}
