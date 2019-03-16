namespace _01.GenericBoxOfString.Models
{
    public interface IBox<T>
    {
        T Value { get; }
    }
}
