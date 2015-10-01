namespace CompanyHierarchy.Interfaces
{
    using Persons;

    public interface IEmployee
    {
        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        double Salary { get; set; }
        /// <summary>
        /// Gets or sets the selected department.
        /// </summary>
        /// <value>
        /// The selected department.
        /// </value>
        Department SelectedDepartment { get; set; }
    }
}
