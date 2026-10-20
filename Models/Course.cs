using Westcoast_Education.Enums;

namespace Westcoast_Education.Models;

public class Course
{
    public required string CourseNumber { get; set; }
    public required string Title { get; set; }
    public required int Length { get; set; }
    public required LengthUnitEnum LengthUnit { get; set;}
    public required CourseTypeEnum CourseType { get; set; }
    public required DateOnly StartDate { get; set; }
    public required DateOnly EndDate { get; set; }

    public override string ToString()
    {
        return $"Kursnummer: {CourseNumber}\nKursnamn: {Title}\nLängd: {Length} {LengthUnit}\nTyp: {CourseType}\nStartDatum: {StartDate}\nSlutdatum: {EndDate}";
    }
}