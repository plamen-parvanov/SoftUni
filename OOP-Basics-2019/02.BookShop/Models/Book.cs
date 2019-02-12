namespace _02.BookShop.Models
{
    using _02.BookShop.Errors;
    using System;
    using System.Text;

    public class Book
    {
        private const int MIN_TITLE_LENGHT = 3;
        private const int MIN_PRICE = 0;

        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            private set
            {
                if (IsSecondNameStartsWithDigit(value))
                {
                    ThrowException(nameof(this.Author));
                }
                this.author = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                if (value.Length < MIN_TITLE_LENGHT)
                {
                    ThrowException(nameof(this.Title));
                }

                this.title = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value <= MIN_PRICE)
                {
                    ThrowException(nameof(this.Price));
                }

                this.price = value;
            }
        }

        private void ThrowException(string name)
        {
            throw new ArgumentException(
                          string.Format(ErrorMessage.InvalidArgument, name));
        }

        private bool IsSecondNameStartsWithDigit(string value)
        {
            var arr = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (arr.Length > 1)
            {
                var secondName = arr[1];

                return char.IsDigit(secondName[0]);
            }

            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Title: {this.Title}");
            sb.AppendLine($"Author: {this.Author}");
            sb.AppendLine($"Price: {this.Price:F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
