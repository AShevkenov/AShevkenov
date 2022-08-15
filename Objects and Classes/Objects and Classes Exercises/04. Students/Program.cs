using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] currentStudentInfo = Console.ReadLine().Split(' ');
                var student = new Student(currentStudentInfo[0], currentStudentInfo[1], double.Parse(currentStudentInfo[2]));
                students.Add(student);
            }

            students = students.OrderByDescending(currStudent => currStudent.Grade).ToList();

            students.ForEach(student => Console.WriteLine(student));
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";
       
    }
}
