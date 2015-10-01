namespace BookShop.Data
{
    public class GoldenEditionBook : Book
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoldenEditionBook"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="author">The author.</param>
        /// <param name="price">The price.</param>
        public GoldenEditionBook(string title, string author, double price) 
            : base(title, author, price)
        {
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public override double Price
        {
            get
            {
                return base.Price + (base.Price * 0.3);
            }
        }
    }
}
