using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    abstract class Course : ICourse
    {
        private string Name { get; set; }
        private string TeacherName { get; set; }
        private IList<string> Students { get; set; }
        private string Lab { get; set; }
        private string Town { get; set; }

        public Course(string name, string teacherName, IList<string> students, string lab)
        {
            
        }
    }
}
