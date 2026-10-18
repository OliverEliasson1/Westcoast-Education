namespace Westcoast_Education;

class Program
{
    static void Main()
    {
        List<Course> courses = [];

        string courseName = Console.ReadLine();
        int length = int.Parse(Console.ReadLine());
        string courseLength = Console.ReadLine();
        string courseType = Console.ReadLine();

        Course course = new(courseName, length, courseLength, courseType)

        courses.Add(course);


        foreach (var item in courses)
        {
            Console.WriteLine(item);
        }
        
    }
}

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