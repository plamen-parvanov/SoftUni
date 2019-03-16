namespace _07._Custom_List.CustomLists.Contracts
{
    using System.Collections.Generic;

    public interface ICustomList<T>
    {
        void Add(T element);

        T Remove(int index);

        bool Contains(T element);

        void Swap(int index1, int index2);

        int CountGreaterThan(T element);

        T Max();

        T Min();

        IEnumerator<T> GetEnumerator();
    }
}
