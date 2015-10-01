namespace CompanyHierarchy.Persons
{
    using Interfaces;
    using System;
    using System.Text;

    public class Sale : ISale
    {
        private string _productName;
        private DateTime _productDate;
        private double _price;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sale"/> class.
        /// </summary>
        /// <param name="productName">Name of the product.</param>
        /// <param name="productDate">The product date.</param>
        /// <param name="price">The price.</param>
        public Sale(string productName, DateTime productDate, double price)
        {
            ProductName = productName;
            ProductDate = productDate;
            Price = price;
        }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>
        /// The name of the product.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Product name can't be null or empty!</exception>
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Product name can't be null or empty!");
                }

                _productName = value;
            }
        }

        /// <summary>
        /// Gets or sets the product date.
        /// </summary>
        /// <value>
        /// The product date.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Product year shoud be in range [1950..{0}]!</exception>
        public DateTime ProductDate
        {
            get
            {
                return _productDate;
            }
            set
            {
                if(value.Year < 1950 || DateTime.Now.Year < value.Year)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Product year shoud be in range [1950..{0}]!", DateTime.Now.Year.ToString());
                }

                _productDate = value;
            }
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Product price can't be under 1lv.!</exception>
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value < 1.00)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Product price can't be under 1lv.!");
                }

                _price = value;
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
            var sale = new StringBuilder();

            sale.AppendLine("Sale Info");
            sale.AppendFormat("Name: {0}{1}", ProductName, Environment.NewLine);
            sale.AppendFormat("Date: {0:d}{1}", ProductDate, Environment.NewLine);
            sale.AppendFormat("Price: {0:F2}lv.{1}", Price, Environment.NewLine);

            return sale.ToString();
        }
    }
}
