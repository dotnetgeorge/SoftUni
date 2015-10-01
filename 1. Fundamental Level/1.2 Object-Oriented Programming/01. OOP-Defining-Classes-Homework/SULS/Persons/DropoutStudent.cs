using System.Text;

namespace SULS.Persons
{
    using System;

    public class DropoutStudent : Student
    {
        private string _dropoutReason;

        /// <summary>
        /// Initializes a new instance of the <see cref="DropoutStudent"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        /// <param name="studentNumber">The student number.</param>
        /// <param name="averageGrade">The average grade.</param>
        /// <param name="dropoutReason">The dropout reason.</param>
        public DropoutStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            DropoutReason = dropoutReason;
        }

        /// <summary>
        /// Gets or sets the dropout reason.
        /// </summary>
        /// <value>
        /// The dropout reason.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Dropout reason can not be null or empty!</exception>
        public string DropoutReason
        {
            get { return _dropoutReason; }
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Dropout reason can not be null or empty!");
                }

                _dropoutReason = value;
            }
        }

        /// <summary>
        /// Reapplies this instance.
        /// </summary>
        public void Reapply()
        {
            var student = new StringBuilder();

            student.AppendLine("Student Info");
            student.AppendFormat("First name: {0}{1}", FirstName, Environment.NewLine);
            student.AppendFormat("Last name: {0}{1}", LastName, Environment.NewLine);
            student.AppendFormat("Age: {0}{1}", Age, Environment.NewLine);
            student.AppendFormat("Student number: {0}{1}", StudentNumber, Environment.NewLine);
            student.AppendFormat("Average grade: {0}{1}", AverageGrade, Environment.NewLine);
            student.AppendFormat("Dropout reason: {0}{1}", DropoutReason, Environment.NewLine);

            Console.WriteLine(student.ToString());
        }
    }
}
