using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_2_._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(' ');

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                if (IsStudentExisting(firstName, lastName, students))
                {
                    Student student = students.Find(student => student.FirstName == firstName && student.LastName == lastName);
                    student.Age = age;
                    student.HomeTown = city;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = city
                    };

                    students.Add(student);
                }

                line = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            foreach (var student in students)
            {
                if (student.HomeTown == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

            // THATS A SECOND OPTION FOR SORTING. THIS IS SORTING WITH LINQ.

            //List<Student> filterStudentByCity = students.Where(student => student.HomeTown == filterCity).ToList();

            //foreach (var student in filterStudentByCity)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            //}

        }

        static bool IsStudentExisting(string firstName, string lastName, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

    }


    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }


    }

}
