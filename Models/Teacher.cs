namespace Westcoast_Education.Models;

public class Teacher : Person
{
    public required string KnowledgeArea { get; set; }
    public List<string> CourseNumbers {get; set;} = [];

    public override string ToString()
    {
        return $"{base.ToString()}\nKunskapsområde: {KnowledgeArea}";
    }
}
