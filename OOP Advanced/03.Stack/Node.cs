namespace _03.StackWithNode
{
    public class Node<T>
    {
        public Node(T value)
        {
            this.PreviousNode = null;
            this.Value = value;
        }

        public Node<T> PreviousNode { get; set; }

        public T Value { get; set; }
    }
}
