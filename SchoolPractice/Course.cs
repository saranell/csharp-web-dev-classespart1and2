using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        private string Subject { get; set; }
        private string Teacher { get; set; }
        private List<Student> enrolledStudents;

        public Course(string subject, string teacher, List students)
        {
            Subject = subject;
            Teacher = teacher;
            Student = students;
        }

    }

}