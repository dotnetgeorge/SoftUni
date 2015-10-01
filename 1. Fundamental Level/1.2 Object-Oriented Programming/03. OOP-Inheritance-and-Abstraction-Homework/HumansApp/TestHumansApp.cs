using System.Collections.Generic;
using System.Linq;
using HumansApp.Humans;
using static System.Console;

namespace HumansApp
{
    internal class TestHumansApp
    {
        public static string FirstName;
        public static string LastName;

        static void Main()
        {
            var students = new List<Student>();
            var workers = new List<Worker>();

            InitializeStudents(ref students);
            InitializeWorkers(ref workers);

            students = SortStudents(students);
            workers = SortWorkers(workers);

            PrintStudents(students);
            PrintWorkers(workers);
        }

        public static void InitializeStudents(ref List<Student> students)
        {
            for (var i = 0; i < 10; i++)
            {
                WriteLine("Fill info about student #{0}", (i + 1));
                Write("First Name: ");
                FirstName = ReadLine();

                Write("Last Name: ");
                LastName = ReadLine();

                Write("Faculty Number: ");
                var facultyNumber = ReadLine();

                var student = new Student(FirstName, LastName, facultyNumber);
                students.Add(student);

                Clear();
            }
        }

        public static void InitializeWorkers(ref List<Worker> workers)
        {
            for (var i = 0; i < 10; i++)
            {
                WriteLine("Fill info about worker #{0}", (i + 1));
                Write("First Name: ");
                FirstName = ReadLine();

                Write("Last Name: ");
                LastName = ReadLine();

                Write("Week Salary: ");
                var weekSalary = double.Parse(ReadLine());

                Write("Work Hours Per Day: ");
                var workHoursPerDay = double.Parse(ReadLine());

                var worker = new Worker(FirstName, LastName, weekSalary, workHoursPerDay);
                workers.Add(worker);

                Clear();
            }
        }

        public static List<Student> SortStudents(List<Student> students)
        {
            var sortStudents = from student in students
                orderby student.FacultyNumber ascending
                select student;

            //return students.OrderBy(x => x.FacultyNumber).ToList();

            return sortStudents.ToList();
        }

        public static List<Worker> SortWorkers(List<Worker> workers)
        {
            var sortWorkers = from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;

            //return workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            return sortWorkers.ToList();
        }

        //public static List<Human> Merge(List<Student> students, List<Worker> workers)
        //{
        //    List<Student> result = students.Union(workers);
        //}

        public static void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                WriteLine("Student Info");
                WriteLine("First Name: {0}", student.FirstName);
                WriteLine("Last Name: {0}", student.LastName);
                WriteLine("Faculty Number: {0}", student.FacultyNumber);
            }
        }

        public static void PrintWorkers(List<Worker> workers)
        {
            foreach (var worker in workers)
            {
                WriteLine("Worker Info");
                WriteLine("First Name: {0}", worker.FirstName);
                WriteLine("Last Name: {0}", worker.LastName);
                WriteLine("Week Salary: {0}", worker.WeekSalary);
                WriteLine("Work Hours Per Day: {0}", worker.WorkHoursPerDay);
                WriteLine("Money Per Hour: {0}", worker.MoneyPerHour());
            }
        }
    }
}