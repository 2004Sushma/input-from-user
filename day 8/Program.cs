using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int Marks;
    public int Attendance;
    public int Participation;
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();

            Console.WriteLine($"\nEnter details for Student {i + 1}:");

            Console.Write("Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Marks: ");
            s.Marks = int.Parse(Console.ReadLine());

            Console.Write("Attendance: ");
            s.Attendance = int.Parse(Console.ReadLine());

            Console.Write("Participation: ");
            s.Participation = int.Parse(Console.ReadLine());

            students.Add(s);
        }

        // US1 → Func + Anonymous Method
        Func<Student, int> calculateTotal = delegate (Student s)
        {
            return s.Marks + s.Attendance + s.Participation;
        };

        // US2 → Action + Lambda
        Action<Student> display = s =>
        {
            Console.WriteLine($"Name: {s.Name}, Total: {calculateTotal(s)}");
        };

        // US3 → Predicate + Lambda
        Predicate<Student> isEligible = s => s.Marks > 50;

        // US4 → Predicate + List.FindAll
        Predicate<Student> topPerformer = s => s.Marks > 75;

        Console.WriteLine("\nAll Students:");
        students.ForEach(display);

        Console.WriteLine("\nEligible Students (Marks > 50):");
        students.FindAll(isEligible).ForEach(display);

        Console.WriteLine("\nTop Performers (Marks > 75):");
        students.FindAll(topPerformer).ForEach(display);
    }
}