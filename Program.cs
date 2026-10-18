namespace Westcoast_Education;

class Program
{
    public static List<Course> courses = [];
    static void Main()
    {
        
        while (true)
        {
            Console.WriteLine("Välkommen till Westcoast Education");
            Console.WriteLine("1. Visa kurser");
            Console.WriteLine("2. Lägg till kurser");
            Console.WriteLine("3. Avsluta");
            var key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    bool isEmpty = !courses.Any();

                    if (isEmpty)
                    {
                        Console.WriteLine("Listan är tom");
                    }
                    foreach (var item in courses)
                    {
                        Console.WriteLine(item);
                    }
                break;
                case "2":
                    Console.Write("Kursnamn: ");
                    string courseName = Console.ReadLine();
                    Console.Write("Längd (dagar eller veckor): ");
                    int length = int.Parse(Console.ReadLine());
                    Console.Write("Dagar eller veckor?: ");
                    string courseLength = Console.ReadLine();
                    Console.Write("Klassrum, distans eller hybrid?: ");
                    string courseType = Console.ReadLine();

                    Course course = new(courseName, length, courseLength, courseType);

                    courses.Add(course);
                break;
                case "3":
                Environment.Exit(0);
                break;

                default:
                break;
            }
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