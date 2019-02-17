namespace _09.CollectionHierarchy.Controllers
{
    using System;
    using Models;
    using System.Text;

    public class Engine
    {
        private static AddCollection addCollection;
        private static AddRemoveCollection addRemoveCollection;
        private static MyList myList;
        private static StringBuilder sb;

        public Engine()
        {
            addCollection = new AddCollection();
            addRemoveCollection = new AddRemoveCollection();
            myList = new MyList();
            sb = new StringBuilder();
        }

        public void Run()
        {
            FillCollections();

            RemoveFromColleciotns();

            PrintResult();
        }

        private void PrintResult()
        {
            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private void RemoveFromColleciotns()
        {
            var itemsToRemove = int.Parse(Console.ReadLine());

            RemoveFrom(addRemoveCollection, itemsToRemove);
            RemoveFrom(myList, itemsToRemove);
        }

        private void RemoveFrom(AddRemoveCollection collection, int itemsToRemove)
        {
            for (int i = 0; i < itemsToRemove; i++)
            {
                sb.Append($"{collection.Remove()}");

                if (i < itemsToRemove - 1)
                {
                    sb.Append(" ");
                }
            }

            sb.AppendLine();
        }

        private void FillCollections()
        {
            var input = Console.ReadLine();

            Fill(addCollection, input);
            Fill(addRemoveCollection, input);
            Fill(myList, input);
        }

        private void Fill(AddCollection coletion, string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append($"{coletion.Add(arr[i])}");

                if (i < arr.Length - 1)
                {
                    sb.Append(" ");
                }
            }

            sb.AppendLine();
        }
    }
}
