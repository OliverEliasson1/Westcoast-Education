using System.Security.Cryptography;

namespace Westcoast_Education.Models;

public class Course(string courseName, int length, string courseLength, string courseType, string startDate, string endDate)
{
    public string CourseName { get; set; } = courseName;
    public int Length { get; set; } = length;
    public string CourseLength { get; set; } = courseLength;
    public string CourseType { get; set; } = courseType;
    public string StartDate { get; set; } = startDate;
    public string EndDate { get; set; } = endDate;

    public override string ToString()
    {
        return $"Kursnamn: {CourseName}\nLängd: {Length} {CourseLength}\nTyp: {CourseType}";
    }
}