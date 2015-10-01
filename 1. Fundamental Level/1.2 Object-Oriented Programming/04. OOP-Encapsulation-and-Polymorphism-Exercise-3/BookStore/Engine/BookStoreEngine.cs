using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.Books;

namespace BookStore.Engine
{
    public class BookStoreEngine
    {
        private readonly List<Book> _books;

        public BookStoreEngine()
        {
            IsRunning = true;
            _books = new List<Book>();
            Revenue = 0;
        }

        public decimal Revenue { get; private set; }
        public bool IsRunning { get; private set; }

        public void Run()
        {
            while (IsRunning)
            {
                var command = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(command))
                {
                    continue;
                }

                var commandArgs = command.Split();

                var commandResult = ExecuteCommand(commandArgs);

                Console.WriteLine(commandResult);
            }

            Console.WriteLine("Total revenue: {0:F2}", Revenue);
        }

        private string ExecuteCommand(string[] commandArgs)
        {
            if (commandArgs == null) throw new ArgumentNullException(nameof(commandArgs));
            switch (commandArgs[0])
            {
                case "add":
                    return ExecuteAddBookCommand(commandArgs);
                case "sell":
                    return ExecuteSellBookCommand(commandArgs);
                case "remove":
                    return ExecuteRemoveBookCommand(commandArgs);
                case "stop":
                    IsRunning = false;
                    return "Goodbye!";
                default:
                    return "Unknown command";
            }
        }

        private string ExecuteSellBookCommand(IReadOnlyList<string> commandArgs)
        {
            var bookToSell = _books.FirstOrDefault(book => book.Title == commandArgs[1]);

            if (bookToSell != null) Revenue += bookToSell.Price;
            return "Book sold";
        }

        private string ExecuteRemoveBookCommand(IReadOnlyList<string> commandArgs)
        {
            var title = commandArgs[1];

            if (_books == null) return "Book removed";
            var bookToRemove = _books.FirstOrDefault(book => book.Title == title);

            if (bookToRemove == null)
            {
                return "Book does not exist";
            }

            _books.Remove(bookToRemove);

            return "Book removed";
        }

        private string ExecuteAddBookCommand(IReadOnlyList<string> commandArgs)
        {
            var title = commandArgs[1];
            var author = commandArgs[2];
            var price = decimal.Parse(commandArgs[3]);

            _books.Add(new Book(title, author, price));

            return "Book added";
        }
    }
}