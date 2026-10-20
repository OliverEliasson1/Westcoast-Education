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
        string courseNumber = Console.ReadLine()!;
        Console.Write("Kursnamn: ");
        string title = Console.ReadLine()??"";
        Console.Write("Längd (Antal): ");
        int length = int.Parse(Console.ReadLine()!);
        Console.Write("1. Dagar - 2. Veckor: ");
        string lengthUnitString = Console.ReadLine()!;
        Console.Write("1. Klassrum - 2. Distans - 3. Hybrid: ");
        string courseTypeString = Console.ReadLine()!;
        Console.Write("Startdatum (ÅÅÅÅ-MM-DD): ");
        DateOnly startDate = DateOnly.Parse(Console.ReadLine()!);
        Console.Write("Slutdatum (ÅÅÅÅ-MM-DD): ");
        DateOnly endDate = DateOnly.Parse(Console.ReadLine()!);

        CourseTypeEnum courseType = courseTypeString switch{"1"=>CourseTypeEnum.Classroom, "2" => CourseTypeEnum.Distance, "3" => CourseTypeEnum.Hybrid, _ => CourseTypeEnum.Unknown};
        LengthUnitEnum lengthUnit = lengthUnitString switch{"1"=>LengthUnitEnum.Days, "2" => LengthUnitEnum.Weeks, _ => LengthUnitEnum.Unknown};

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
