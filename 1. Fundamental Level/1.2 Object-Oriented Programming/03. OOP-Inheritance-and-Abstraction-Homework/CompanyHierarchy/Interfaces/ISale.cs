namespace CompanyHierarchy.Interfaces
{
    using System;

    public interface ISale
    {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>
        /// The name of the product.
        /// </value>
        string ProductName { get; set; }
        /// <summary>
        /// Gets or sets the product date.
        /// </summary>
        /// <value>
        /// The product date.
        /// </value>
        DateTime ProductDate { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        double Price { get; set; }
    }
}
