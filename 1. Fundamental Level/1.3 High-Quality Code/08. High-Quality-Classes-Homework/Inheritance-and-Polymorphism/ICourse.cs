namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    interface ICourse
    {
        string Name { get; set; }
        string TeacherName { get; set; }
        IList<string> Students { get; set; }
        string Lab { get; set; }
        string Town { get; set; }
    }
}
