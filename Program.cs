namespace Westcoast_Education;

using Westcoast_Education.Persistence;
using Westcoast_Education.Models;
class Program
{
    static string path = string.Concat(Environment.CurrentDirectory,"/Data/Courses.json");
    static string studentPath = string.Concat(Environment.CurrentDirectory,"/Data/Students.json");
    
    static void Main()
    {
        List<Student> students = [];
        students = Storage<Student>.Read(studentPath);
        
        List<Course> courses = [];
        courses = Storage<Course>.Read(path);
    
        Console.WriteLine("Välkommen till Westcoast Education");
        Console.WriteLine("1. Visa kurser");
        Console.WriteLine("2. Lägg till kurser");
        Console.WriteLine("3. Visa Studenter");
        Console.WriteLine("4. Lägg till Studenter");
        Console.WriteLine("5. Avsluta programmet");
        
        while (true)
        {
            
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
                        Console.WriteLine("");
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
                    Storage<Course>.Write(courses, path);
                break;
                case "3":
                    bool studentsIsEmpty = !students.Any();

                    if (studentsIsEmpty)
                    {
                        Console.WriteLine("Listan är tom");      
                    }
                    foreach (var item in students)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("");
                    }
                break;
                case "4":
                    Console.Write("Elevens personnummer");
                    string personalNumber = Console.ReadLine();
                    Console.Write("Elevens förnamn: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Elevens efternamn: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Elevens email: ");
                    string email = Console.ReadLine();
                    Console.Write("Elevens telefonnummer: ");
                    string phoneNumber = Console.ReadLine();
                    Console.Write("Elevens gatuadress:");
                    string streetAddress = Console.ReadLine();
                    Console.Write("Elevens postnummer: ");
                    string postalCode = Console.ReadLine();
                    Console.Write("Elevens stad");
                    string city = Console.ReadLine();

                    Student student = new Student
                    {
                        PersonalIdentityNumber = personalNumber,
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        PhoneNumber = phoneNumber,
                        Address = new Address
                        {
                            StreetAddress = streetAddress,
                            PostalCode = postalCode,
                            City = city
                        }
                    };
                    students.Add(student);
                    Storage<Student>.Write(students, studentPath);
                    
                break;

                case "5":
                return;

                default:
                break;
            }
        }
    }
}







