namespace CompanyHierarchy.Interfaces
{
    using Persons;
    using System.Collections.Generic;

    public interface IManager
    {
        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        IList<Employee> Employees { get; set; }
    }
}
