namespace BookStore.Books
{
    using System;

    public class Book
    {
        private string _title;
        private string _author;
        private decimal _price;

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public string Title
        {
            get
            {
                return _title;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Book title cannot be null, empty or whitespace.");
                }

                _title = value;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Book author cannot be null, empty or whitespace.");
                }

                _author = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Book price cannot be negative.");
                }

                _price = value;
            }
        }
    }
}
