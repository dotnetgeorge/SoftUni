namespace SULS.Persons
{
    public class JuniorTrainer : Trainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JuniorTrainer"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        public JuniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            
        }
    }
}