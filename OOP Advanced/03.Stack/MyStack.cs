namespace _03.StackWithNode
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyStack<T> : IEnumerable<T>
    {
        public MyStack()
        {
            this.LastElement = null;
        }

        public Node<T> LastElement { get; private set; }

        public void Push(T value)
        {
            var tempNode = this.LastElement;
            this.LastElement = new Node<T>(value);

            if (tempNode != null)
            {
                this.LastElement.PreviousNode = tempNode;
            }
        }

        public void Pop()
        {
            if (this.LastElement == null)
            {
                throw new InvalidOperationException("No elements");
            }

            this.LastElement = this.LastElement.PreviousNode;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.LastElement;

            while (currentNode != null)
            {
                yield return currentNode.Value;

                currentNode = currentNode.PreviousNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
