namespace CompanyHierarchy.Persons
{
    using Interfaces;
    using System;
    using System.Text;

    public enum State
    {
        Open,
        Closed
    }

    public class Project : IProject
    {
        private string _projectName;
        private DateTime _projectStartDate;
        private string _details;
        private State _projectState;

        /// <summary>
        /// Initializes a new instance of the <see cref="Project"/> class.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="projectStartDate">The project start date.</param>
        /// <param name="details">The details.</param>
        /// <param name="projectState">State of the project.</param>
        public Project(string projectName, DateTime projectStartDate, string details, State projectState)
        {
            ProjectName = projectName;
            ProjectStartDate = projectStartDate;
            Details = details;
            ProjectState = projectState;
        }

        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        /// <value>
        /// The name of the project.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Project name can't be null or empty!</exception>
        public string ProjectName
        {
            get
            {
                return _projectName;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Project name can't be null or empty!");
                }

                _projectName = value;
            }
        }

        /// <summary>
        /// Gets or sets the project start date.
        /// </summary>
        /// <value>
        /// The project start date.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Project start year should be in range [1950..{0}]!</exception>
        public DateTime ProjectStartDate
        {
            get
            {
                return _projectStartDate;
            }
            set
            {
                if(value.Year < 1950 || DateTime.Now.Year < value.Year)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Project start year should be in range [1950..{0}]!", DateTime.Now.Year.ToString());
                }

                _projectStartDate = value;
            }
        }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>
        /// The details.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Details can't be null or empty!</exception>
        public string Details
        {
            get
            {
                return _details;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Details can't be null or empty!");
                }

                _details = value;
            }
        }

        /// <summary>
        /// Gets or sets the state of the project.
        /// </summary>
        /// <value>
        /// The state of the project.
        /// </value>
        /// <exception cref="System.ArgumentException">Project</exception>
        public State ProjectState
        {
            get
            {
                return _projectState;
            }
            set
            {
                //if(value != State.Open || value != State.Closed)
                //{
                //    throw new ArgumentException("Project");
                //}

                _projectState = value;
            }
        }

        /// <summary>
        /// Closes the project.
        /// </summary>
        public void CloseProject()
        {
            ProjectState = State.Closed;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var project = new StringBuilder();

            project.AppendLine("Project Info");
            project.AppendFormat("Name: {0}{1}", ProjectName, Environment.NewLine);
            project.AppendFormat("Start Date: {0:d}{1}", ProjectStartDate, Environment.NewLine);
            project.AppendFormat("Details: {0}{1}", Details, Environment.NewLine);
            project.AppendFormat("State: {0}{1}", ProjectState, Environment.NewLine);

            return project.ToString();
        }
    }
}
