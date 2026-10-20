using System.Collections.Specialized;
using Westcoast_Education.Models;
using Westcoast_Education.Persistence;


namespace Westcoast_Education.Services;

public class CourseService
{
    static readonly string path = string.Concat(Environment.CurrentDirectory,"/Data/Courses.json");
    static readonly List<Course> courses = Storage<Course>.Read(path);
    public static void AddCourse()
    {
        Console.Write("Kursnummer: ");
        string courseNumber = Console.ReadLine();
        Console.Write("Kursnamn: ");
        string courseName = Console.ReadLine();
        Console.Write("Längd (dagar eller veckor): ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Dagar eller veckor?: ");
        string courseLength = Console.ReadLine();
        Console.Write("Klassrum, Distans eller Hybrid?: ");
        string courseType = Console.ReadLine();
        Console.Write("Startdatum: ");
        string startDate = Console.ReadLine();
        Console.Write("Slutdatum: ");
        string endDate = Console.ReadLine();

        Course course = new(courseNumber, courseName, length, courseLength, courseType);

        courses.Add(course);
        Storage<Course>.Write(courses, path);
    }

    public static void ShowCourses()
    {
        bool isEmpty = !courses.Any();

        if (isEmpty)
        {
            Console.WriteLine("Listan är tom");
        }
            foreach (var item in courses)
        {
            Console.WriteLine(item);
            Console.WriteLine("");
        }
    }
}
