namespace _01.GenericBoxOfString.Models
{
    using System;

    public class Box<T> : IBox<T>, IComparable<Box<T>> 
        where T : IComparable
    {
        public Box(T value)
        {
           this.Value = value;
        }

        public T Value { get; private set; }

        public int CompareTo(Box<T> other)
        {
           return  this.Value.CompareTo(other.Value);          
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {Value}";
        }
    }
}
