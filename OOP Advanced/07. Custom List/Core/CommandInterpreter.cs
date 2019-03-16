namespace _07._Custom_List.Core
{
    using System.Text;

    using CustomLists.Contracts;

    public class CommandInterpreter<T>
    {
        private readonly StringBuilder outPutMessages;
        private readonly ICustomList<T> list;

        public CommandInterpreter(ICustomList<T> list)
        {
            this.outPutMessages = new StringBuilder();
            this.list = list;
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public void Remove(int index)
        {
            var removed = this.list.Remove(index);

            this.outPutMessages.AppendLine(removed.ToString());
        }

        public void Contains(T element)
        {
            var result = this.list.Contains(element);

            this.outPutMessages.AppendLine(result == true ? "True" : "False");
        }

        public void Swap(int index1, int index2)
        {
            this.list.Swap(index1, index2);
        }

        public void Greater(T element)
        {
           var result = this.list.CountGreaterThan(element);

            this.outPutMessages.AppendLine(result.ToString());
        }

        public void Max()
        {
            var result = this.list.Max();

            this.outPutMessages.AppendLine(result.ToString());
        }

        public void Min()
        {
            var result = this.list.Min();

            this.outPutMessages.AppendLine(result.ToString());
        }

        public void Print()
        {
            foreach (var element in this.list)
            {
                this.outPutMessages.AppendLine(element.ToString());
            }
        }

        public string GetOutPutMessages()
        {
            return this.outPutMessages.ToString().TrimEnd();
        }

    }
}
