namespace CompanyHierarchy.Persons
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Developer : Employee, IDeveloper
    {
        /// <summary>
        /// The projects
        /// </summary>
        private IList<Project> _projects;

        /// <summary>
        /// Initializes a new instance of the <see cref="Developer"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="department">The department.</param>
        public Developer(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
            Projects = new List<Project>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Developer"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="department">The department.</param>
        /// <param name="projects">The projects.</param>
        public Developer(int id, string firstName, string lastName, double salary, Department department, IList<Project> projects)
            : base(id, firstName, lastName, salary, department)
        {
            Projects = projects;
        }

        /// <summary>
        /// Gets or sets the projects.
        /// </summary>
        /// <value>
        /// The projects.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Developer should have at least one project!</exception>
        public IList<Project> Projects
        {
            get
            {
                return _projects;
            }
            set
            {
                if(value.Count < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Developer should have at least one project!");
                }

                _projects = value;
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
            var developer = new StringBuilder();

            developer.AppendLine("Developer Info");
            developer.Append(base.ToString());
            developer.AppendLine("Developer's Projects");

            foreach (var project in Projects)
            {
                developer.Append(project);
            }

            return developer.ToString();
        }
    }
}
