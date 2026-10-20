using Westcoast_Education.Models;
using Westcoast_Education.Persistence;
using Westcoast_Education.Enums;
using System.Collections;


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
        string title = Console.ReadLine();
        Console.Write("Längd (dagar eller veckor): ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Dagar eller veckor?: ");
        LengthUnitEnum lengthUnit = Console.ReadLine();
        Console.Write("Klassrum, Distans eller Hybrid?: ");
        string courseTypeString = Console.ReadLine();
        Console.Write("Startdatum: ");
        DateOnly startDate = Console.ReadLine();
        Console.Write("Slutdatum: ");
        DateOnly endDate = Console.ReadLine();

        CourseTypeEnum courseType = courseTypeString switch{"1"=>CourseTypeEnum.Classroom, "2" => CourseTypeEnum.Distance, "3" => CourseTypeEnum.Hybrid, _ => CourseTypeEnum.Unknown};

        Course course = new Course
        {
            CourseNumber = courseNumber,
            Title = title,
            Length = length,
            LengthUnit = lengthUnit,
            CourseType = courseType,
            StartDate = startDate,
            EndDate = endDate
        };

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
