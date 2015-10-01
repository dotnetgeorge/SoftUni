namespace CompanyHierarchy.Interfaces
{
    using Persons;
    using System;

    public interface IProject
    {
        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        /// <value>
        /// The name of the project.
        /// </value>
        string ProjectName { get; set; }
        /// <summary>
        /// Gets or sets the project start date.
        /// </summary>
        /// <value>
        /// The project start date.
        /// </value>
        DateTime ProjectStartDate { get; set; }
        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>
        /// The details.
        /// </value>
        string Details { get; set; }
        /// <summary>
        /// Gets or sets the state of the project.
        /// </summary>
        /// <value>
        /// The state of the project.
        /// </value>
        State ProjectState { get; set; }

        /// <summary>
        /// Closes the project.
        /// </summary>
        void CloseProject();
    }
}
