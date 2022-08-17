using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            // Instantiate the Student class using yourself as the student. For the NumberOfCredits give yourself 1 and a GPA of 4.0.
            Student sara = new Student("Sara", 1, 1, 4.0);
            Console.WriteLine(sara.Name + " is a student!");
        }
    }
}
