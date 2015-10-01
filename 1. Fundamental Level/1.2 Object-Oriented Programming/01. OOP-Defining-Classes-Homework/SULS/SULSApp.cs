using System;
using System.Linq;

namespace SULS
{
    using System.Collections.Generic;
    using Persons;

    internal class SulsApp
    {
        private static void Main()
        {
            var persons = new List<Student>
            {
                new CurrentStudent("John", "De Luca", 22, "444-555-11", 4.25, "HTML5/CSS3"),
                new CurrentStudent("Maria", "Hose", 19, "333-444-12", 5.75, "JavaScript Basics"),
                new DropoutStudent("Pesho", "Iliev", 21, "777-888-41", 3.25, "Too complicated for me."),
                new GraduateStudent("Svetlio", "Nakov", 33, "111-111-11", 6)
                //new JuniorTrainer("Ivan", "Vasilev", 27),
                //new SeniorTrainer("Spiridon", "Sofroniev", 35)
            };

            var currentStudents = persons.Where(x => x.GetType() == typeof(CurrentStudent)).OrderBy(x => x.AverageGrade);

            foreach (var student in currentStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}