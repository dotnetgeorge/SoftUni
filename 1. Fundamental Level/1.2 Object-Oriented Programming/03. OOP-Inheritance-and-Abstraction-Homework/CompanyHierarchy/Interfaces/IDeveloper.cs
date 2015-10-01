namespace CompanyHierarchy.Interfaces
{
    using Persons;
    using System.Collections.Generic;

    public interface IDeveloper
    {
        /// <summary>
        /// Gets or sets the projects.
        /// </summary>
        /// <value>
        /// The projects.
        /// </value>
        IList<Project> Projects { get; set; }
    }
}
