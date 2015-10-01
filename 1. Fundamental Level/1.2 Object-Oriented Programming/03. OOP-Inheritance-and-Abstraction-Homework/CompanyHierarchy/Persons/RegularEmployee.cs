namespace CompanyHierarchy.Persons
{
    using System.Text;

    public class RegularEmployee : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegularEmployee"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="department">The department.</param>
        public RegularEmployee(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {

        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var regularEmployee = new StringBuilder();

            regularEmployee.AppendLine("Regular Employee Info");
            regularEmployee.Append(base.ToString());

            return base.ToString();
        }
    }
}