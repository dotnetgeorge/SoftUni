using System;
using System.Collections.Generic;
using System.Linq;
using ClassStudent.Data;

class TestStudent
{
    public static List<Student> students = new List<Student>()
        {
            new Student() {
                FirstName = "Harold",
                LastName = "Smith",
                Age = 25,
                FacultyNumber = "2-M",
                Phone = "+359-9776-45-763",
                Email = "test@abv.bg",
                GroupName = "IT",
                GroupNumber = 2,
                Marks = new List<int>() {2,2,3,4}},
            new Student() {
                FirstName = "John",
                LastName = "Smith",
                Age = 20,
                FacultyNumber = "2-M",
                Phone = "+359-9776-45-763",
                Email = "test@abv.bg",
                GroupName = "Test",
                GroupNumber = 2,
                Marks = new List<int>() {3,4,5,6}},
            new Student() {
                FirstName = "Gregory",
                LastName = "Smith",
                Age = 18,
                FacultyNumber = "2-M",
                Phone = "+359-9776-45-763",
                Email = "test@yahoo.com",
                GroupName = "IT",
                GroupNumber = 2,
                Marks = new List<int>() {3,3,3,4}},
            new Student() {
                FirstName = "Elly",
                LastName = "Smith",
                Age = 24,
                FacultyNumber = "2-M",
                Phone = "02-9776-45-763",
                Email = "test@gmail.com",
                GroupName = "Test",
                GroupNumber = 3,
                Marks = new List<int>() {5,5,6,7}}
        };

    static void Main(string[] args)
    {
        StudentsByGroup();

        SortByFirstAndLastName();

        StudentsByAge();

        SortStudents();

        FilterStudentsByEmail();

        FilterStudentsByPhone();

        ExcellentStudents();

        WeakStudents();

        StudentsEnrolled();

        GroupByName();
        
    }

    /*
    *   Problem 2.	Students by Group
    *   Print all students from group number 2. Use a LINQ query. Order the students by FirstName.
    */
    public static void StudentsByGroup()
    {
        var orderByGroup = from student in students
                           where student.GroupNumber == 2
                           orderby student.FirstName
                           select student;

        foreach (var item in orderByGroup)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName);
        }
    }

    /*
    *   Problem 3.	Students by First and Last Name
    *   Print all students whose first name is before their last name alphabetically. Use a LINQ query.
    */
    public static void SortByFirstAndLastName()
    {
        var sortAlphNames = from student in students
                            where student.FirstName.CompareTo(student.LastName) == -1
                            select student;

        foreach (var item in sortAlphNames)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName);
        }
    }

    /*
    *   Problem 4.	Students by Age
    *   Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. 
    *   The query should return only the first name, last name and age.
    */
    public static void StudentsByAge()
    {
        var betweenAge = from student in students
                         where student.Age >= 18 & student.Age <= 24
                         select new { FirstName = student.FirstName, LastName = student.LastName, Age = student.Age };


        foreach (var item in betweenAge)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
        }
    }


    /*
    *   Problem 5.	Sort Students
    *   Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
    *   by first name and last name in descending order. Rewrite the same with LINQ query syntax.
    */
    public static void SortStudents()
    {
        //var sortedStudents = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
        var sortedStudents = from student in students
                             orderby student.FirstName descending, student.LastName descending
                             select student;

        foreach (var item in sortedStudents)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
        }
    }

    /*
    *   Problem 6.	Filter Students by Email Domain
    *   Print all students that have email @abv.bg. Use LINQ.
    */
    public static void FilterStudentsByEmail()
    {
        var email = from student in students
                    where student.Email.Contains("@abv.bg")
                    select student;

        foreach (var item in email)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Email);
        }
    }

    /*
    *   Problem 7.	Filter Students by Phone
    *   Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). 
    *Use LINQ.
    */
    public static void FilterStudentsByPhone()
    {
        var phone = from student in students
                    where student.Phone.StartsWith("02") | student.Phone.StartsWith("+3592") | student.Phone.StartsWith("+359 2")
                    select student;

        foreach (var item in phone)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Phone);
        }
    }

    /*
    *   Problem 8.	Excellent Students
    *   Print all students that have at least one mark Excellent (6). 
    *   Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.
    */
    public static void ExcellentStudents()
    {
        var excellentStudents = from student in students
                                where student.Marks.Contains(6)
                                select student;

        foreach (var item in excellentStudents)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName);
        }
    }

    /*
    *   Problem 9.	Weak Students
    *   Write a similar program to the previous one to extract the students with exactly two marks "2". 
    *   Use extension methods.
    */
    public static void WeakStudents()
    {
        //var weakStudents = from student in students
        //                   where student.Marks.Count(x => x == 2) == 2
        //                   select student;

        var weakStudents = students.Where(x => x.Marks.Count(y => y == 2) == 2);

        foreach (var item in weakStudents)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName);
        }
    }

    /*
    *   Problem 10.	Students Enrolled in 2014
    *   Extract and print the Marks of the students that enrolled in 2014 
    *   (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).
    */
    public static void StudentsEnrolled()
    {
        var studentsEnrolled = from student in students
                               where student.FacultyNumber.EndsWith("14")
                               select student;

        foreach (var item in studentsEnrolled)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName);
        }
    }

    /*
    *   Problem 11.	* Students by Groups
    *   Add a GroupName property to Student. 
    *   Write a program that extracts all students grouped by GroupName and then prints them on the console. 
    *   Print all group names along with the students in each group. 
    *   Use the "group by into" LINQ operator.
    */
    public static void GroupByName()
    {
        var grouped = from student in students
                      group student by student.GroupName into results
                      from result in results
                      select new {FirstName = result.FirstName, LastName = result.LastName, GroupName = result.GroupName };

        foreach (var item in grouped)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.GroupName);
        }
    }
}