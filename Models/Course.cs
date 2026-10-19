namespace Westcoast_Education;

class Course(string courseName, int length, string courseLength, string courseType)
{
    public string CourseName { get; set; } = courseName;
    public int Length { get; set; } = length;
    public string CourseLength { get; set; } = courseLength;
    public string CourseType { get; set; } = courseType;

    public override string ToString()
    {
        return $"Kursnamn: {CourseName} - Längd: {Length} {CourseLength} - Typ: {CourseType}";
    }
}