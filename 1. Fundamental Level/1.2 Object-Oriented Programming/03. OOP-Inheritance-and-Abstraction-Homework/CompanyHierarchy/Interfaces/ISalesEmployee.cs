namespace CompanyHierarchy.Interfaces
{
    using Persons;
    using System.Collections.Generic;

    public interface ISalesEmployee
    {
        /// <summary>
        /// Gets or sets the sales.
        /// </summary>
        /// <value>
        /// The sales.
        /// </value>
        IList<Sale> Sales { get; set; }
    }
}
