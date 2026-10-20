using System.Security.Cryptography;
using Westcoast_Education.Enums;

namespace Westcoast_Education.Models;

public class Course(string courseNumber, string courseName, int length, string courseLength, string courseType)
{
    public string CourseNumber { get; set; } = courseNumber;
    public string CourseName { get; set; } = courseName;
    public int Length { get; set; } = length;
    public CourseLengthEnum courseLength;
    public CourseTypeEnum courseType;
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }

    public override string ToString()
    {
        return $"Kursnamn: {CourseName}\nLängd: {Length} {courseLength}\nTyp: {courseType}";
    }
}