namespace BookShop.Data
{
    using System;
    using System.Text;

    public class Book
    {
        private string title;
        private string author;
        private double price;

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="author">The author.</param>
        /// <param name="price">The price.</param>
        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        /// <exception cref="ArgumentNullException">Title can't be null or empty!</exception>
        public string Title
        {
            get
            {
                return this.title;
            }
            protected set
            {
                if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title can't be null or empty!");
                }

                this.title = value;
            }
        }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        /// <value>
        /// The author.
        /// </value>
        /// <exception cref="ArgumentNullException">Author name can't be null or empty!</exception>
        public string Author
        {
            get
            {
                return this.author;
            }
            protected set
            {
                if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Author name can't be null or empty!");
                }

                this.author = value;
            }
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">Book price can't be under 1.00lv.!</exception>
        public virtual double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value < 1.00)
                {
                    throw new ArgumentOutOfRangeException("Book price can't be under 1.00lv.!");
                }

                this.price = value;
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendFormat("Title: {0}{1}", Title, Environment.NewLine);
            output.AppendFormat("Author: {0}{1}", Author, Environment.NewLine);
            output.AppendFormat("Price: {0:F2}{1}", Price, Environment.NewLine);

            return output.ToString();
        }
    }
}
