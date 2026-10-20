using System.Security.Cryptography;
using Westcoast_Education.Enums;

namespace Westcoast_Education.Models;

public class Course()
{
    public required string CourseNumber { get; set; }
    public required string Title { get; set; }
    public required int Length { get; set; }
    public required LengthUnitEnum LengthUnit;
    public required CourseTypeEnum CourseType;
    public required DateOnly StartDate { get; set; }
    public required DateOnly EndDate { get; set; }

    public override string ToString()
    {
        return $"Kursnamn: {Title}\nLängd: {Length} {LengthUnit}\nTyp: {CourseType}";
    }
}