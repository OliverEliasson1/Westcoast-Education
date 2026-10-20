using System;

namespace Westcoast_Education.Models;

public class Teacher : Person
{
    public string KnowledgeArea { get; set; }
    public List<string> CourseNumbers {get; set;}
}
